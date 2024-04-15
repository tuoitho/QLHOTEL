namespace GUI
{
    partial class FormPhong
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
            this.tabControl_phong = new System.Windows.Forms.TabControl();
            this.tabPage_qlphong = new System.Windows.Forms.TabPage();
            this.tabPage_thuephong = new System.Windows.Forms.TabPage();
            this.tabPage_traphong = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_phong.SuspendLayout();
            this.tabPage_qlphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_phong
            // 
            this.tabControl_phong.Controls.Add(this.tabPage_qlphong);
            this.tabControl_phong.Controls.Add(this.tabPage_thuephong);
            this.tabControl_phong.Controls.Add(this.tabPage_traphong);
            this.tabControl_phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_phong.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_phong.Location = new System.Drawing.Point(0, 0);
            this.tabControl_phong.Name = "tabControl_phong";
            this.tabControl_phong.SelectedIndex = 0;
            this.tabControl_phong.Size = new System.Drawing.Size(1140, 694);
            this.tabControl_phong.TabIndex = 0;
            // 
            // tabPage_qlphong
            // 
            this.tabPage_qlphong.Controls.Add(this.panel1);
            this.tabPage_qlphong.Location = new System.Drawing.Point(4, 31);
            this.tabPage_qlphong.Name = "tabPage_qlphong";
            this.tabPage_qlphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_qlphong.Size = new System.Drawing.Size(1132, 659);
            this.tabPage_qlphong.TabIndex = 0;
            this.tabPage_qlphong.Text = "Quản lý phòng";
            this.tabPage_qlphong.UseVisualStyleBackColor = true;
            this.tabPage_qlphong.Click += new System.EventHandler(this.tabPage_qlphong_Click);
            // 
            // tabPage_thuephong
            // 
            this.tabPage_thuephong.Location = new System.Drawing.Point(4, 31);
            this.tabPage_thuephong.Name = "tabPage_thuephong";
            this.tabPage_thuephong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_thuephong.Size = new System.Drawing.Size(1132, 659);
            this.tabPage_thuephong.TabIndex = 1;
            this.tabPage_thuephong.Text = "Thuê phòng";
            this.tabPage_thuephong.UseVisualStyleBackColor = true;
            // 
            // tabPage_traphong
            // 
            this.tabPage_traphong.Location = new System.Drawing.Point(4, 31);
            this.tabPage_traphong.Name = "tabPage_traphong";
            this.tabPage_traphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_traphong.Size = new System.Drawing.Size(1132, 659);
            this.tabPage_traphong.TabIndex = 2;
            this.tabPage_traphong.Text = "Trả phòng";
            this.tabPage_traphong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(98, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 89);
            this.panel1.TabIndex = 0;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 694);
            this.Controls.Add(this.tabControl_phong);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.tabControl_phong.ResumeLayout(false);
            this.tabPage_qlphong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_phong;
        private System.Windows.Forms.TabPage tabPage_qlphong;
        private System.Windows.Forms.TabPage tabPage_thuephong;
        private System.Windows.Forms.TabPage tabPage_traphong;
        private System.Windows.Forms.Panel panel1;
    }
}