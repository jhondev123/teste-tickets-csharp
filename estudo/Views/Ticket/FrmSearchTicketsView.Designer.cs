namespace estudo.Views.Ticket
{
    partial class FrmSearchTicketsView
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
            pnRegistros = new Panel();
            dgvTickets = new DataGridView();
            pnSituacao = new Panel();
            cbxSituacao = new ComboBox();
            lblSituacao = new Label();
            pnSlug = new Panel();
            txtSlug = new TextBox();
            lblSlug = new Label();
            pnDataFinal = new Panel();
            lblDataFinal = new Label();
            dtpDataFinal = new DateTimePicker();
            pnDataInicio = new Panel();
            lblDataInicio = new Label();
            dtpDataInicio = new DateTimePicker();
            btnCadastrar = new Button();
            btnGerarRelatorio = new Button();
            pnRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            pnSituacao.SuspendLayout();
            pnSlug.SuspendLayout();
            pnDataFinal.SuspendLayout();
            pnDataInicio.SuspendLayout();
            SuspendLayout();
            // 
            // pnRegistros
            // 
            pnRegistros.Controls.Add(dgvTickets);
            pnRegistros.Location = new Point(0, 145);
            pnRegistros.Margin = new Padding(3, 2, 3, 2);
            pnRegistros.Name = "pnRegistros";
            pnRegistros.Size = new Size(800, 232);
            pnRegistros.TabIndex = 0;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(0, 0);
            dgvTickets.Margin = new Padding(3, 2, 3, 2);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(800, 232);
            dgvTickets.TabIndex = 0;
            // 
            // pnSituacao
            // 
            pnSituacao.Controls.Add(cbxSituacao);
            pnSituacao.Controls.Add(lblSituacao);
            pnSituacao.Location = new Point(12, 11);
            pnSituacao.Margin = new Padding(3, 2, 3, 2);
            pnSituacao.Name = "pnSituacao";
            pnSituacao.Size = new Size(167, 94);
            pnSituacao.TabIndex = 0;
            // 
            // cbxSituacao
            // 
            cbxSituacao.FormattingEnabled = true;
            cbxSituacao.Location = new Point(10, 39);
            cbxSituacao.Margin = new Padding(3, 2, 3, 2);
            cbxSituacao.Name = "cbxSituacao";
            cbxSituacao.Size = new Size(133, 23);
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
            // pnSlug
            // 
            pnSlug.Controls.Add(txtSlug);
            pnSlug.Controls.Add(lblSlug);
            pnSlug.Location = new Point(185, 11);
            pnSlug.Margin = new Padding(3, 2, 3, 2);
            pnSlug.Name = "pnSlug";
            pnSlug.Size = new Size(207, 94);
            pnSlug.TabIndex = 1;
            // 
            // txtSlug
            // 
            txtSlug.Location = new Point(22, 39);
            txtSlug.Margin = new Padding(3, 2, 3, 2);
            txtSlug.Name = "txtSlug";
            txtSlug.Size = new Size(179, 23);
            txtSlug.TabIndex = 1;
            txtSlug.TextChanged += txtSlug_TextChanged;
            // 
            // lblSlug
            // 
            lblSlug.AutoSize = true;
            lblSlug.Location = new Point(55, 12);
            lblSlug.Name = "lblSlug";
            lblSlug.Size = new Size(101, 15);
            lblSlug.TabIndex = 0;
            lblSlug.Text = "Pesquisa genérica";
            // 
            // pnDataFinal
            // 
            pnDataFinal.Controls.Add(lblDataFinal);
            pnDataFinal.Controls.Add(dtpDataFinal);
            pnDataFinal.Location = new Point(596, 11);
            pnDataFinal.Margin = new Padding(3, 2, 3, 2);
            pnDataFinal.Name = "pnDataFinal";
            pnDataFinal.Size = new Size(202, 94);
            pnDataFinal.TabIndex = 1;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(55, 14);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(59, 15);
            lblDataFinal.TabIndex = 1;
            lblDataFinal.Text = "Data Final";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(20, 39);
            dtpDataFinal.Margin = new Padding(3, 2, 3, 2);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(173, 23);
            dtpDataFinal.TabIndex = 0;
            dtpDataFinal.ValueChanged += dtpDataFinal_ValueChanged;
            // 
            // pnDataInicio
            // 
            pnDataInicio.Controls.Add(lblDataInicio);
            pnDataInicio.Controls.Add(dtpDataInicio);
            pnDataInicio.Location = new Point(398, 11);
            pnDataInicio.Margin = new Padding(3, 2, 3, 2);
            pnDataInicio.Name = "pnDataInicio";
            pnDataInicio.Size = new Size(192, 94);
            pnDataInicio.TabIndex = 0;
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Location = new Point(55, 14);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(79, 15);
            lblDataInicio.TabIndex = 1;
            lblDataInicio.Text = "Data de Inicio";
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(16, 39);
            dtpDataInicio.Margin = new Padding(3, 2, 3, 2);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(160, 23);
            dtpDataInicio.TabIndex = 0;
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
            btnCadastrar.Location = new Point(543, 113);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(232, 27);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Ticket";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.AutoSize = true;
            btnGerarRelatorio.BackColor = SystemColors.ActiveCaption;
            btnGerarRelatorio.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btnGerarRelatorio.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnGerarRelatorio.FlatStyle = FlatStyle.Flat;
            btnGerarRelatorio.Font = new Font("MesloLGS NF", 9F);
            btnGerarRelatorio.ForeColor = SystemColors.ButtonFace;
            btnGerarRelatorio.Location = new Point(300, 113);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(232, 27);
            btnGerarRelatorio.TabIndex = 5;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = false;
            // 
            // FrmSearchTicketsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 376);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(btnCadastrar);
            Controls.Add(pnDataFinal);
            Controls.Add(pnRegistros);
            Controls.Add(pnSlug);
            Controls.Add(pnDataInicio);
            Controls.Add(pnSituacao);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmSearchTicketsView";
            Text = "FrmSearchTicketsView";
            Load += FrmSearchTicketsView_Load;
            pnRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            pnSituacao.ResumeLayout(false);
            pnSituacao.PerformLayout();
            pnSlug.ResumeLayout(false);
            pnSlug.PerformLayout();
            pnDataFinal.ResumeLayout(false);
            pnDataFinal.PerformLayout();
            pnDataInicio.ResumeLayout(false);
            pnDataInicio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnRegistros;
        private DataGridView dgvTickets;
        private Panel pnSituacao;
        private ComboBox cbxSituacao;
        private Label lblSituacao;
        private Panel pnSlug;
        private TextBox txtSlug;
        private Label lblSlug;
        private Panel pnDataFinal;
        private Label lblDataFinal;
        private DateTimePicker dtpDataFinal;
        private Panel pnDataInicio;
        private Label lblDataInicio;
        private DateTimePicker dtpDataInicio;
        private Button btnCadastrar;
        private Button btnGerarRelatorio;
    }
}