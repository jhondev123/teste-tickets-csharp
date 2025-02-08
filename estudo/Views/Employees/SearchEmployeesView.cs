using estudo.Controllers;
using estudo.Dto;
using estudo.Models;
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

namespace estudo.Views.Employees
{
    public partial class SearchEmployeesView : Form
    {
        private readonly EmployeeController _employeeController;
        private List<EmployeeDto> employees;
        public SearchEmployeesView(EmployeeController employeeController)
        {
            _employeeController = employeeController;
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void SearchEmployeesView_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
   
        private void LoadEmployees()
        {
            employees = _employeeController.SearchAllEmployees();

            grid_employees.DataSource = employees;
        }
    }
}
