using estudo.Controllers;
using estudo.Enums;
using estudo.Exceptions.Models.Employee;
using estudo.Models;
using estudo.Models.Vo;
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
    public partial class FrmStoreOrEditView : Form
    {
        private bool IsEdit = false;
        private int? _IdEmployee;
        private EmployeeController _employeeController;
        public FrmStoreOrEditView(int? IdEmployee)
        {
            InitializeComponent();
            _employeeController = Program.serviceProvider.GetRequiredService<EmployeeController>();
            if (IdEmployee != null)
            {
                IsEdit = true;
                _IdEmployee = IdEmployee;
            }
        }

        private void FrmStoreOrEditView_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastrar Funcionário";
            btnSalvar.Text = "Cadastrar";
            if (IsEdit)
            {
                this.Text = "Editar Funcionário";
                btnSalvar.Text = "Editar";
            }

            mountSituation();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!validateFields())
            {
                return;
            }

            try
            {

                estudo.Models.Employee employee = new estudo.Models.Employee
                {
                    Cpf = new Cpf(txtCpf.Text),
                    Name = txtNome.Text,
                    Situation = (EmployeeSituationEnum)cbxSituacao.SelectedIndex
                };
                if (IsEdit)
                {
                    employee.Id = _IdEmployee.Value;
                    _employeeController.UpdateEmployee(employee);
                    MessageBox.Show("Funcionário atualizado com sucesso");
                }
                else
                {
                    _employeeController.StoreEmployee(employee);
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }
                this.Close();
            }

            catch (InvalidCpfException ex)
            {
                MessageBox.Show(ex.Message);
                txtCpf.Focus();
            }
            catch (AlreadyExistsCpf ex)
            {
                MessageBox.Show(ex.Message);
                txtCpf.Focus();
            }
        }
        private void mountSituation()
        {
            List<object> situationList = new List<object>
            {
                new { Id = 1, Name = "Ativo" }
            };

            if (IsEdit)
            {
                situationList.Add(new { Id = 0, Name = "Inativo" });
                this.Text = "Editar Funcionário";
                btnSalvar.Text = "Editar";
            }

            cbxSituacao.DataSource = situationList;
            cbxSituacao.DisplayMember = "Name"; 
            cbxSituacao.ValueMember = "Id"; 

            cbxSituacao.SelectedIndex = 0; 
        }
        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O campo nome é obrigatório");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("O campo CPF é obrigatório");
                txtCpf.Focus();
                return false;
            }
            if (cbxSituacao.SelectedIndex == -1)
            {
                MessageBox.Show("O campo situação é obrigatório");
                cbxSituacao.Focus();
                return false;
            }
            if(!IsEdit)
            {
                if((EmployeeSituationEnum)cbxSituacao.SelectedValue != EmployeeSituationEnum.Active)
                {
                    MessageBox.Show("Só é possível cadastrar um funcionário com situação ativa");
                    return false;
                }
            }
            return true;

        }
    }
}
