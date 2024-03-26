namespace GUI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditSchedule = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrintSchedule = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxAssignShift = new System.Windows.Forms.GroupBox();
            this.buttonAssignShift = new System.Windows.Forms.Button();
            this.dateTimePickerShiftDate = new System.Windows.Forms.DateTimePicker();
            this.labelShiftDate = new System.Windows.Forms.Label();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.labelShift = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelEmployees = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelShifts = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.groupBoxEmployeeInfo.SuspendLayout();
            this.groupBoxAssignShift.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // ToolStrip
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddEmployee,
            this.toolStripButtonEditSchedule,
            this.toolStripButtonPrintSchedule});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";

            // DataGridView
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDepartment,
            this.ColumnShift,
            this.ColumnDate});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(544, 386);
            this.dataGridViewEmployees.TabIndex = 2;

            // GroupBox for Employee Info
            this.groupBoxEmployeeInfo.Controls.Add(this.buttonUpdate);
            this.groupBoxEmployeeInfo.Controls.Add(this.buttonAdd);
            this.groupBoxEmployeeInfo.Controls.Add(this.comboBoxDepartment);
            this.groupBoxEmployeeInfo.Controls.Add(this.labelDepartment);
            this.groupBoxEmployeeInfo.Controls.Add(this.textBoxName);
            this.groupBoxEmployeeInfo.Controls.Add(this.labelName);
            this.groupBoxEmployeeInfo.Location = new System.Drawing.Point(562, 52);
            this.groupBoxEmployeeInfo.Name = "groupBoxEmployeeInfo";
            this.groupBoxEmployeeInfo.Size = new System.Drawing.Size(226, 188);
            this.groupBoxEmployeeInfo.TabIndex = 3;
            this.groupBoxEmployeeInfo.TabStop = false;
            this.groupBoxEmployeeInfo.Text = "Employee Info";

            // GroupBox for Assign Shift
            this.groupBoxAssignShift.Controls.Add(this.buttonAssignShift);
            this.groupBoxAssignShift.Controls.Add(this.dateTimePickerShiftDate);
            this.groupBoxAssignShift.Controls.Add(this.labelShiftDate);
            this.groupBoxAssignShift.Controls.Add(this.comboBoxShift);
            this.groupBoxAssignShift.Controls.Add(this.labelShift);
            this.groupBoxAssignShift.Location = new System.Drawing.Point(562, 246);
            this.groupBoxAssignShift.Name = "groupBoxAssignShift";
            this.groupBoxAssignShift.Size = new System.Drawing.Size(226, 192);
            this.groupBoxAssignShift.TabIndex = 4;
            this.groupBoxAssignShift.TabStop = false;
            this.groupBoxAssignShift.Text = "Assign Shift";

            // StatusStrip
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelEmployees,
            this.toolStripStatusLabelShifts});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxAssignShift);
            this.Controls.Add(this.groupBoxEmployeeInfo);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Employee Shift Scheduler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.groupBoxEmployeeInfo.ResumeLayout(false);
            this.groupBoxEmployeeInfo.PerformLayout();
            this.groupBoxAssignShift.ResumeLayout(false);
            this.groupBoxAssignShift.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddEmployee;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditSchedule;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrintSchedule;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.GroupBox groupBoxEmployeeInfo;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxAssignShift;
        private System.Windows.Forms.Button buttonAssignShift;
        private System.Windows.Forms.DateTimePicker dateTimePickerShiftDate;
        private System.Windows.Forms.Label labelShiftDate;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEmployees;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShifts;

        #endregion
    }
    
}
