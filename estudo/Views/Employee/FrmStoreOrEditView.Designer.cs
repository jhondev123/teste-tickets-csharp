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
            pnPrincipal = new Panel();
            pnForm = new Panel();
            pnRow1 = new Panel();
            pnCpf = new Panel();
            txtCpf = new TextBox();
            lblCpf = new Label();
            pnNome = new Panel();
            txtNome = new TextBox();
            lblNome = new Label();
            pnRow2 = new Panel();
            pnSituacao = new Panel();
            cbxSituacao = new ComboBox();
            lblSituacao = new Label();
            pnButtons = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            pnPrincipal.SuspendLayout();
            pnForm.SuspendLayout();
            pnRow1.SuspendLayout();
            pnCpf.SuspendLayout();
            pnNome.SuspendLayout();
            pnRow2.SuspendLayout();
            pnSituacao.SuspendLayout();
            pnButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnPrincipal
            // 
            pnPrincipal.Controls.Add(pnForm);
            pnPrincipal.Controls.Add(pnButtons);
            pnPrincipal.Dock = DockStyle.Fill;
            pnPrincipal.Location = new Point(0, 0);
            pnPrincipal.Name = "pnPrincipal";
            pnPrincipal.Size = new Size(784, 461);
            pnPrincipal.TabIndex = 0;
            // 
            // pnForm
            // 
            pnForm.Controls.Add(pnRow1);
            pnForm.Controls.Add(pnRow2);
            pnForm.Location = new Point(0, 0);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(784, 390);
            pnForm.TabIndex = 0;
            // 
            // pnRow1
            // 
            pnRow1.Controls.Add(pnCpf);
            pnRow1.Controls.Add(pnNome);
            pnRow1.Location = new Point(0, 0);
            pnRow1.Name = "pnRow1";
            pnRow1.Size = new Size(784, 100);
            pnRow1.TabIndex = 0;
            // 
            // pnCpf
            // 
            pnCpf.Controls.Add(txtCpf);
            pnCpf.Controls.Add(lblCpf);
            pnCpf.Dock = DockStyle.Left;
            pnCpf.Location = new Point(376, 0);
            pnCpf.Name = "pnCpf";
            pnCpf.Size = new Size(408, 100);
            pnCpf.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 27);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(344, 23);
            txtCpf.TabIndex = 1;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(12, 9);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(26, 15);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "Cpf";
            // 
            // pnNome
            // 
            pnNome.Controls.Add(txtNome);
            pnNome.Controls.Add(lblNome);
            pnNome.Dock = DockStyle.Left;
            pnNome.Location = new Point(0, 0);
            pnNome.Name = "pnNome";
            pnNome.Size = new Size(376, 100);
            pnNome.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(344, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // pnRow2
            // 
            pnRow2.Controls.Add(pnSituacao);
            pnRow2.Location = new Point(0, 100);
            pnRow2.Name = "pnRow2";
            pnRow2.Size = new Size(784, 96);
            pnRow2.TabIndex = 1;
            // 
            // pnSituacao
            // 
            pnSituacao.Controls.Add(cbxSituacao);
            pnSituacao.Controls.Add(lblSituacao);
            pnSituacao.Dock = DockStyle.Left;
            pnSituacao.Location = new Point(0, 0);
            pnSituacao.Name = "pnSituacao";
            pnSituacao.Size = new Size(784, 96);
            pnSituacao.TabIndex = 1;
            // 
            // cbxSituacao
            // 
            cbxSituacao.FormattingEnabled = true;
            cbxSituacao.Location = new Point(12, 27);
            cbxSituacao.Name = "cbxSituacao";
            cbxSituacao.Size = new Size(344, 23);
            cbxSituacao.TabIndex = 1;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(12, 9);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 0;
            lblSituacao.Text = "Situação";
            // 
            // pnButtons
            // 
            pnButtons.Controls.Add(btnCancelar);
            pnButtons.Controls.Add(btnSalvar);
            pnButtons.Location = new Point(0, 388);
            pnButtons.Name = "pnButtons";
            pnButtons.Size = new Size(784, 73);
            pnButtons.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.ForeColor = Color.Transparent;
            btnCancelar.Location = new Point(540, 30);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 192, 0);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.ForeColor = Color.Transparent;
            btnSalvar.Location = new Point(659, 30);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(113, 31);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmStoreOrEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(pnPrincipal);
            Name = "FrmStoreOrEditView";
            Text = "FrmStoreOrEditView";
            Load += FrmStoreOrEditView_Load;
            pnPrincipal.ResumeLayout(false);
            pnForm.ResumeLayout(false);
            pnRow1.ResumeLayout(false);
            pnCpf.ResumeLayout(false);
            pnCpf.PerformLayout();
            pnNome.ResumeLayout(false);
            pnNome.PerformLayout();
            pnRow2.ResumeLayout(false);
            pnSituacao.ResumeLayout(false);
            pnSituacao.PerformLayout();
            pnButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label lblSituacao;
        private Button btnCadastrarOrEdit;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnPrincipal;
        private Panel pnForm;
        private Panel pnRow1;
        private Panel pnNome;
        private TextBox txtNome;
        private Label lblNome;
        private Panel pnCpf;
        private TextBox txtCpf;
        private Label lblCpf;
        private Panel pnRow2;
        private Panel pnSituacao;
        private ComboBox cbxSituacao;
        private Panel pnButtons;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}