namespace Online_rezervacija_hotela_MAIN
{
    partial class Dodaj_Rezervacija
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
            this.DodajRezervacija = new System.Windows.Forms.Button();
            this.BrojGostijuTB = new System.Windows.Forms.TextBox();
            this.BrojRezervacijeTB = new System.Windows.Forms.TextBox();
            this.GostRezervacija = new System.Windows.Forms.Label();
            this.CheckInRezervacija = new System.Windows.Forms.Label();
            this.CheckOutRezervacija = new System.Windows.Forms.Label();
            this.BrojGostijuRezervacija = new System.Windows.Forms.Label();
            this.BrojRezervacijeRezervacija = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkIn = new System.Windows.Forms.DateTimePicker();
            this.checkOut = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DodajRezervacija
            // 
            this.DodajRezervacija.Location = new System.Drawing.Point(571, 225);
            this.DodajRezervacija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajRezervacija.Name = "DodajRezervacija";
            this.DodajRezervacija.Size = new System.Drawing.Size(197, 70);
            this.DodajRezervacija.TabIndex = 2;
            this.DodajRezervacija.Text = "Dodaj";
            this.DodajRezervacija.UseVisualStyleBackColor = true;
            this.DodajRezervacija.Click += new System.EventHandler(this.DodajRezervacija_Click);
            // 
            // BrojGostijuTB
            // 
            this.BrojGostijuTB.Location = new System.Drawing.Point(204, 326);
            this.BrojGostijuTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrojGostijuTB.Name = "BrojGostijuTB";
            this.BrojGostijuTB.Size = new System.Drawing.Size(196, 22);
            this.BrojGostijuTB.TabIndex = 6;
            // 
            // BrojRezervacijeTB
            // 
            this.BrojRezervacijeTB.Location = new System.Drawing.Point(204, 389);
            this.BrojRezervacijeTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrojRezervacijeTB.Name = "BrojRezervacijeTB";
            this.BrojRezervacijeTB.Size = new System.Drawing.Size(196, 22);
            this.BrojRezervacijeTB.TabIndex = 7;
            // 
            // GostRezervacija
            // 
            this.GostRezervacija.AutoSize = true;
            this.GostRezervacija.Location = new System.Drawing.Point(100, 119);
            this.GostRezervacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GostRezervacija.Name = "GostRezervacija";
            this.GostRezervacija.Size = new System.Drawing.Size(35, 16);
            this.GostRezervacija.TabIndex = 9;
            this.GostRezervacija.Text = "Gost";
            // 
            // CheckInRezervacija
            // 
            this.CheckInRezervacija.AutoSize = true;
            this.CheckInRezervacija.Location = new System.Drawing.Point(84, 218);
            this.CheckInRezervacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckInRezervacija.Name = "CheckInRezervacija";
            this.CheckInRezervacija.Size = new System.Drawing.Size(58, 16);
            this.CheckInRezervacija.TabIndex = 10;
            this.CheckInRezervacija.Text = "Check In";
            // 
            // CheckOutRezervacija
            // 
            this.CheckOutRezervacija.AutoSize = true;
            this.CheckOutRezervacija.Location = new System.Drawing.Point(84, 274);
            this.CheckOutRezervacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckOutRezervacija.Name = "CheckOutRezervacija";
            this.CheckOutRezervacija.Size = new System.Drawing.Size(68, 16);
            this.CheckOutRezervacija.TabIndex = 11;
            this.CheckOutRezervacija.Text = "Check Out";
            // 
            // BrojGostijuRezervacija
            // 
            this.BrojGostijuRezervacija.AutoSize = true;
            this.BrojGostijuRezervacija.Location = new System.Drawing.Point(84, 335);
            this.BrojGostijuRezervacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrojGostijuRezervacija.Name = "BrojGostijuRezervacija";
            this.BrojGostijuRezervacija.Size = new System.Drawing.Size(75, 16);
            this.BrojGostijuRezervacija.TabIndex = 12;
            this.BrojGostijuRezervacija.Text = "Broj Gostiju";
            // 
            // BrojRezervacijeRezervacija
            // 
            this.BrojRezervacijeRezervacija.AutoSize = true;
            this.BrojRezervacijeRezervacija.Location = new System.Drawing.Point(84, 389);
            this.BrojRezervacijeRezervacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrojRezervacijeRezervacija.Name = "BrojRezervacijeRezervacija";
            this.BrojRezervacijeRezervacija.Size = new System.Drawing.Size(106, 16);
            this.BrojRezervacijeRezervacija.TabIndex = 13;
            this.BrojRezervacijeRezervacija.Text = "Broj Rezervacije";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(204, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 100);
            this.listBox1.TabIndex = 14;
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(204, 218);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(200, 22);
            this.checkIn.TabIndex = 15;
            // 
            // checkOut
            // 
            this.checkOut.Location = new System.Drawing.Point(204, 269);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(200, 22);
            this.checkOut.TabIndex = 16;
            // 
            // Dodaj_Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BrojRezervacijeRezervacija);
            this.Controls.Add(this.BrojGostijuRezervacija);
            this.Controls.Add(this.CheckOutRezervacija);
            this.Controls.Add(this.CheckInRezervacija);
            this.Controls.Add(this.GostRezervacija);
            this.Controls.Add(this.BrojRezervacijeTB);
            this.Controls.Add(this.BrojGostijuTB);
            this.Controls.Add(this.DodajRezervacija);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dodaj_Rezervacija";
            this.Text = "Dodaj_Rezervacija";
            this.Load += new System.EventHandler(this.Dodaj_Rezervacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajRezervacija;
        private System.Windows.Forms.TextBox BrojGostijuTB;
        private System.Windows.Forms.TextBox BrojRezervacijeTB;
        private System.Windows.Forms.Label GostRezervacija;
        private System.Windows.Forms.Label CheckInRezervacija;
        private System.Windows.Forms.Label CheckOutRezervacija;
        private System.Windows.Forms.Label BrojGostijuRezervacija;
        private System.Windows.Forms.Label BrojRezervacijeRezervacija;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker checkIn;
        private System.Windows.Forms.DateTimePicker checkOut;
    }
}