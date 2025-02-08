using estudo.Controllers;
using estudo.Dto;
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

namespace estudo.Views.Employee
{
    public partial class SearchEmployeesView : Form
    {
        private readonly EmployeeController _employeeController;
        private List<EmployeeDto> employeesDto;
        public SearchEmployeesView(EmployeeController employeeController)
        {

            InitializeComponent();
            _employeeController = employeeController;
        }

        private void SearchEmployeesView_Load(object sender, EventArgs e)
        {
            LoadEmployees();

        }

        private void LoadEmployees()
        {
            employeesDto = _employeeController.SearchAllEmployees();
            dgvEmployees.DataSource = employeesDto;

        }
        private void mountGrid()
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmStoreOrEditView frmStoreOrEditView = Program.serviceProvider.GetRequiredService<FrmStoreOrEditView>();
            frmStoreOrEditView.ShowDialog();
        }
    }
}
