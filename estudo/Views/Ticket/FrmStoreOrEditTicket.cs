using estudo.Controllers;
using estudo.Enums;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class FrmStoreOrEditTicket : Form
    {
        private TicketController ticketController;
        private EmployeeController employeeController;
        private int? ticketId;
        public FrmStoreOrEditTicket(int? id = null)
        {
            InitializeComponent();
            ticketController = Program.serviceProvider.GetRequiredService<TicketController>();
            
            employeeController = Program.serviceProvider.GetRequiredService<EmployeeController>();
            this.Text = "Cadastro de Tickets";
            ticketId = id;
            MountSituationComboBox();
            mountEmployeeComboBox();
        }

        private bool SalvarTicket()
        {
            estudo.Models.Ticket ticket = new Models.Ticket();
            ticket.Employee = employeeController.getEmployeeById(cbxFuncionario.SelectedIndex);
            ticket.Quantity = Convert.ToInt32(txtQuantidade.Text);
            ticket.Situation = (TicketSituationEnum)cbxSituacao.SelectedIndex;
            return ticketController.Store(ticket);
        }
        private void MountSituationComboBox()
        {
            cbxSituacao.Items.Add(TicketSituationEnum.Active);
            if(ticketId != null)
            {
                cbxSituacao.Items.Add(TicketSituationEnum.Inactive);
            }
        }
        public void mountEmployeeComboBox()
        {
            List<estudo.Dto.EmployeeDto> employees = employeeController.SearchAllEmployees();
            foreach (var employee in employees)
            {
                cbxFuncionario.Items.Add(employee);
            }
        }


    }
}
