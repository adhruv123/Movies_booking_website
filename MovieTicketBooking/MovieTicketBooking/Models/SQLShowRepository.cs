using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class SQLShowRepository : IShowRepository
    {
        private readonly AppDbContext _context;

        public SQLShowRepository(AppDbContext context)
        {
            _context = context;
        }

        public Show AddShow(Show newShow)
        {
            _context.Shows.Add(newShow);
            _context.SaveChanges();
            return newShow;
        }

        public Show DeleteShow(int id)
        {
            throw new NotImplementedException();
        }

       

        public IEnumerable<Show> GetAllShows()
        {
            return _context.Shows.Include(m=>m.Movie);
        }

        public Show GetShow(int id)
        {
            return _context.Shows.Find(id);

        }
    }
}
