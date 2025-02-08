namespace estudo.Views.Employee
{
    partial class FrmStoreOrEditView
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
            panel1 = new Panel();
            txtNome = new TextBox();
            lblNome = new Label();
            panel2 = new Panel();
            txtCpf = new TextBox();
            lblCpf = new Label();
            panel3 = new Panel();
            cbxSituacao = new ComboBox();
            lblSituacao = new Label();
            btnCadastrarOrEdit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 83);
            panel1.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(10, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(10, 14);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCpf);
            panel2.Controls.Add(lblCpf);
            panel2.Location = new Point(405, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 83);
            panel2.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(10, 32);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(349, 23);
            txtCpf.TabIndex = 1;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(10, 14);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(26, 15);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "Cpf";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbxSituacao);
            panel3.Controls.Add(lblSituacao);
            panel3.Location = new Point(12, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 83);
            panel3.TabIndex = 2;
            // 
            // cbxSituacao
            // 
            cbxSituacao.FormattingEnabled = true;
            cbxSituacao.Location = new Point(10, 41);
            cbxSituacao.Name = "cbxSituacao";
            cbxSituacao.Size = new Size(349, 23);
            cbxSituacao.TabIndex = 1;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(10, 14);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 0;
            lblSituacao.Text = "Situação";
            // 
            // btnCadastrarOrEdit
            // 
            btnCadastrarOrEdit.Location = new Point(408, 364);
            btnCadastrarOrEdit.Name = "btnCadastrarOrEdit";
            btnCadastrarOrEdit.Size = new Size(75, 23);
            btnCadastrarOrEdit.TabIndex = 3;
            btnCadastrarOrEdit.Text = "Cadastrar";
            btnCadastrarOrEdit.UseVisualStyleBackColor = true;
            btnCadastrarOrEdit.Click += btnCadastrarOrEdit_Click;
            // 
            // FrmStoreOrEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarOrEdit);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmStoreOrEditView";
            Text = "FrmStoreOrEditView";
            Load += FrmStoreOrEditView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNome;
        private Label lblNome;
        private Panel panel2;
        private TextBox txtCpf;
        private Label lblCpf;
        private Panel panel3;
        private ComboBox cbxSituacao;
        private Label lblSituacao;
        private Button btnCadastrarOrEdit;
    }
}