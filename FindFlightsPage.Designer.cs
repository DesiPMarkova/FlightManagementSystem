namespace InfoManagementSystem
{
    partial class FindFlightsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindFlightsPage));
            this.goBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.fromCalendar = new System.Windows.Forms.MonthCalendar();
            this.depart = new System.Windows.Forms.Label();
            this.toCalendar = new System.Windows.Forms.MonthCalendar();
            this.returning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.airline = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.travellers = new System.Windows.Forms.TextBox();
            this.welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.Location = new System.Drawing.Point(12, 446);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "Go Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 487);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(205, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.from.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(31, 87);
            this.from.Multiline = true;
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(146, 33);
            this.from.TabIndex = 2;
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.to.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(205, 87);
            this.to.Multiline = true;
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(146, 33);
            this.to.TabIndex = 3;
            // 
            // fromCalendar
            // 
            this.fromCalendar.Location = new System.Drawing.Point(31, 237);
            this.fromCalendar.Name = "fromCalendar";
            this.fromCalendar.TabIndex = 5;
            // 
            // depart
            // 
            this.depart.AutoSize = true;
            this.depart.BackColor = System.Drawing.Color.Sienna;
            this.depart.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depart.ForeColor = System.Drawing.Color.Snow;
            this.depart.Location = new System.Drawing.Point(31, 208);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(66, 20);
            this.depart.TabIndex = 6;
            this.depart.Text = "Depart";
            // 
            // toCalendar
            // 
            this.toCalendar.Location = new System.Drawing.Point(299, 237);
            this.toCalendar.Name = "toCalendar";
            this.toCalendar.TabIndex = 7;
            // 
            // returning
            // 
            this.returning.AutoSize = true;
            this.returning.BackColor = System.Drawing.Color.Sienna;
            this.returning.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returning.ForeColor = System.Drawing.Color.Snow;
            this.returning.Location = new System.Drawing.Point(299, 208);
            this.returning.Name = "returning";
            this.returning.Size = new System.Drawing.Size(67, 20);
            this.returning.TabIndex = 8;
            this.returning.Text = "Return";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Sienna;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(386, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Airline";
            // 
            // airline
            // 
            this.airline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.airline.FormattingEnabled = true;
            this.airline.Items.AddRange(new object[] {
            "No Preference",
            "Bulgaria Air",
            "American Airlines",
            "Delta Air Lines",
            "United Airlines",
            "Southwest Airlines",
            "Emirates",
            "Lufthansa",
            "British Airways",
            "Air France",
            "Qantas Airways",
            "Cathay Pacific Airways",
            "Singapore Airlines",
            "Japan Airlines",
            "Qatar Airways",
            "Turkish Airlines",
            "Air Canada",
            "ANA (All Nippon Airways)",
            "Etihad Airways",
            "Korean Air",
            "Virgin Atlantic",
            "KLM Royal Dutch Airlines"});
            this.airline.Location = new System.Drawing.Point(386, 87);
            this.airline.Name = "airline";
            this.airline.Size = new System.Drawing.Size(121, 21);
            this.airline.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(438, 411);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(192, 58);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search Flights";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Sienna;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(32, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Flight Type";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "No Preference",
            "Morning",
            "Noon",
            "Evening"});
            this.type.Location = new System.Drawing.Point(149, 150);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Sienna;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(293, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of Travellers";
            // 
            // travellers
            // 
            this.travellers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.travellers.Location = new System.Drawing.Point(492, 150);
            this.travellers.Multiline = true;
            this.travellers.Name = "travellers";
            this.travellers.Size = new System.Drawing.Size(47, 21);
            this.travellers.TabIndex = 16;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Sienna;
            this.welcome.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Snow;
            this.welcome.Location = new System.Drawing.Point(21, 20);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(94, 20);
            this.welcome.TabIndex = 17;
            this.welcome.Text = "Welcome ";
            // 
            // FindFlightsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.travellers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.airline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returning);
            this.Controls.Add(this.toCalendar);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.fromCalendar);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Name = "FindFlightsPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.MonthCalendar fromCalendar;
        private System.Windows.Forms.Label depart;
        private System.Windows.Forms.MonthCalendar toCalendar;
        private System.Windows.Forms.Label returning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox airline;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox travellers;
        private System.Windows.Forms.Label welcome;
    }
}