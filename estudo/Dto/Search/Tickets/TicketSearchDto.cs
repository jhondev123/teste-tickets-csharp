using estudo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Dto.Search.Tickets
{
    public class TicketSearchDto
    {
        public string? Slug { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TicketSituationEnum? Situation { get; set; }
        public TicketSearchDto(TicketSituationEnum? ticketSituation)
        {
            if(ticketSituation != null)
            {
                Situation = ticketSituation;
            }
            else
            {
                Situation = TicketSituationEnum.Active;
            }

        }
    }
}
