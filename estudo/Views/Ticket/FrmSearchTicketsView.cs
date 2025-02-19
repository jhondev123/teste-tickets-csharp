using estudo.Dto.Search.Tickets;
using estudo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudo.Views.Ticket
{
    public partial class FrmSearchTicketsView : Form
    {
        private TicketRepository ticketsRepository;
        private TicketSearchDto ticketSearchDto;
        public FrmSearchTicketsView(TicketRepository ticketRepository)
        {
            InitializeComponent();
            this.Text = "Pesquisa de Tickets";
            ticketSearchDto = new TicketSearchDto(null);
        }

        private void FrmSearchTicketsView_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
