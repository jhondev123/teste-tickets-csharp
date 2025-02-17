namespace estudo.Views.Employee
{
    partial class FrmSearchEmployeesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(0, 84);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(800, 339);
            dgvEmployees.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.BackColor = SystemColors.ActiveCaption;
            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("MesloLGS NF", 9F);
            btnCadastrar.ForeColor = SystemColors.ButtonFace;
            btnCadastrar.Location = new Point(556, 51);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(232, 27);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar Funcionário";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmSearchEmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvEmployees);
            Name = "FrmSearchEmployeesView";
            Text = "SearchEmployeesView";
            Load += SearchEmployeesView_Load;
            Controls.SetChildIndex(dgvEmployees, 0);
            Controls.SetChildIndex(btnCadastrar, 0);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private Button btnCadastrar;
    }
}