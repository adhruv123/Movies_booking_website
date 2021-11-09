using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class Show
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string Language { get; set; }

        public decimal Price { get; set; }

    }
}
