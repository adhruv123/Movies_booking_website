using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieTicketBooking.Models;
using MovieTicketBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Controllers
{
    public class BookingController : Controller
    {
        private readonly IMovieRepository _movieRepo;

        private readonly IShowRepository _showRepo;

        private readonly IBookingRepository _bookingRepo;

        public BookingController(IShowRepository showRepo, IMovieRepository movieRepo, IBookingRepository bookingRepo)
        {
            _movieRepo = movieRepo;
            _showRepo = showRepo;
            _bookingRepo = bookingRepo;
        }

        [HttpGet]
        public IActionResult Index(int movieId)
        {
            var movie = _movieRepo.GetMovie(movieId);
            BookingIndexViewModel model = new BookingIndexViewModel();
            char[] c = { ',', ' ' };

            foreach (var language in movie.Language.Split(c, StringSplitOptions.RemoveEmptyEntries).ToList())
            {
                model.Languages.Add(new SelectListItem() { Text = language, Value = language, Selected = false });
            }

            for(int i=0;i<3;i++)
            {
                var date = DateTime.Now.AddDays(i).ToString("dd MM yyyy");
                model.ShowDates.Add(new SelectListItem() { Text = date, Value = date, Selected = false });
            }
            
            return View(model);
        }
    }
}
