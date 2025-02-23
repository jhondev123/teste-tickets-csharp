using estudo.Contexts;
using estudo.Dto.Search.Tickets;
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
        public IEnumerable<Models.Ticket> SearchTickets(TicketSearchDto dto)
        {
            return _context.Ticket
                .Include(t => t.Employee)
                .Where(t =>
                    (dto.StartDate == null || t.CreatedAt >= dto.StartDate.Value.ToUniversalTime()) &&
                    (dto.EndDate == null || t.CreatedAt <= dto.EndDate.Value.ToUniversalTime()) &&
                    (dto.Situation == null || t.Situation == dto.Situation) &&
                    (dto.Slug == null ||
                        t.Id.ToString().Contains(dto.Slug) ||
                        t.Quantity.ToString().Contains(dto.Slug) ||
                        t.Employee.Name.Contains(dto.Slug)
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
        public bool UpdateTicket(Models.Ticket ticket)
        {
            ticket.UpdatedAt = DateTime.UtcNow;
            _context.Ticket.Update(ticket);
            _context.SaveChanges();
            return true;
        } 
    }
}
