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
            this.CheckInTB = new System.Windows.Forms.TextBox();
            this.CheckOutTB = new System.Windows.Forms.TextBox();
            this.BrojGostijuTB = new System.Windows.Forms.TextBox();
            this.BrojRezervacijeTB = new System.Windows.Forms.TextBox();
            this.GostRezervacija = new System.Windows.Forms.Label();
            this.CheckInRezervacija = new System.Windows.Forms.Label();
            this.CheckOutRezervacija = new System.Windows.Forms.Label();
            this.BrojGostijuRezervacija = new System.Windows.Forms.Label();
            this.BrojRezervacijeRezervacija = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DodajRezervacija
            // 
            this.DodajRezervacija.Location = new System.Drawing.Point(428, 183);
            this.DodajRezervacija.Name = "DodajRezervacija";
            this.DodajRezervacija.Size = new System.Drawing.Size(148, 57);
            this.DodajRezervacija.TabIndex = 2;
            this.DodajRezervacija.Text = "Dodaj";
            this.DodajRezervacija.UseVisualStyleBackColor = true;
            this.DodajRezervacija.Click += new System.EventHandler(this.DodajRezervacija_Click);
            // 
            // CheckInTB
            // 
            this.CheckInTB.Location = new System.Drawing.Point(153, 170);
            this.CheckInTB.Name = "CheckInTB";
            this.CheckInTB.Size = new System.Drawing.Size(148, 20);
            this.CheckInTB.TabIndex = 4;
            // 
            // CheckOutTB
            // 
            this.CheckOutTB.Location = new System.Drawing.Point(153, 220);
            this.CheckOutTB.Name = "CheckOutTB";
            this.CheckOutTB.Size = new System.Drawing.Size(148, 20);
            this.CheckOutTB.TabIndex = 5;
            // 
            // BrojGostijuTB
            // 
            this.BrojGostijuTB.Location = new System.Drawing.Point(153, 265);
            this.BrojGostijuTB.Name = "BrojGostijuTB";
            this.BrojGostijuTB.Size = new System.Drawing.Size(148, 20);
            this.BrojGostijuTB.TabIndex = 6;
            // 
            // BrojRezervacijeTB
            // 
            this.BrojRezervacijeTB.Location = new System.Drawing.Point(153, 316);
            this.BrojRezervacijeTB.Name = "BrojRezervacijeTB";
            this.BrojRezervacijeTB.Size = new System.Drawing.Size(148, 20);
            this.BrojRezervacijeTB.TabIndex = 7;
            // 
            // GostRezervacija
            // 
            this.GostRezervacija.AutoSize = true;
            this.GostRezervacija.Location = new System.Drawing.Point(75, 97);
            this.GostRezervacija.Name = "GostRezervacija";
            this.GostRezervacija.Size = new System.Drawing.Size(29, 13);
            this.GostRezervacija.TabIndex = 9;
            this.GostRezervacija.Text = "Gost";
            // 
            // CheckInRezervacija
            // 
            this.CheckInRezervacija.AutoSize = true;
            this.CheckInRezervacija.Location = new System.Drawing.Point(63, 177);
            this.CheckInRezervacija.Name = "CheckInRezervacija";
            this.CheckInRezervacija.Size = new System.Drawing.Size(50, 13);
            this.CheckInRezervacija.TabIndex = 10;
            this.CheckInRezervacija.Text = "Check In";
            // 
            // CheckOutRezervacija
            // 
            this.CheckOutRezervacija.AutoSize = true;
            this.CheckOutRezervacija.Location = new System.Drawing.Point(63, 223);
            this.CheckOutRezervacija.Name = "CheckOutRezervacija";
            this.CheckOutRezervacija.Size = new System.Drawing.Size(58, 13);
            this.CheckOutRezervacija.TabIndex = 11;
            this.CheckOutRezervacija.Text = "Check Out";
            // 
            // BrojGostijuRezervacija
            // 
            this.BrojGostijuRezervacija.AutoSize = true;
            this.BrojGostijuRezervacija.Location = new System.Drawing.Point(63, 272);
            this.BrojGostijuRezervacija.Name = "BrojGostijuRezervacija";
            this.BrojGostijuRezervacija.Size = new System.Drawing.Size(60, 13);
            this.BrojGostijuRezervacija.TabIndex = 12;
            this.BrojGostijuRezervacija.Text = "Broj Gostiju";
            // 
            // BrojRezervacijeRezervacija
            // 
            this.BrojRezervacijeRezervacija.AutoSize = true;
            this.BrojRezervacijeRezervacija.Location = new System.Drawing.Point(63, 316);
            this.BrojRezervacijeRezervacija.Name = "BrojRezervacijeRezervacija";
            this.BrojRezervacijeRezervacija.Size = new System.Drawing.Size(84, 13);
            this.BrojRezervacijeRezervacija.TabIndex = 13;
            this.BrojRezervacijeRezervacija.Text = "Broj Rezervacije";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(153, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 82);
            this.listBox1.TabIndex = 14;
            // 
            // Dodaj_Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BrojRezervacijeRezervacija);
            this.Controls.Add(this.BrojGostijuRezervacija);
            this.Controls.Add(this.CheckOutRezervacija);
            this.Controls.Add(this.CheckInRezervacija);
            this.Controls.Add(this.GostRezervacija);
            this.Controls.Add(this.BrojRezervacijeTB);
            this.Controls.Add(this.BrojGostijuTB);
            this.Controls.Add(this.CheckOutTB);
            this.Controls.Add(this.CheckInTB);
            this.Controls.Add(this.DodajRezervacija);
            this.Name = "Dodaj_Rezervacija";
            this.Text = "Dodaj_Rezervacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajRezervacija;
        private System.Windows.Forms.TextBox CheckInTB;
        private System.Windows.Forms.TextBox CheckOutTB;
        private System.Windows.Forms.TextBox BrojGostijuTB;
        private System.Windows.Forms.TextBox BrojRezervacijeTB;
        private System.Windows.Forms.Label GostRezervacija;
        private System.Windows.Forms.Label CheckInRezervacija;
        private System.Windows.Forms.Label CheckOutRezervacija;
        private System.Windows.Forms.Label BrojGostijuRezervacija;
        private System.Windows.Forms.Label BrojRezervacijeRezervacija;
        private System.Windows.Forms.ListBox listBox1;
    }
}