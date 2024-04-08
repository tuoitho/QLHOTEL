
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class FormMainMenu : Form
    {
        public static int EmployeeID;
        public static int PositionID;

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
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, button_nv.Width / 2, button_nv.Height / 2, 280, 190); // Bo tròn góc trên trái
            path.AddArc(button_nv.Width / 2, 0, button_nv.Width / 2, button_nv.Height / 2, 90, 90); // Bo tròn góc trên phải
            path.AddArc(button_nv.Width / 2, button_nv.Height / 2, button_nv.Width / 2, button_nv.Height / 2, 0, 90); // Bo tròn góc dưới phải
            path.AddArc(0, button_nv.Height / 2, button_nv.Width / 2, button_nv.Height / 2, 270, 90); // Bo tròn góc dưới trái
            using (Graphics g = button_nv.CreateGraphics())
            {
                g.FillPath(Brushes.Blue, path);
            }
        }
        public FormMainMenu(String username, String password, Boolean fsysRole)
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {

            Color color = Color.FromArgb(0, 108, 225);
            if (btnSender != null)
            {

                if (currentButton != (RoundedButton)btnSender)
                {

                    currentButton = (RoundedButton)btnSender;
                    if (currentButton == button_trangchu)
                    {
                        currentButton.Image = global::GUI.Properties.Resources.hometrang;
                    }
                    if (currentButton == button_khachhang)
                    {
                        currentButton.Image = global::GUI.Properties.Resources.khachhangtrang;
                    }
                    if (currentButton == button_account)
                    {
                        currentButton.Image = global::GUI.Properties.Resources.usertrang;
                    }
                    if (currentButton == button_nv)
                    {
                        currentButton.Image = global::GUI.Properties.Resources.employeetrang;
                    }
                    if (currentButton == button_checkinout)
                    {
                        currentButton.Image = global::GUI.Properties.Resources.location__1_;
                    }
                    DisableButton();
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    panel_logo.BackColor = Color.Transparent;
                }
            }
        }
        private void DisableButton()
        {
            this.button_lich.Image = global::GUI.Properties.Resources.scheduler;
            this.button_ca.Image = global::GUI.Properties.Resources.checkin;
            this.button_checkinout.Image = global::GUI.Properties.Resources.location;
            this.button_account.Image = global::GUI.Properties.Resources.userden;
            this.button_khachhang.Image = global::GUI.Properties.Resources.khachhangden;
            this.button_trangchu.Image = global::GUI.Properties.Resources.homeden;
            this.button_nv.Image = global::GUI.Properties.Resources.employeeden;
            if (currentButton == button_trangchu)
            {
                currentButton.Image = global::GUI.Properties.Resources.hometrang;
            }
            if (currentButton == button_khachhang)
            {
                currentButton.Image = global::GUI.Properties.Resources.khachhangtrang;
            }
            if (currentButton == button_account)
            {
                currentButton.Image = global::GUI.Properties.Resources.usertrang;
            }
            if (currentButton == button_nv)
            {
                currentButton.Image = global::GUI.Properties.Resources.employeetrang;
            }
            if (currentButton == button_checkinout)
            {
                currentButton.Image = global::GUI.Properties.Resources.location__1_;
            }

            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(RoundedButton))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private void panel_childForm_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isCollapsed = false;
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                panel_menu.Size = panel_menu.MinimumSize;
                foreach (Control bt in panel_menu.Controls)
                {
                    if (bt.GetType() == typeof(RoundedButton))
                    {
                        bt.Text = "";
                    }
                }
                isCollapsed = true;
            }
            else
            {
                panel_menu.Size = panel_menu.MaximumSize;
                isCollapsed = false;
                this.button_lich.Text = "  Lịch làm việc";
                this.button_ca.Text = "  Ca làm";
                this.button_checkinout.Text = "  Check in/out";
                this.btn_dangxuat.Text = "Đăng xuất";
                this.button_account.Text = "  Quản lý tài khoản";
                this.button_khachhang.Text = "  Khách hàng";
                this.button_nv.Text = "  Nhân viên";
                this.button_trangchu.Text = "  Trang chủ";
            }
            
        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                panel_menu.Size = panel_menu.MinimumSize;
                foreach (Control bt in panel_menu.Controls)
                {
                    if (bt.GetType() == typeof(RoundedButton))
                    {
                        bt.Text = "";
                    }
                }
                isCollapsed = true;
            }
            else
            {
                panel_menu.Size = panel_menu.MaximumSize;
                isCollapsed = false;
                this.button_lich.Text = "  Lịch làm việc";
                this.button_ca.Text = "  Ca làm";
                this.button_checkinout.Text = "  Check in/out";
                this.btn_dangxuat.Text = "Đăng xuất";
                this.button_account.Text = "  Quản lý tài khoản";
                this.button_khachhang.Text = "  Khách hàng";
                this.button_nv.Text = "  Nhân viên";
                this.button_trangchu.Text = "  Trang chủ";
                this.button_bill.Text = "  Hóa đơn";
                this.button_phong.Text = "  Phòng";
                this.button_dichvu.Text = "  Dịch vụ";
            }
        }

        private void button_phong_Click(object sender, EventArgs e)
        {
            FormPhong formPhong = new FormPhong();
            OpenChildForm(formPhong, sender);
            lblTiltle.Text = "Phòng";
        }

        private void button_khachhang_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            OpenChildForm(formKhachHang, sender);
            lblTiltle.Text = "Khách hàng";
        }

        private void button_bill_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            OpenChildForm(formHoaDon, sender);
            lblTiltle.Text = "Hóa đơn";
        }
    }
}

