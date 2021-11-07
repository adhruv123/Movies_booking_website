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

        public IFormFile Poster { get; set; }
    }
}
