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
            this.dataGridView_checklist = new System.Windows.Forms.DataGridView();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_checklist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_checklist
            // 
            this.dataGridView_checklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_checklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_checklist.Location = new System.Drawing.Point(14, 15);
            this.dataGridView_checklist.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_checklist.Name = "dataGridView_checklist";
            this.dataGridView_checklist.RowHeadersWidth = 51;
            this.dataGridView_checklist.Size = new System.Drawing.Size(700, 308);
            this.dataGridView_checklist.TabIndex = 0;
            // 
            // CheckInButton
            // 
            this.CheckInButton.BackColor = System.Drawing.Color.Green;
            this.CheckInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckInButton.FlatAppearance.BorderSize = 0;
            this.CheckInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.CheckInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CheckInButton.ForeColor = System.Drawing.Color.White;
            this.CheckInButton.Location = new System.Drawing.Point(117, 345);
            this.CheckInButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(117, 37);
            this.CheckInButton.TabIndex = 1;
            this.CheckInButton.Text = "Check-in";
            this.CheckInButton.UseVisualStyleBackColor = false;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.Color.Red;
            this.CheckOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutButton.FlatAppearance.BorderSize = 0;
            this.CheckOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.CheckOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CheckOutButton.ForeColor = System.Drawing.Color.White;
            this.CheckOutButton.Location = new System.Drawing.Point(292, 345);
            this.CheckOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(117, 37);
            this.CheckOutButton.TabIndex = 2;
            this.CheckOutButton.Text = "Check-out";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(471, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "get(chi co quan li ms bam dc)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.dataGridView_checklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormCheckInOut";
            this.Text = "Check-in/Check-out";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_checklist)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView_checklist;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button button1;
    }
}