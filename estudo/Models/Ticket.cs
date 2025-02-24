using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudo.Enums;

namespace estudo.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int Quantity { get; set; }
        public TicketSituationEnum Situation { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } = null;
        public DateTime? DeletedAt { get; set; } = null;

    }
}
