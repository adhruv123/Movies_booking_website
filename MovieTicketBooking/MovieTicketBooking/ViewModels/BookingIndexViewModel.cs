using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.ViewModels
{
    public class BookingIndexViewModel
    {
        public List<SelectListItem> ShowDates { get; set; }

        [Display(Name = "date")]
        public string ShowDate { get; set; }
        
        public List<SelectListItem> Languages { get; set; }
        
        public string Language { get; set; }

        [Display(Name = "title")]
        public string MovieTitle { get; set; }

        [Display(Name = "c")]
        public int MovieId { get; set; }

    }
}
