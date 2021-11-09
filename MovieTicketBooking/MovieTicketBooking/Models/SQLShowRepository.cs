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

        public Show EditShow(Show changedShow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Show> GetAllShows()
        {
            throw new NotImplementedException();
        }

        public Show GetShow(int id)
        {
            throw new NotImplementedException();
        }
    }
}
