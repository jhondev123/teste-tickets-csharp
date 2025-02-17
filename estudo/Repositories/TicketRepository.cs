using estudo.Contexts;
using estudo.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Repositories
{
    public class TicketRepository
    {
        private EstudoContext _context;
        public TicketRepository(EstudoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }
        public IEnumerable<Models.Ticket> SearchTickets(
            DateTime? startDate = null,
            DateTime? endDate = null,
            TicketSituationEnum? situation = null,
            string? slug = null
        )
        {
            return _context.Ticket
              .Include(t => t.Employee)
              .Where(t =>
                  (startDate == null || t.CreatedAt >= startDate) &&
                  (endDate == null || t.CreatedAt <= endDate) &&
                  (situation == null || t.Situation == situation) &&
                  (slug == null ||
                  t.Id.ToString().Contains(slug) ||
                  t.Quantity.ToString().Contains(slug) || t.Employee.Name.Contains(slug)
                  )
              )
              .ToList();

        }
        public IEnumerable<Models.Ticket> GetAllTickets()
        {
            return _context.Ticket.ToList();
        }
        public Models.Ticket? GetTicketById(int id)
        {
            return _context.Ticket.Find(id);
        }
        public bool StoreTicket(Models.Ticket ticket)
        {
            ticket.CreatedAt = DateTime.UtcNow;
            _context.Ticket.Add(ticket);
            _context.SaveChanges();
            return true;
        }
    }
}
