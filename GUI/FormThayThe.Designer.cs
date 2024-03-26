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
            this.dataGridViewMissingShifts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMissingShifts.Name = "dataGridViewMissingShifts";
            this.dataGridViewMissingShifts.ReadOnly = true;
            this.dataGridViewMissingShifts.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewMissingShifts.TabIndex = 0;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.HeaderText = "Employee Name";
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.ReadOnly = true;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.HeaderText = "Department";
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.ReadOnly = true;
            // 
            // ColumnShift
            // 
            this.ColumnShift.HeaderText = "Shift";
            this.ColumnShift.Name = "ColumnShift";
            this.ColumnShift.ReadOnly = true;
            // 
            // ColumnMissingHours
            // 
            this.ColumnMissingHours.HeaderText = "Missing Hours";
            this.ColumnMissingHours.Name = "ColumnMissingHours";
            this.ColumnMissingHours.ReadOnly = true;
            // 
            // labelReplacementEmployee
            // 
            this.labelReplacementEmployee.AutoSize = true;
            this.labelReplacementEmployee.Location = new System.Drawing.Point(12, 325);
            this.labelReplacementEmployee.Name = "labelReplacementEmployee";
            this.labelReplacementEmployee.Size = new System.Drawing.Size(113, 13);
            this.labelReplacementEmployee.TabIndex = 1;
            this.labelReplacementEmployee.Text = "Replacement Employee";
            // 
            // comboBoxReplacementEmployee
            // 
            this.comboBoxReplacementEmployee.FormattingEnabled = true;
            this.comboBoxReplacementEmployee.Location = new System.Drawing.Point(131, 322);
            this.comboBoxReplacementEmployee.Name = "comboBoxReplacementEmployee";
            this.comboBoxReplacementEmployee.Size = new System.Drawing.Size(200, 21);
            this.comboBoxReplacementEmployee.TabIndex = 2;
            // 
            // buttonAssignReplacement
            // 
            this.buttonAssignReplacement.Location = new System.Drawing.Point(337, 320);
            this.buttonAssignReplacement.Name = "buttonAssignReplacement";
            this.buttonAssignReplacement.Size = new System.Drawing.Size(124, 23);
            this.buttonAssignReplacement.TabIndex = 3;
            this.buttonAssignReplacement.Text = "Assign Replacement";
            this.buttonAssignReplacement.UseVisualStyleBackColor = true;
            //this.buttonAssignReplacement.Click += new System.EventHandler(this.buttonAssignReplacement_Click);
            // 
            // ShiftReplacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.buttonAssignReplacement);
            this.Controls.Add(this.comboBoxReplacementEmployee);
            this.Controls.Add(this.labelReplacementEmployee);
            this.Controls.Add(this.dataGridViewMissingShifts);
            this.Name = "ShiftReplacementForm";
            this.Text = "Shift Replacement";
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