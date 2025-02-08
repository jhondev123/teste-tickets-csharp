namespace estudo.Views.Employees
{
    partial class SearchEmployeesView
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
            grid_employees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_employees).BeginInit();
            SuspendLayout();
            // 
            // grid_employees
            // 
            grid_employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_employees.Dock = DockStyle.Fill;
            grid_employees.Location = new Point(0, 0);
            grid_employees.Name = "grid_employees";
            grid_employees.Size = new Size(800, 450);
            grid_employees.TabIndex = 0;
            grid_employees.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchEmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grid_employees);
            Name = "SearchEmployeesView";
            Text = "SearchEmployeesView";
            Load += SearchEmployeesView_Load;
            ((System.ComponentModel.ISupportInitialize)grid_employees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid_employees;
    }
}