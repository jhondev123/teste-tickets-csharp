using estudo.Dto.Search.Tickets;
using estudo.Enums;
using estudo.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Controllers
{
    public class TicketController
    {
        private readonly TicketRepository _ticketRepository;
        public TicketController(TicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
        }
        public IEnumerable<Models.Ticket> SearchTickets(
            TicketSearchDto dto
        )
        {
            return _ticketRepository.SearchTickets(dto);
        }
        public IEnumerable<Models.Ticket> GetAllTickets()
        {
            return _ticketRepository.GetAllTickets();
        }
        public Models.Ticket? GetTicketById(int id)
        {
            return _ticketRepository.GetTicketById(id);
        }
        public bool Store(Models.Ticket ticket)
        {
            return _ticketRepository.StoreTicket(ticket);
        }
        public bool Update(Models.Ticket ticket)
        {
            return _ticketRepository.UpdateTicket(ticket);
        }
    }
}
