namespace estudo.Views.Ticket
{
    partial class FrmStoreOrEditTicket
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
            btnCadastrar = new Button();
            pnFuncionario = new Panel();
            cbxFuncionario = new ComboBox();
            lblFuncionario = new Label();
            pnQuantidade = new Panel();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            pnSituacao = new Panel();
            cbxSituacao = new ComboBox();
            lblSituacao = new Label();
            pnFuncionario.SuspendLayout();
            pnQuantidade.SuspendLayout();
            pnSituacao.SuspendLayout();
            SuspendLayout();
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
            btnCadastrar.Location = new Point(276, 331);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(232, 27);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar Ticket";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // pnFuncionario
            // 
            pnFuncionario.Controls.Add(cbxFuncionario);
            pnFuncionario.Controls.Add(lblFuncionario);
            pnFuncionario.Location = new Point(82, 12);
            pnFuncionario.Name = "pnFuncionario";
            pnFuncionario.Size = new Size(299, 100);
            pnFuncionario.TabIndex = 6;
            // 
            // cbxFuncionario
            // 
            cbxFuncionario.FormattingEnabled = true;
            cbxFuncionario.Location = new Point(21, 41);
            cbxFuncionario.Name = "cbxFuncionario";
            cbxFuncionario.Size = new Size(256, 23);
            cbxFuncionario.TabIndex = 1;
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(21, 13);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(70, 15);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "Funcionário";
            // 
            // pnQuantidade
            // 
            pnQuantidade.Controls.Add(txtQuantidade);
            pnQuantidade.Controls.Add(lblQuantidade);
            pnQuantidade.Location = new Point(414, 12);
            pnQuantidade.Name = "pnQuantidade";
            pnQuantidade.Size = new Size(299, 100);
            pnQuantidade.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(13, 41);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(269, 23);
            txtQuantidade.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(13, 13);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 0;
            lblQuantidade.Text = "Quantidade";
            // 
            // pnSituacao
            // 
            pnSituacao.Controls.Add(cbxSituacao);
            pnSituacao.Controls.Add(lblSituacao);
            pnSituacao.Location = new Point(256, 137);
            pnSituacao.Name = "pnSituacao";
            pnSituacao.Size = new Size(299, 100);
            pnSituacao.TabIndex = 8;
            // 
            // cbxSituacao
            // 
            cbxSituacao.FormattingEnabled = true;
            cbxSituacao.Location = new Point(20, 45);
            cbxSituacao.Name = "cbxSituacao";
            cbxSituacao.Size = new Size(267, 23);
            cbxSituacao.TabIndex = 1;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(20, 14);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 0;
            lblSituacao.Text = "Situação";
            // 
            // FrmStoreOrEditTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnSituacao);
            Controls.Add(pnQuantidade);
            Controls.Add(pnFuncionario);
            Controls.Add(btnCadastrar);
            Name = "FrmStoreOrEditTicket";
            Text = "FrmStoreOrEditTicket";
            pnFuncionario.ResumeLayout(false);
            pnFuncionario.PerformLayout();
            pnQuantidade.ResumeLayout(false);
            pnQuantidade.PerformLayout();
            pnSituacao.ResumeLayout(false);
            pnSituacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Panel pnFuncionario;
        private Panel pnQuantidade;
        private Panel pnSituacao;
        private ComboBox cbxFuncionario;
        private Label lblFuncionario;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private ComboBox cbxSituacao;
        private Label lblSituacao;
    }
}