namespace GUI
{
    partial class FormKhachHang
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
            this.tabControl_khachhang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl_khachhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_khachhang
            // 
            this.tabControl_khachhang.Controls.Add(this.tabPage1);
            this.tabControl_khachhang.Controls.Add(this.tabPage2);
            this.tabControl_khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_khachhang.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_khachhang.Location = new System.Drawing.Point(0, 0);
            this.tabControl_khachhang.Name = "tabControl_khachhang";
            this.tabControl_khachhang.SelectedIndex = 0;
            this.tabControl_khachhang.Size = new System.Drawing.Size(800, 450);
            this.tabControl_khachhang.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_khachhang);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.tabControl_khachhang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_khachhang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}