using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IMovieRepository _repo;

        private readonly IWebHostEnvironment _env;

        public AdminController(IMovieRepository repo, IWebHostEnvironment env)
        {
            _repo = repo;
            _env = env;
        }
        public IActionResult Index()
        {
            var model = _repo.GetAllMovies();
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(MovieCreateViewModel model)
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
                _repo.AddMovie(newMovie);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var movie = _repo.GetMovie(id);

            MovieEditViewModel model = new MovieEditViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                ExistingPosterPath = movie.PosterPath,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MovieEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Movie movie = _repo.GetMovie(model.Id);
                movie.Title = model.Title;

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

                _repo.EditMovie(movie);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _repo.DeleteMovie(id);
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

    }
}

