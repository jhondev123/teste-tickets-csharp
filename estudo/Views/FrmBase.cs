using estudo.Views.Employee;
using estudo.Views.Ticket;
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

namespace estudo.Views
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmSearchEmployeesView)
                {
                    form.Activate();  // Traz a aba para frente
                    return;
                }
            }

            FrmSearchEmployeesView frmSearchEmployeesView = Program.serviceProvider.
                GetRequiredService<FrmSearchEmployeesView>();

            frmSearchEmployeesView.Show();
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmSearchTicketsView)
                {
                    form.Activate();  // Traz a aba para frente
                    return;
                }
            }

            FrmSearchTicketsView formSearchTickets = Program.serviceProvider.
                GetRequiredService<FrmSearchTicketsView>();

            formSearchTickets.Show();
        }
    }
}
