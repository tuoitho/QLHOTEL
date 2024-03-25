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
            // TODO: This line of code loads data into the 'qLHotelDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter.Fill(this.qLHotelDataSet.EMPLOYEES);
            // TODO: This line of code loads data into the 'qLHotelDataSet2.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter.Fill(this.qLHotelDataSet2.EMPLOYEES);
            dataGridView_nv.DataSource = BUS_Employee.DSNhanVien();
            //MessageBox.Show(BUS_Employee.DSNhanVien().Rows.Count.ToString());


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_nv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_nv_Click(object sender, EventArgs e)
        {
            //dislay data from datagridview to textbox
            txt_MaNV.Text = dataGridView_nv.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dataGridView_nv.CurrentRow.Cells[1].Value.ToString();
            datetimePicker_NgaySinh.Text = dataGridView_nv.CurrentRow.Cells[2].Value.ToString();
           
            txt_DiaChi.Text = dataGridView_nv.CurrentRow.Cells[3].Value.ToString();
            txt_SDT.Text = dataGridView_nv.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dataGridView_nv.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView_nv.CurrentRow.Cells[6].Value.ToString() == "Male")
            {
                rdmale.Checked = true;
            }
            else
            {
                rdfemale.Checked = true;
            }
            if (dataGridView_nv.CurrentRow.Cells[7].Value.ToString() == "1")
            {
                radioButton_ql.Checked = true;
            }
            else if (dataGridView_nv.CurrentRow.Cells[7].Value.ToString() == "3")
            {
                radioButton_lc.Checked = true;
            }
            else if (dataGridView_nv.CurrentRow.Cells[7].Value.ToString() == "2")
            {
                radioButton_tt.Checked = true;
            }
            txt_luongcoban.Text = dataGridView_nv.CurrentRow.Cells[8].Value.ToString();


        }
    }
}
