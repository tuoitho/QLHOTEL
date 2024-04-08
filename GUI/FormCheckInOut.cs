using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCheckInOut : Form
    {
        public FormCheckInOut()
        {
            InitializeComponent();
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            //check if ko co ca lam viec cua nhan vien


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_checklist.DataSource = BUS.BUS_Checkin.GetAllCheckins();
        }
    }
}
