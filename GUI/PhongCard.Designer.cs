namespace GUI
{
    partial class PhongCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_tenphong = new System.Windows.Forms.Label();
            this.label_mota = new System.Windows.Forms.Label();
            this.label_gia = new System.Windows.Forms.Label();
            this.pictureBox_phong = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_phong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_tenphong
            // 
            this.label_tenphong.Location = new System.Drawing.Point(136, 13);
            this.label_tenphong.Name = "label_tenphong";
            this.label_tenphong.Size = new System.Drawing.Size(82, 25);
            this.label_tenphong.TabIndex = 1;
            this.label_tenphong.Text = "label_tenphong";
            // 
            // label_mota
            // 
            this.label_mota.Location = new System.Drawing.Point(22, 51);
            this.label_mota.Name = "label_mota";
            this.label_mota.Size = new System.Drawing.Size(317, 56);
            this.label_mota.TabIndex = 1;
            this.label_mota.Text = "label_mota";
            // 
            // label_gia
            // 
            this.label_gia.Location = new System.Drawing.Point(58, 10);
            this.label_gia.Name = "label_gia";
            this.label_gia.Size = new System.Drawing.Size(251, 40);
            this.label_gia.TabIndex = 1;
            this.label_gia.Text = "label_gia";
            // 
            // pictureBox_phong
            // 
            this.pictureBox_phong.Location = new System.Drawing.Point(16, 14);
            this.pictureBox_phong.Name = "pictureBox_phong";
            this.pictureBox_phong.Size = new System.Drawing.Size(318, 157);
            this.pictureBox_phong.TabIndex = 0;
            this.pictureBox_phong.TabStop = false;
            this.pictureBox_phong.Click += new System.EventHandler(this.pictureBox_phong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_phong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 181);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_mota);
            this.panel2.Controls.Add(this.label_tenphong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 182);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_gia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 62);
            this.panel4.TabIndex = 5;
            // 
            // PhongCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhongCard";
            this.Size = new System.Drawing.Size(354, 363);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_phong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_phong;
        private System.Windows.Forms.Label label_tenphong;
        private System.Windows.Forms.Label label_mota;
        private System.Windows.Forms.Label label_gia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}
