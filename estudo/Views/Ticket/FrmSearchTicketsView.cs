using estudo.Controllers;
using estudo.Dto.Search.Tickets;
using estudo.Enums;
using estudo.Repositories;
using estudo.Views.Employee;
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
        private TicketController ticketController;
        private TicketSearchDto ticketSearchDto;
        public FrmSearchTicketsView(TicketController controller)
        {
            InitializeComponent();
            this.Text = "Pesquisa de Tickets";
            ticketSearchDto = new TicketSearchDto(null);
            ticketController = controller;
            MountSituations();
            SearchTickets();

        }
        public void SearchTickets()
        {
            GetFilters();
            var tickets = ticketController.SearchTickets(ticketSearchDto);
            dgvTickets.Rows.Clear();
            SetupDataGridViewColumns();
            foreach (var ticket in tickets)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvTickets);
                row.Cells[0].Value = ticket.Id;
                row.Cells[1].Value = ticket.Quantity;
                row.Cells[2].Value = ticket.Employee.Name;
                row.Cells[3].Value = ticket.CreatedAt;
                if(ticket.Situation == TicketSituationEnum.Active)
                {
                    row.Cells[4].Value = "Ativo";
                }
                else
                {
                    row.Cells[4].Value = "Inativo";
                }
                dgvTickets.Rows.Add(row);
            }
        }
        private void SetupDataGridViewColumns()
        {
            dgvTickets.Columns.Add("Id", "Id");
            dgvTickets.Columns.Add("Quantity", "Quantidade");
            dgvTickets.Columns.Add("Employee", "Funcionário");
            dgvTickets.Columns.Add("CreatedAt", "Data de Criação");
            dgvTickets.Columns.Add("Situation", "Situação");
        }
        private void GetFilters()
        {
            ticketSearchDto.Slug = txtSlug.Text;
            ticketSearchDto.StartDate = dtpDataInicio.Value;
            ticketSearchDto.EndDate = dtpDataFinal.Value;
            var selectedSituation = (dynamic)cbxSituacao.SelectedItem;
            ticketSearchDto.Situation = (TicketSituationEnum)selectedSituation.Value;
        }
        private void MountSituations()
        {
            cbxSituacao.DataSource = Enum.GetValues(typeof(TicketSituationEnum));
        }

        private void FrmSearchTicketsView_Load(object sender, EventArgs e)
        {


        }

        private void txtSlug_TextChanged(object sender, EventArgs e)
        {
            SearchTickets();
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmStoreOrEditTicket frm = new FrmStoreOrEditTicket(null);
            frm.ShowDialog();
            SearchTickets();
        }
    }
}
