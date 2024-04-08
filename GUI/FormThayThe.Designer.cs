namespace GUI
{
    partial class FormThayThe
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
        private void InitializeComponent()
        {
            this.dataGridViewMissingShifts = new System.Windows.Forms.DataGridView();
            this.ColumnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMissingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelReplacementEmployee = new System.Windows.Forms.Label();
            this.comboBoxReplacementEmployee = new System.Windows.Forms.ComboBox();
            this.buttonAssignReplacement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissingShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMissingShifts
            // 
            this.dataGridViewMissingShifts.AllowUserToAddRows = false;
            this.dataGridViewMissingShifts.AllowUserToDeleteRows = false;
            this.dataGridViewMissingShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissingShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmployeeName,
            this.ColumnDepartment,
            this.ColumnShift,
            this.ColumnMissingHours});
            this.dataGridViewMissingShifts.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewMissingShifts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMissingShifts.Name = "dataGridViewMissingShifts";
            this.dataGridViewMissingShifts.ReadOnly = true;
            this.dataGridViewMissingShifts.RowHeadersWidth = 51;
            this.dataGridViewMissingShifts.Size = new System.Drawing.Size(653, 369);
            this.dataGridViewMissingShifts.TabIndex = 0;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.HeaderText = "Employee Name";
            this.ColumnEmployeeName.MinimumWidth = 6;
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.ReadOnly = true;
            this.ColumnEmployeeName.Width = 125;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.HeaderText = "Department";
            this.ColumnDepartment.MinimumWidth = 6;
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.ReadOnly = true;
            this.ColumnDepartment.Width = 125;
            // 
            // ColumnShift
            // 
            this.ColumnShift.HeaderText = "Shift";
            this.ColumnShift.MinimumWidth = 6;
            this.ColumnShift.Name = "ColumnShift";
            this.ColumnShift.ReadOnly = true;
            this.ColumnShift.Width = 125;
            // 
            // ColumnMissingHours
            // 
            this.ColumnMissingHours.HeaderText = "Missing Hours";
            this.ColumnMissingHours.MinimumWidth = 6;
            this.ColumnMissingHours.Name = "ColumnMissingHours";
            this.ColumnMissingHours.ReadOnly = true;
            this.ColumnMissingHours.Width = 125;
            // 
            // labelReplacementEmployee
            // 
            this.labelReplacementEmployee.AutoSize = true;
            this.labelReplacementEmployee.Location = new System.Drawing.Point(14, 400);
            this.labelReplacementEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReplacementEmployee.Name = "labelReplacementEmployee";
            this.labelReplacementEmployee.Size = new System.Drawing.Size(151, 17);
            this.labelReplacementEmployee.TabIndex = 1;
            this.labelReplacementEmployee.Text = "Replacement Employee";
            // 
            // comboBoxReplacementEmployee
            // 
            this.comboBoxReplacementEmployee.FormattingEnabled = true;
            this.comboBoxReplacementEmployee.Location = new System.Drawing.Point(153, 396);
            this.comboBoxReplacementEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxReplacementEmployee.Name = "comboBoxReplacementEmployee";
            this.comboBoxReplacementEmployee.Size = new System.Drawing.Size(233, 24);
            this.comboBoxReplacementEmployee.TabIndex = 2;
            // 
            // buttonAssignReplacement
            // 
            this.buttonAssignReplacement.Location = new System.Drawing.Point(393, 394);
            this.buttonAssignReplacement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAssignReplacement.Name = "buttonAssignReplacement";
            this.buttonAssignReplacement.Size = new System.Drawing.Size(145, 28);
            this.buttonAssignReplacement.TabIndex = 3;
            this.buttonAssignReplacement.Text = "Assign Replacement";
            this.buttonAssignReplacement.UseVisualStyleBackColor = true;
            // 
            // FormThayThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 444);
            this.Controls.Add(this.buttonAssignReplacement);
            this.Controls.Add(this.comboBoxReplacementEmployee);
            this.Controls.Add(this.labelReplacementEmployee);
            this.Controls.Add(this.dataGridViewMissingShifts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormThayThe";
            this.Text = "Shift Replacement";
            this.Load += new System.EventHandler(this.FormThayThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissingShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewMissingShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMissingHours;
        private System.Windows.Forms.Label labelReplacementEmployee;
        private System.Windows.Forms.ComboBox comboBoxReplacementEmployee;
        private System.Windows.Forms.Button buttonAssignReplacement;
    }
}