using System.Windows.Forms;
using System;

namespace GUI
{
    partial class FormKiemTraGioLam
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
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.ColumnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCheckAttendance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(51, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AllowUserToAddRows = false;
            this.dataGridViewAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmployeeName,
            this.ColumnDepartment,
            this.ColumnShift,
            this.ColumnCheckIn,
            this.ColumnCheckOut});
            this.dataGridViewAttendance.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewAttendance.TabIndex = 2;
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
            // ColumnCheckIn
            // 
            this.ColumnCheckIn.HeaderText = "Check In";
            this.ColumnCheckIn.Name = "ColumnCheckIn";
            // 
            // ColumnCheckOut
            // 
            this.ColumnCheckOut.HeaderText = "Check Out";
            this.ColumnCheckOut.Name = "ColumnCheckOut";
            // 
            // buttonCheckAttendance
            // 
            this.buttonCheckAttendance.Location = new System.Drawing.Point(257, 10);
            this.buttonCheckAttendance.Name = "buttonCheckAttendance";
            this.buttonCheckAttendance.Size = new System.Drawing.Size(129, 23);
            this.buttonCheckAttendance.TabIndex = 3;
            this.buttonCheckAttendance.Text = "Check Attendance";
            this.buttonCheckAttendance.UseVisualStyleBackColor = true;
            //this.buttonCheckAttendance.Click += new System.EventHandler(this.buttonCheckAttendance_Click);
            // 
            // CheckAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.buttonCheckAttendance);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Name = "CheckAttendanceForm";
            this.Text = "Check Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckOut;
        private System.Windows.Forms.Button buttonCheckAttendance;
    }
}
