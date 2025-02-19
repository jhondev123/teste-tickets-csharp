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
            pnPesquisa = new Panel();
            dataGridView1 = new DataGridView();
            pnSituacao = new Panel();
            lblSituacao = new Label();
            cbxSituacao = new ComboBox();
            pnSlug = new Panel();
            lblSlug = new Label();
            txtSlug = new TextBox();
            pnDatas = new Panel();
            pnDataInicio = new Panel();
            dtpDataInicio = new DateTimePicker();
            lblDataInicio = new Label();
            pnDataFinal = new Panel();
            lblDataFinal = new Label();
            dtpDataFinal = new DateTimePicker();
            pnRegistros.SuspendLayout();
            pnPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnSituacao.SuspendLayout();
            pnSlug.SuspendLayout();
            pnDatas.SuspendLayout();
            pnDataInicio.SuspendLayout();
            pnDataFinal.SuspendLayout();
            SuspendLayout();
            // 
            // pnRegistros
            // 
            pnRegistros.Controls.Add(dataGridView1);
            pnRegistros.Location = new Point(0, 193);
            pnRegistros.Name = "pnRegistros";
            pnRegistros.Size = new Size(914, 310);
            pnRegistros.TabIndex = 0;
            // 
            // pnPesquisa
            // 
            pnPesquisa.Controls.Add(pnDataInicio);
            pnPesquisa.Controls.Add(pnDatas);
            pnPesquisa.Controls.Add(pnSlug);
            pnPesquisa.Controls.Add(pnSituacao);
            pnPesquisa.Location = new Point(0, 69);
            pnPesquisa.Name = "pnPesquisa";
            pnPesquisa.Size = new Size(914, 125);
            pnPesquisa.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 310);
            dataGridView1.TabIndex = 0;
            // 
            // pnSituacao
            // 
            pnSituacao.Controls.Add(cbxSituacao);
            pnSituacao.Controls.Add(lblSituacao);
            pnSituacao.Location = new Point(0, 0);
            pnSituacao.Name = "pnSituacao";
            pnSituacao.Size = new Size(191, 125);
            pnSituacao.TabIndex = 0;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(12, 19);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(66, 20);
            lblSituacao.TabIndex = 0;
            lblSituacao.Text = "Situação";
            // 
            // cbxSituacao
            // 
            cbxSituacao.FormattingEnabled = true;
            cbxSituacao.Location = new Point(12, 52);
            cbxSituacao.Name = "cbxSituacao";
            cbxSituacao.Size = new Size(151, 28);
            cbxSituacao.TabIndex = 1;
            // 
            // pnSlug
            // 
            pnSlug.Controls.Add(txtSlug);
            pnSlug.Controls.Add(lblSlug);
            pnSlug.Location = new Point(197, 3);
            pnSlug.Name = "pnSlug";
            pnSlug.Size = new Size(254, 122);
            pnSlug.TabIndex = 1;
            // 
            // lblSlug
            // 
            lblSlug.AutoSize = true;
            lblSlug.Location = new Point(63, 16);
            lblSlug.Name = "lblSlug";
            lblSlug.Size = new Size(126, 20);
            lblSlug.TabIndex = 0;
            lblSlug.Text = "Pesquisa genérica";
            lblSlug.Click += label1_Click;
            // 
            // txtSlug
            // 
            txtSlug.Location = new Point(28, 50);
            txtSlug.Name = "txtSlug";
            txtSlug.Size = new Size(204, 27);
            txtSlug.TabIndex = 1;
            // 
            // pnDatas
            // 
            pnDatas.Controls.Add(pnDataFinal);
            pnDatas.Location = new Point(504, 0);
            pnDatas.Name = "pnDatas";
            pnDatas.Size = new Size(410, 123);
            pnDatas.TabIndex = 2;
            // 
            // pnDataInicio
            // 
            pnDataInicio.Controls.Add(lblDataInicio);
            pnDataInicio.Controls.Add(dtpDataInicio);
            pnDataInicio.Location = new Point(457, 3);
            pnDataInicio.Name = "pnDataInicio";
            pnDataInicio.Size = new Size(220, 125);
            pnDataInicio.TabIndex = 0;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(23, 67);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(182, 27);
            dtpDataInicio.TabIndex = 0;
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Location = new Point(63, 19);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(102, 20);
            lblDataInicio.TabIndex = 1;
            lblDataInicio.Text = "Data de Inicio";
            // 
            // pnDataFinal
            // 
            pnDataFinal.Controls.Add(lblDataFinal);
            pnDataFinal.Controls.Add(dtpDataFinal);
            pnDataFinal.Location = new Point(179, 5);
            pnDataFinal.Name = "pnDataFinal";
            pnDataFinal.Size = new Size(231, 123);
            pnDataFinal.TabIndex = 1;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(63, 19);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(76, 20);
            lblDataFinal.TabIndex = 1;
            lblDataFinal.Text = "Data Final";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(23, 67);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(197, 27);
            dtpDataFinal.TabIndex = 0;
            // 
            // FrmSearchTicketsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 501);
            Controls.Add(pnPesquisa);
            Controls.Add(pnRegistros);
            Name = "FrmSearchTicketsView";
            Text = "FrmSearchTicketsView";
            Load += FrmSearchTicketsView_Load;
            pnRegistros.ResumeLayout(false);
            pnPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnSituacao.ResumeLayout(false);
            pnSituacao.PerformLayout();
            pnSlug.ResumeLayout(false);
            pnSlug.PerformLayout();
            pnDatas.ResumeLayout(false);
            pnDataInicio.ResumeLayout(false);
            pnDataInicio.PerformLayout();
            pnDataFinal.ResumeLayout(false);
            pnDataFinal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnRegistros;
        private DataGridView dataGridView1;
        private Panel pnPesquisa;
        private Panel pnSituacao;
        private Panel pnSlug;
        private TextBox txtSlug;
        private Label lblSlug;
        private ComboBox cbxSituacao;
        private Label lblSituacao;
        private Panel pnDataInicio;
        private Label lblDataInicio;
        private DateTimePicker dtpDataInicio;
        private Panel pnDatas;
        private Panel pnDataFinal;
        private Label lblDataFinal;
        private DateTimePicker dtpDataFinal;
    }
}