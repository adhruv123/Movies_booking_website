using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.ViewModels
{
    public class MovieCreateViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Release Year is required")]
        [Display(Name = "Release Year")]
        public string ReleaseDate { get; set; }

        [Required(ErrorMessage = "Release Genre is required")]
        [Display(Name = "Release Genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Release Language is required")]
        [Display(Name = "Release Language")]
        public string Language { get; set; }


        public IFormFile Poster { get; set; }
    }
}
