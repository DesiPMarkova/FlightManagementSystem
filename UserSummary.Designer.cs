namespace InfoManagementSystem
{
    partial class UserSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSummary));
            this.hello = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.DataGridView();
            this.findflights = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.map = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hello.Location = new System.Drawing.Point(23, 21);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(380, 25);
            this.hello.TabIndex = 4;
            this.hello.Text = "Desi, here are your booked flights:";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logout.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Sienna;
            this.logout.Location = new System.Drawing.Point(457, 303);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(134, 64);
            this.logout.TabIndex = 17;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.register_Click);
            // 
            // summary
            // 
            this.summary.BackgroundColor = System.Drawing.Color.Sienna;
            this.summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summary.Location = new System.Drawing.Point(28, 94);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(682, 188);
            this.summary.TabIndex = 18;
            // 
            // findflights
            // 
            this.findflights.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.findflights.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findflights.ForeColor = System.Drawing.Color.Sienna;
            this.findflights.Location = new System.Drawing.Point(597, 303);
            this.findflights.Name = "findflights";
            this.findflights.Size = new System.Drawing.Size(134, 64);
            this.findflights.TabIndex = 19;
            this.findflights.Text = "Find Flights";
            this.findflights.UseVisualStyleBackColor = false;
            this.findflights.Click += new System.EventHandler(this.findflights_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 355);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.map.Location = new System.Drawing.Point(803, 27);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(90, 18);
            this.map.TabIndex = 21;
            this.map.Text = "Seats Map";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Click on a field to make changes to your current bookings";
            // 
            // UserSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(956, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.findflights);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.hello);
            this.Name = "UserSummary";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridView summary;
        private System.Windows.Forms.Button findflights;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label map;
        private System.Windows.Forms.Label label1;
    }
}