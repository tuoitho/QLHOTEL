using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_nhanvien = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_checkinout = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.button_khachhang = new System.Windows.Forms.Button();
            this.button_nv = new System.Windows.Forms.Button();
            this.button_hoadon = new System.Windows.Forms.Button();
            this.button_trangchu = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.panel_menu.Controls.Add(this.button2);
            this.panel_menu.Controls.Add(this.button1);
            this.panel_menu.Controls.Add(this.button_checkinout);
            this.panel_menu.Controls.Add(this.btn_dangxuat);
            this.panel_menu.Controls.Add(this.button_account);
            this.panel_menu.Controls.Add(this.button_khachhang);
            this.panel_menu.Controls.Add(this.button_nhanvien);
            this.panel_menu.Controls.Add(this.button_nv);
            this.panel_menu.Controls.Add(this.button_hoadon);
            this.panel_menu.Controls.Add(this.button_trangchu);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(225, 811);
            this.panel_menu.TabIndex = 0;
            // 
            // button_nhanvien
            // 
            this.button_nhanvien.FlatAppearance.BorderSize = 0;
            this.button_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nhanvien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_nhanvien.ForeColor = System.Drawing.Color.Transparent;
            this.button_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nhanvien.Location = new System.Drawing.Point(0, 307);
            this.button_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.button_nhanvien.Name = "button_nhanvien";
            this.button_nhanvien.Size = new System.Drawing.Size(225, 73);
            this.button_nhanvien.TabIndex = 4;
            this.button_nhanvien.Text = "Nhân Viên";
            this.button_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_nhanvien.UseVisualStyleBackColor = true;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(225, 92);
            this.panel_logo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.lblTiltle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Location = new System.Drawing.Point(225, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1001, 88);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.TabStop = true;
            // 
            // lblTiltle
            // 
            this.lblTiltle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.White;
            this.lblTiltle.Location = new System.Drawing.Point(344, 16);
            this.lblTiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(439, 55);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Home";
            this.lblTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(225, 88);
            this.panel_childForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(1001, 723);
            this.panel_childForm.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::GUI.Properties.Resources.scheduler;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 599);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 73);
            this.button2.TabIndex = 11;
            this.button2.Text = "Lịch làm việc";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = global::GUI.Properties.Resources.checkin;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 73);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ca làm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_checkinout
            // 
            this.button_checkinout.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_checkinout.FlatAppearance.BorderSize = 0;
            this.button_checkinout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkinout.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_checkinout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_checkinout.Image = global::GUI.Properties.Resources.checkin;
            this.button_checkinout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_checkinout.Location = new System.Drawing.Point(0, 453);
            this.button_checkinout.Margin = new System.Windows.Forms.Padding(2);
            this.button_checkinout.Name = "button_checkinout";
            this.button_checkinout.Size = new System.Drawing.Size(225, 73);
            this.button_checkinout.TabIndex = 9;
            this.button_checkinout.Text = "Check in/out";
            this.button_checkinout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_checkinout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_checkinout.UseVisualStyleBackColor = true;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_dangxuat.Image = global::GUI.Properties.Resources.dangxuat32px;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 745);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btn_dangxuat.Size = new System.Drawing.Size(225, 66);
            this.btn_dangxuat.TabIndex = 8;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            // 
            // button_account
            // 
            this.button_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_account.FlatAppearance.BorderSize = 0;
            this.button_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_account.Image = global::GUI.Properties.Resources.teamwork;
            this.button_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.Location = new System.Drawing.Point(0, 380);
            this.button_account.Margin = new System.Windows.Forms.Padding(2);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(225, 73);
            this.button_account.TabIndex = 7;
            this.button_account.Text = "Quản lý tài khoản";
            this.button_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_khachhang
            // 
            this.button_khachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_khachhang.FlatAppearance.BorderSize = 0;
            this.button_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_khachhang.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_khachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_khachhang.Image = global::GUI.Properties.Resources.customer;
            this.button_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_khachhang.Location = new System.Drawing.Point(0, 307);
            this.button_khachhang.Margin = new System.Windows.Forms.Padding(2);
            this.button_khachhang.Name = "button_khachhang";
            this.button_khachhang.Size = new System.Drawing.Size(225, 73);
            this.button_khachhang.TabIndex = 5;
            this.button_khachhang.Text = "Khách hàng";
            this.button_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_khachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_khachhang.UseVisualStyleBackColor = true;
            // 
            // button_nv
            // 
            this.button_nv.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_nv.FlatAppearance.BorderSize = 0;
            this.button_nv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nv.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_nv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_nv.Image = global::GUI.Properties.Resources.employee;
            this.button_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nv.Location = new System.Drawing.Point(0, 234);
            this.button_nv.Margin = new System.Windows.Forms.Padding(2);
            this.button_nv.Name = "button_nv";
            this.button_nv.Size = new System.Drawing.Size(225, 73);
            this.button_nv.TabIndex = 3;
            this.button_nv.Text = "Nhân viên";
            this.button_nv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_nv.UseVisualStyleBackColor = true;
            this.button_nv.Click += new System.EventHandler(this.button_nv_Click);
            // 
            // button_hoadon
            // 
            this.button_hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_hoadon.FlatAppearance.BorderSize = 0;
            this.button_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hoadon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_hoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_hoadon.Image = global::GUI.Properties.Resources.bill__1_;
            this.button_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hoadon.Location = new System.Drawing.Point(0, 161);
            this.button_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.button_hoadon.Name = "button_hoadon";
            this.button_hoadon.Size = new System.Drawing.Size(225, 73);
            this.button_hoadon.TabIndex = 2;
            this.button_hoadon.Text = "Hóa Đơn";
            this.button_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_hoadon.UseVisualStyleBackColor = true;
            // 
            // button_trangchu
            // 
            this.button_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_trangchu.FlatAppearance.BorderSize = 0;
            this.button_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trangchu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_trangchu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_trangchu.Image = global::GUI.Properties.Resources.list1;
            this.button_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trangchu.Location = new System.Drawing.Point(0, 92);
            this.button_trangchu.Margin = new System.Windows.Forms.Padding(2);
            this.button_trangchu.Name = "button_trangchu";
            this.button_trangchu.Size = new System.Drawing.Size(225, 69);
            this.button_trangchu.TabIndex = 1;
            this.button_trangchu.Text = "Trang chủ";
            this.button_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trangchu.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1226, 811);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panel_menu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_khachhang;
        private System.Windows.Forms.Button button_nhanvien;
        private System.Windows.Forms.Button button_nv;
        private System.Windows.Forms.Button button_hoadon;
        private System.Windows.Forms.Button button_trangchu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTiltle;
        private System.Windows.Forms.Panel panel_childForm;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button btn_dangxuat;
        private Button button_checkinout;
        private Panel panel_logo;
        private Button button2;
        private Button button1;
    }
}

