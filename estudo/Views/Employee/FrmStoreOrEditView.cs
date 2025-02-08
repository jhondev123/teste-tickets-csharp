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
        public FrmStoreOrEditView()
        {
            InitializeComponent();
        }

        private void FrmStoreOrEditView_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastrar Funcionário";
            btnCadastrarOrEdit.Text = "Cadastrar";
            if (IsEdit)
            {
                this.Text = "Editar Funcionário";
                btnCadastrarOrEdit.Text = "Editar";
            }
        }

        private void btnCadastrarOrEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
