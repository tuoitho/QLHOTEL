using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
     
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.hotelManagementDataSet.Employees);
            // TODO: This line of code loads data into the 'hotelManagementDataSet1.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.hotelManagementDataSet1.Employees);
            dataGridView_employee.DataSource = BUS_Employee.DSNhanVien();
        }


        private void dataGridView_employee_Click(object sender, EventArgs e)
        {
            //display data from datagridview to textbox
            txt_MaNV.Text = dataGridView_employee.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dataGridView_employee.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView_employee.CurrentRow.Cells[2].Value.ToString() == "Male")
            {
                rdmale.Checked = true;
            }
            else
            {
                rdfemale.Checked = true;
            }
            datetimePicker_NgaySinh.Text = dataGridView_employee.CurrentRow.Cells[3].Value.ToString();

            txt_DiaChi.Text = dataGridView_employee.CurrentRow.Cells[4].Value.ToString();
            txt_SDT.Text = dataGridView_employee.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView_employee.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                radioButton_ql.Checked = true;
            }
            else if (dataGridView_employee.CurrentRow.Cells[6].Value.ToString() == "2")
            {
                radioButton_tt.Checked = true;
            }
            else
            {
                radioButton_lc.Checked = false;
            }
 
        }
        bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Nhập mã nhân viên");
                txt_MaNV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                MessageBox.Show("Nhập họ tên nhân viên");
                txt_HoTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Nhập địa chỉ nhân viên");
                txt_DiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_SDT.Text))
            {
                MessageBox.Show("Nhập số điện thoại nhân viên");
                txt_SDT.Focus();
                return false;
            }
            return true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            DTO_Employee dtoEmployee = new DTO_Employee(Int32.Parse(txt_MaNV.Text), txt_HoTen.Text, rdmale.Checked ? "Male":"Female", datetimePicker_NgaySinh.Value, txt_DiaChi.Text, txt_SDT.Text, radioButton_ql.Checked ? 1 : radioButton_tt.Checked ? 2 : 3);
            if (!checkData())
            {
                return;
            }
            if (BUS_Employee.CheckExist(dtoEmployee.MaNV))
            {
                return;
            }
            if (BUS_Employee.insertNhanVien(dtoEmployee))
            {
                
                MessageBox.Show("Thêm nhân viên thành công");
                dataGridView_employee.DataSource = BUS_Employee.DSNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
    }
}
