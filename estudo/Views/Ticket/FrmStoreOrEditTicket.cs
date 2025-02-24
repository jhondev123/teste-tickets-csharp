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
            ticket.Employee = employeeController.getEmployeeById(Convert.ToInt32(cbxFuncionario.SelectedValue));
            ticket.Quantity = Convert.ToInt32(txtQuantidade.Text);
            var selectedSituation = (dynamic)cbxSituacao.SelectedItem;
            ticket.Situation = selectedSituation.Value;
            return ticketController.Store(ticket);
        }
        private void MountSituationComboBox()
        {
            cbxSituacao.Items.Clear();

            cbxSituacao.Items.Add(new { Text = "Ativo", Value = TicketSituationEnum.Active });

            if (ticketId != null)
            {
                cbxSituacao.Items.Add(new { Text = "Inativo", Value = TicketSituationEnum.Inactive });
            }

            cbxSituacao.DisplayMember = "Text";
            cbxSituacao.ValueMember = "Value";

            cbxSituacao.SelectedIndex = 0;
        }
        public void mountEmployeeComboBox()
        {
            List<estudo.Dto.EmployeeDto> employees = employeeController.SearchAllEmployees();
            cbxFuncionario.DisplayMember = "Name";
            cbxFuncionario.ValueMember = "Id";


            // Define a lista como fonte de dados
            cbxFuncionario.DataSource = employees;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(SalvarTicket())
            {
                MessageBox.Show("Ticket cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar ticket!");
            }
        }
    }
}
