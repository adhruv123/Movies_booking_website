using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.ViewModels
{
    public class ShowCreateViewModel
    {
        public int MovieId { get; set; }

        [Display(Name ="Movie")]
        public string MovieTitle { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }
        
        [Required]
        [Display(Name ="End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public List<string> Times { get; set; }

        [Required]
        public string Time { get; set; }

        public List<string> Languages { get; set; }

        [Required]
        public string Language { get; set; }

        public double Price { get; set; }


    }
}
