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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
            if (true)
            {
                FormMainMenu.EmployeeID = 1;
                // Đăng nhập thành công
                //MessageBox.Show("Đăng nhập thành công!");

                // Mở form chính

                FormMainMenu mainForm = new FormMainMenu();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
