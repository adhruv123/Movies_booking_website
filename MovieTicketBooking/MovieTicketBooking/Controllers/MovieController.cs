using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieTicketBooking.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieTicketBooking.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repo;

        public MovieController(IMovieRepository repo)
        {
            this._repo = repo;
        }

        public ViewResult Index()
        {
            var model = _repo.GetAllMovies();
            return View(model);
        }

        public async Task<ViewResult> Details(int id)
        {
            Movie model = _repo.GetMovie(id);

            dynamic movie = await FetchMovieDetails(model.Title);

            ViewBag.Title = movie["Title"];
            ViewBag.Year = movie["Year"];
            ViewBag.Runtime = movie["Runtime"];
            ViewBag.Released = movie["Released"];
            ViewBag.Genre = movie["Genre"];

            string[] languages = movie["Language"].ToString().Split(',');
            ViewBag.Languages = languages;

            Dictionary<string, string> ratings = new Dictionary<string, string>();
            foreach (var item in movie["Ratings"])
            {
                ratings.Add(item["Source"].ToString(), item["Value"].ToString());
            }
            ViewBag.Ratings = ratings;

            List<string> actors = new List<string>();
            foreach (var item in movie["Actors"].ToString().Split(','))
            {
                actors.Add(item);
            }
            ViewBag.Actors = actors;

            ViewBag.Director = movie["Director"];

            List<string> writers = new List<string>();
            foreach (var item in movie["Writer"].ToString().Split(','))
            {
                writers.Add(item);
            }
            ViewBag.Writers = writers;

            ViewBag.Plot = movie["Plot"];

            return View(model);
        }

        public async Task<dynamic> FetchMovieDetails(string title)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://www.omdbapi.com?apikey=e3d108cb&t=" + title))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<dynamic>(apiResponse);
                }
            }
        }

    }
}
