using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class FormNhanVien: Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_lc = new System.Windows.Forms.RadioButton();
            this.radioButton_tt = new System.Windows.Forms.RadioButton();
            this.radioButton_ql = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.datetimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new GUI.HotelManagementDataSet();
            this.employeesTableAdapter = new GUI.HotelManagementDataSetTableAdapters.EmployeesTableAdapter();
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.datetimePicker_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(925, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_lc);
            this.groupBox2.Controls.Add(this.radioButton_tt);
            this.groupBox2.Controls.Add(this.radioButton_ql);
            this.groupBox2.Location = new System.Drawing.Point(531, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(329, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Nhân Viên";
            // 
            // radioButton_lc
            // 
            this.radioButton_lc.AutoSize = true;
            this.radioButton_lc.Location = new System.Drawing.Point(213, 35);
            this.radioButton_lc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_lc.Name = "radioButton_lc";
            this.radioButton_lc.Size = new System.Drawing.Size(101, 27);
            this.radioButton_lc.TabIndex = 2;
            this.radioButton_lc.TabStop = true;
            this.radioButton_lc.Text = "Lao công";
            this.radioButton_lc.UseVisualStyleBackColor = true;
            // 
            // radioButton_tt
            // 
            this.radioButton_tt.AutoSize = true;
            this.radioButton_tt.Location = new System.Drawing.Point(112, 35);
            this.radioButton_tt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_tt.Name = "radioButton_tt";
            this.radioButton_tt.Size = new System.Drawing.Size(93, 27);
            this.radioButton_tt.TabIndex = 1;
            this.radioButton_tt.TabStop = true;
            this.radioButton_tt.Text = "Tiếp tân";
            this.radioButton_tt.UseVisualStyleBackColor = true;
            // 
            // radioButton_ql
            // 
            this.radioButton_ql.AutoSize = true;
            this.radioButton_ql.Location = new System.Drawing.Point(16, 35);
            this.radioButton_ql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_ql.Name = "radioButton_ql";
            this.radioButton_ql.Size = new System.Drawing.Size(90, 27);
            this.radioButton_ql.TabIndex = 0;
            this.radioButton_ql.TabStop = true;
            this.radioButton_ql.Text = "Quản lý";
            this.radioButton_ql.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdfemale);
            this.groupBox4.Controls.Add(this.rdmale);
            this.groupBox4.Location = new System.Drawing.Point(531, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(279, 83);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới Tính";
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Location = new System.Drawing.Point(131, 18);
            this.rdfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(82, 27);
            this.rdfemale.TabIndex = 1;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "female";
            this.rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Location = new System.Drawing.Point(16, 18);
            this.rdmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(68, 27);
            this.rdmale.TabIndex = 0;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "male";
            this.rdmale.UseVisualStyleBackColor = true;
            // 
            // datetimePicker_NgaySinh
            // 
            this.datetimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgaySinh.Location = new System.Drawing.Point(140, 113);
            this.datetimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.datetimePicker_NgaySinh.Name = "datetimePicker_NgaySinh";
            this.datetimePicker_NgaySinh.Size = new System.Drawing.Size(175, 30);
            this.datetimePicker_NgaySinh.TabIndex = 15;
            this.datetimePicker_NgaySinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Location = new System.Drawing.Point(140, 157);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(294, 30);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(140, 204);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(294, 30);
            this.txt_SDT.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Location = new System.Drawing.Point(140, 77);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(294, 30);
            this.txt_HoTen.TabIndex = 9;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Location = new System.Drawing.Point(140, 39);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(294, 30);
            this.txt_MaNV.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 570);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(925, 114);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::GUI.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(317, 38);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Size = new System.Drawing.Size(114, 46);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::GUI.Properties.Resources.cross;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(626, 38);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4);
            this.btn_delete.Size = new System.Drawing.Size(113, 46);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::GUI.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(472, 38);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(4);
            this.btn_modify.Size = new System.Drawing.Size(113, 46);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::GUI.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(163, 38);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(4);
            this.btn_add.Size = new System.Drawing.Size(113, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Employees";
            this.bindingSource1.DataSource = this.hotelManagementDataSet;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.AutoGenerateColumns = false;
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView_employee.DataSource = this.bindingSource1;
            this.dataGridView_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_employee.Location = new System.Drawing.Point(0, 254);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.RowHeadersWidth = 51;
            this.dataGridView_employee.RowTemplate.Height = 26;
            this.dataGridView_employee.Size = new System.Drawing.Size(925, 316);
            this.dataGridView_employee.TabIndex = 6;
            this.dataGridView_employee.Click += new System.EventHandler(this.dataGridView_employee_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoB";
            this.dataGridViewTextBoxColumn4.HeaderText = "DoB";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PositionID";
            this.dataGridViewTextBoxColumn7.HeaderText = "PositionID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn8.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 684);
            this.Controls.Add(this.dataGridView_employee);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.ResumeLayout(false);

        }
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton rdfemale;
        private RadioButton rdmale;
        private DateTimePicker datetimePicker_NgaySinh;
        private TextBox txt_DiaChi;
        private TextBox txt_SDT;
        private TextBox txt_HoTen;
        private TextBox txt_MaNV;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioButton_lc;
        private RadioButton radioButton_tt;
        private RadioButton radioButton_ql;
        private GroupBox groupBox3;
        private Button btnLoad;
        private Button btn_delete;
        private Button btn_modify;
        private Button btn_add;
        #endregion
        private BindingSource employeesBindingSource;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private HotelManagementDataSet hotelManagementDataSet;
        private BindingSource bindingSource1;
        private HotelManagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DataGridViewTextBoxColumn Name;
        private DataGridView dataGridView_employee;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}