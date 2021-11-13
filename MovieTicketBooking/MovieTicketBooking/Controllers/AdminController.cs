using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieTicketBooking.Models;
using MovieTicketBooking.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieTicketBooking.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMovieRepository _movieRepo;

        private readonly IShowRepository _showRepo;

        private readonly IWebHostEnvironment _env;

        public AdminController(IShowRepository showRepo,IMovieRepository movieRepo, IWebHostEnvironment env)
        {
            _movieRepo = movieRepo;
            _showRepo = showRepo;
            _env = env;
        }
        public IActionResult Index()
        {
            var model = _movieRepo.GetAllMovies();
            return View(model);
        }

        [HttpGet]
        public ViewResult CreateMovie()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string path = null;
                if (model.Poster != null)
                    path = ProcessUploadedFile(model.Poster);

                dynamic movieDetails = await FetchMovieDetails(model.Title,model.ReleaseYear);

                Movie newMovie = new Movie()
                {
                    Title = model.Title,
                    PosterPath = path,
                    Genre = movieDetails["Genre"].ToString(),
                    Language = movieDetails["Language"],
                    ReleaseDate=movieDetails["Released"]
                };
                _movieRepo.AddMovie(newMovie);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ViewResult EditMovie(int id)
        {
            var movie = _movieRepo.GetMovie(id);

            MovieEditViewModel model = new MovieEditViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                ReleaseYear = DateTime.Parse(movie.ReleaseDate).ToString("yyyy"),
                ExistingPosterPath = movie.PosterPath
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditMovie(MovieEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Movie movie = _movieRepo.GetMovie(model.Id);
                movie.Title = model.Title;

                dynamic movieDetails = await FetchMovieDetails(model.Title, model.ReleaseYear);

                movie.Genre = movieDetails["Genre"];
                movie.ReleaseDate = movieDetails["Released"];
                movie.Language = movieDetails["Language"];

                if (model.Poster != null)
                {
                    if (model.ExistingPosterPath != null)
                    {
                        string path = Path.Combine(_env.WebRootPath, "images", model.ExistingPosterPath);
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        System.IO.File.Delete(path);
                    }
                    movie.PosterPath = ProcessUploadedFile(model.Poster);
                }

                _movieRepo.EditMovie(movie);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult DeleteMovie(int id)
        {
            _movieRepo.DeleteMovie(id);
            return RedirectToAction("Index");
        }

        private string ProcessUploadedFile(IFormFile Poster)
        {
            string posterPath = Guid.NewGuid().ToString() + "_" + Poster.FileName;
            string uploadTo = Path.Combine(_env.WebRootPath, "images");

            Poster.CopyTo(new FileStream(Path.Combine(uploadTo, posterPath), FileMode.Create));

            return posterPath;
        }

        private async Task<dynamic> FetchMovieDetails(string title ,string releaseYear)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://www.omdbapi.com?apikey=e3d108cb&t=" + title + "&y=" + releaseYear))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<dynamic>(apiResponse);
                }
            }
        }

        /*shows*/


        public IActionResult AllShows()
        {
            var model = _showRepo.GetAllShows();

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateShow(int id)
        {
            var movie = _movieRepo.GetMovie(id);

            char[] c = { ',', ' ' };
            var languages = movie.Language.Split(c, StringSplitOptions.RemoveEmptyEntries).ToList();

            ShowCreateViewModel model = new ShowCreateViewModel()
            {
                MovieId = movie.Id,
                MovieTitle = movie.Title,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.AddDays(7).Date,
                Languages = languages,

                Price = 250,
                Times = new List<string>(){"9:00 AM", "12:00 PM","3:00 PM","6:00 PM","9:00 PM"}
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateShow(ShowCreateViewModel model)
        {
           /* if (DateTime.Compare(model.StartDate,model.EndDate) >= 0)
            {
                ModelState.AddModelError("EndDate", "End date must be valid according to start date");
                var movie = _movieRepo.GetMovie(model.MovieId);

                char[] c = { ',', ' ' };
                var languages = movie.Language.Split(c, StringSplitOptions.RemoveEmptyEntries);
                ViewBag.Languages = languages;
                var x = model.Time;
                return View(model);
            }*/

           
            Show show = new Show()
            {
                 MovieId = model.MovieId,
                 StartDate = model.StartDate.ToString(),
                 EndDate = model.EndDate.ToString(),
                 Language = model.Language,
                 Time = model.Time,
                 Price = model.Price
            };
            _showRepo.AddShow(show);
            
            

            return RedirectToAction("Index");

        }

    }
}

