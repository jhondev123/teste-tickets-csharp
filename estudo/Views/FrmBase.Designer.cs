namespace estudo.Views
{
    partial class FrmBase
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
            pnHeader = new Panel();
            btnEmployees = new Button();
            btnTickets = new Button();
            pnFooter = new Panel();
            lblFooter = new Label();
            pnHeader.SuspendLayout();
            pnFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnEmployees);
            pnHeader.Controls.Add(btnTickets);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Margin = new Padding(3, 4, 3, 4);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(914, 73);
            pnHeader.TabIndex = 0;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(193, 16);
            btnEmployees.Margin = new Padding(3, 4, 3, 4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(86, 31);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnTickets
            // 
            btnTickets.Location = new Point(582, 16);
            btnTickets.Margin = new Padding(3, 4, 3, 4);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(86, 31);
            btnTickets.TabIndex = 1;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnTickets_Click;
            // 
            // pnFooter
            // 
            pnFooter.Controls.Add(lblFooter);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 612);
            pnFooter.Margin = new Padding(3, 4, 3, 4);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(914, 48);
            pnFooter.TabIndex = 1;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(418, 16);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(73, 20);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Jhonattan";
            lblFooter.Click += lblFooter_Click;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 660);
            Controls.Add(pnHeader);
            Controls.Add(pnFooter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBase";
            Text = "FrmBase";
            Load += FrmBase_Load;
            pnHeader.ResumeLayout(false);
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Panel pnFooter;
        private Label lblFooter;
        private Button btnEmployees;
        private Button btnTickets;
    }
}