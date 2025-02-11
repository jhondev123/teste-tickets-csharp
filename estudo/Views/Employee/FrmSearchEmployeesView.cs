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
    public partial class FrmSearchEmployeesView : Form
    {
        private readonly EmployeeController _employeeController;
        private List<EmployeeDto> employeesDto;
        public FrmSearchEmployeesView(EmployeeController employeeController)
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
            mountGrid();


        }
        private void mountGrid()
        {
            dgvEmployees.CellClick -= dgvEmployees_CellClick;

            dgvEmployees.Columns["Id"].HeaderText = "Código";
            dgvEmployees.Columns["Name"].HeaderText = "Nome";
            dgvEmployees.Columns["Cpf"].HeaderText = "CPF";
            dgvEmployees.Columns["Situation"].HeaderText = "Situação";
            dgvEmployees.Columns["CreatedAt"].HeaderText = "Data de Criação";
            dgvEmployees.Columns["UpdatedAt"].HeaderText = "Última Atualização";

            if (dgvEmployees.Columns["EditColumn"] == null)
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Ações";
                btnEdit.Text = "Editar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.Name = "EditColumn";
                dgvEmployees.Columns.Add(btnEdit);
            }

            dgvEmployees.CellClick += dgvEmployees_CellClick;
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployees.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                int employeeId = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells["Id"].Value);

                FrmStoreOrEditView frmStoreOrEditView = new FrmStoreOrEditView(employeeId);
                frmStoreOrEditView.ShowDialog();
                LoadEmployees();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmStoreOrEditView frmStoreOrEditView = new FrmStoreOrEditView(null);
            frmStoreOrEditView.ShowDialog();
            LoadEmployees();
        }
    }
}
