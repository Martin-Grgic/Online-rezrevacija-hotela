namespace Online_rezervacija_hotela_2._0
{
    partial class Rezervacija
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
            this.SobaButton = new System.Windows.Forms.Button();
            this.ListBoxRezervacija = new System.Windows.Forms.ListBox();
            this.SobeIGostUSobiButton = new System.Windows.Forms.Button();
            this.IzlazButton = new System.Windows.Forms.Button();
            this.UrediButton = new System.Windows.Forms.Button();
            this.GostUSobiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SobaButton
            // 
            this.SobaButton.Location = new System.Drawing.Point(77, 42);
            this.SobaButton.Name = "SobaButton";
            this.SobaButton.Size = new System.Drawing.Size(102, 33);
            this.SobaButton.TabIndex = 0;
            this.SobaButton.Text = "Soba";
            this.SobaButton.UseVisualStyleBackColor = true;
            this.SobaButton.Click += new System.EventHandler(this.SobaButton_Click);
            // 
            // ListBoxRezervacija
            // 
            this.ListBoxRezervacija.FormattingEnabled = true;
            this.ListBoxRezervacija.Location = new System.Drawing.Point(87, 101);
            this.ListBoxRezervacija.Name = "ListBoxRezervacija";
            this.ListBoxRezervacija.Size = new System.Drawing.Size(247, 290);
            this.ListBoxRezervacija.TabIndex = 2;
            // 
            // SobeIGostUSobiButton
            // 
            this.SobeIGostUSobiButton.Location = new System.Drawing.Point(445, 142);
            this.SobeIGostUSobiButton.Name = "SobeIGostUSobiButton";
            this.SobeIGostUSobiButton.Size = new System.Drawing.Size(142, 41);
            this.SobeIGostUSobiButton.TabIndex = 3;
            this.SobeIGostUSobiButton.Text = "Sobe i gost u sobi";
            this.SobeIGostUSobiButton.UseVisualStyleBackColor = true;
            this.SobeIGostUSobiButton.Click += new System.EventHandler(this.SobeIGostUSobiButton_Click);
            // 
            // IzlazButton
            // 
            this.IzlazButton.Location = new System.Drawing.Point(445, 303);
            this.IzlazButton.Name = "IzlazButton";
            this.IzlazButton.Size = new System.Drawing.Size(142, 41);
            this.IzlazButton.TabIndex = 5;
            this.IzlazButton.Text = "Izlaz";
            this.IzlazButton.UseVisualStyleBackColor = true;
            this.IzlazButton.Click += new System.EventHandler(this.IzlazButton_Click);
            // 
            // UrediButton
            // 
            this.UrediButton.Location = new System.Drawing.Point(445, 220);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(142, 41);
            this.UrediButton.TabIndex = 6;
            this.UrediButton.Text = " Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            this.UrediButton.Click += new System.EventHandler(this.UrediButton_Click);
            // 
            // GostUSobiButton
            // 
            this.GostUSobiButton.Location = new System.Drawing.Point(232, 42);
            this.GostUSobiButton.Name = "GostUSobiButton";
            this.GostUSobiButton.Size = new System.Drawing.Size(102, 33);
            this.GostUSobiButton.TabIndex = 7;
            this.GostUSobiButton.Text = "Gost u sobi";
            this.GostUSobiButton.UseVisualStyleBackColor = true;
            this.GostUSobiButton.Click += new System.EventHandler(this.GostUSobiButton_Click);
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GostUSobiButton);
            this.Controls.Add(this.UrediButton);
            this.Controls.Add(this.IzlazButton);
            this.Controls.Add(this.SobeIGostUSobiButton);
            this.Controls.Add(this.ListBoxRezervacija);
            this.Controls.Add(this.SobaButton);
            this.Name = "Rezervacija";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SobaButton;
        private System.Windows.Forms.ListBox ListBoxRezervacija;
        private System.Windows.Forms.Button SobeIGostUSobiButton;
       
        private System.Windows.Forms.Button IzlazButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.Button GostUSobiButton;
    }
}

