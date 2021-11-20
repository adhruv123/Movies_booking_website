using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.ViewModels
{
    public class SelectShowViewModel : BookingIndexViewModel
    {
        public List<SelectListItem> Times { get; set; }

        public int ShowId { get; set; }

    }
}
