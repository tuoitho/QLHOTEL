
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class FormMainMenu : Form
    {

        private Button currentButton;
        private Random random;
        private Form activeForm;
        private Boolean sysRole = false;

        public event EventHandler Logout;
        public Boolean isExit = true;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
        }
        public FormMainMenu(String username, String password, Boolean fsysRole)
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            Color color = Color.FromArgb(4, 72, 98);
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    panel_logo.BackColor = Color.Transparent;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(82, 108, 152);
                    previousBtn.ForeColor = Color.FromArgb(224, 224, 224);
                    previousBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_childForm.Controls.Add(childForm);
            this.panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTiltle.Text = childForm.Text;

        }
        private void button_danhmuc_Click(object sender, EventArgs e)
        {
            //Forms.DanhMucThietBi.FormDanhMuc fDanhMuc = new Forms.DanhMucThietBi.FormDanhMuc();
            //fDanhMuc.setSysRole(sysRole);
            //OpenChildForm(fDanhMuc, sender);
        }



        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            if (this.sysRole == false)
            {
                //button_nhanvien.Visible = false;
                //button_account.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            //Logout(this, new EventArgs());
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (isExit) { 
            //    if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Lưu ý", MessageBoxButtons.YesNo) != DialogResult.Yes)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_account_Click(object sender, EventArgs e)
        {
            FormAccount formAccount = new FormAccount();
            OpenChildForm(formAccount, sender);
            lblTiltle.Text = "Quản lý tài khoản";
        }

        private void button_doanhthu_Click(object sender, EventArgs e)
        {

        }

        private void button_nv_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            OpenChildForm(formNhanVien, sender);
            lblTiltle.Text = "Nhân viên";
        }
    }
}

