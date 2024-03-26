namespace GUI
{
    partial class FormCheckInOut
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
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // Check-in Button
            this.CheckInButton.Location = new System.Drawing.Point(100, 280);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(100, 30);
            this.CheckInButton.TabIndex = 1;
            this.CheckInButton.Text = "Check-in";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.BackColor = System.Drawing.Color.Green;
            this.CheckInButton.ForeColor = System.Drawing.Color.White;
            this.CheckInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CheckInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckInButton.FlatAppearance.BorderSize = 0;
            this.CheckInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            //this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);

            // Check-out Button
            this.CheckOutButton.Location = new System.Drawing.Point(250, 280);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(100, 30);
            this.CheckOutButton.TabIndex = 2;
            this.CheckOutButton.Text = "Check-out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.BackColor = System.Drawing.Color.Red;
            this.CheckOutButton.ForeColor = System.Drawing.Color.White;
            this.CheckOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CheckOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutButton.FlatAppearance.BorderSize = 0;
            this.CheckOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            //this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);

            // CheckInOutForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 338);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckInOutForm";
            this.Text = "Check-in/Check-out";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CheckOutButton;
    }
}