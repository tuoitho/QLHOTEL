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
    }
}
