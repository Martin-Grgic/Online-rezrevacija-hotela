namespace Online_rezervacija_hotela_MAIN
{
    partial class Dodaj_soba
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
            this.DodajSoba = new System.Windows.Forms.Button();
            this.BrojSobeTB = new System.Windows.Forms.TextBox();
            this.TipSobeTB = new System.Windows.Forms.TextBox();
            this.CijenaNociTB = new System.Windows.Forms.TextBox();
            this.VelicinaSobeTB = new System.Windows.Forms.TextBox();
            this.BrojSobeLabel = new System.Windows.Forms.Label();
            this.TipSobeLabel = new System.Windows.Forms.Label();
            this.CijenaNociLabel = new System.Windows.Forms.Label();
            this.VelicinaSobeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DodajSoba
            // 
            this.DodajSoba.Location = new System.Drawing.Point(403, 164);
            this.DodajSoba.Name = "DodajSoba";
            this.DodajSoba.Size = new System.Drawing.Size(148, 57);
            this.DodajSoba.TabIndex = 0;
            this.DodajSoba.Text = "Dodaj";
            this.DodajSoba.UseVisualStyleBackColor = true;
            this.DodajSoba.Click += new System.EventHandler(this.DodajSoba_Click);
            // 
            // BrojSobeTB
            // 
            this.BrojSobeTB.Location = new System.Drawing.Point(138, 111);
            this.BrojSobeTB.Name = "BrojSobeTB";
            this.BrojSobeTB.Size = new System.Drawing.Size(141, 20);
            this.BrojSobeTB.TabIndex = 1;
            // 
            // TipSobeTB
            // 
            this.TipSobeTB.Location = new System.Drawing.Point(138, 164);
            this.TipSobeTB.Name = "TipSobeTB";
            this.TipSobeTB.Size = new System.Drawing.Size(141, 20);
            this.TipSobeTB.TabIndex = 2;
            // 
            // CijenaNociTB
            // 
            this.CijenaNociTB.Location = new System.Drawing.Point(138, 216);
            this.CijenaNociTB.Name = "CijenaNociTB";
            this.CijenaNociTB.Size = new System.Drawing.Size(141, 20);
            this.CijenaNociTB.TabIndex = 3;
            // 
            // VelicinaSobeTB
            // 
            this.VelicinaSobeTB.Location = new System.Drawing.Point(138, 271);
            this.VelicinaSobeTB.Name = "VelicinaSobeTB";
            this.VelicinaSobeTB.Size = new System.Drawing.Size(141, 20);
            this.VelicinaSobeTB.TabIndex = 4;
            // 
            // BrojSobeLabel
            // 
            this.BrojSobeLabel.AutoSize = true;
            this.BrojSobeLabel.Location = new System.Drawing.Point(56, 118);
            this.BrojSobeLabel.Name = "BrojSobeLabel";
            this.BrojSobeLabel.Size = new System.Drawing.Size(53, 13);
            this.BrojSobeLabel.TabIndex = 5;
            this.BrojSobeLabel.Text = "Broj Sobe";
            // 
            // TipSobeLabel
            // 
            this.TipSobeLabel.AutoSize = true;
            this.TipSobeLabel.Location = new System.Drawing.Point(56, 167);
            this.TipSobeLabel.Name = "TipSobeLabel";
            this.TipSobeLabel.Size = new System.Drawing.Size(50, 13);
            this.TipSobeLabel.TabIndex = 6;
            this.TipSobeLabel.Text = "Tip Sobe";
            // 
            // CijenaNociLabel
            // 
            this.CijenaNociLabel.AutoSize = true;
            this.CijenaNociLabel.Location = new System.Drawing.Point(56, 216);
            this.CijenaNociLabel.Name = "CijenaNociLabel";
            this.CijenaNociLabel.Size = new System.Drawing.Size(61, 13);
            this.CijenaNociLabel.TabIndex = 7;
            this.CijenaNociLabel.Text = "Cijena Noci";
            // 
            // VelicinaSobeLabel
            // 
            this.VelicinaSobeLabel.AutoSize = true;
            this.VelicinaSobeLabel.Location = new System.Drawing.Point(56, 271);
            this.VelicinaSobeLabel.Name = "VelicinaSobeLabel";
            this.VelicinaSobeLabel.Size = new System.Drawing.Size(72, 13);
            this.VelicinaSobeLabel.TabIndex = 8;
            this.VelicinaSobeLabel.Text = "Velicina Sobe";
            // 
            // Dodaj_soba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VelicinaSobeLabel);
            this.Controls.Add(this.CijenaNociLabel);
            this.Controls.Add(this.TipSobeLabel);
            this.Controls.Add(this.BrojSobeLabel);
            this.Controls.Add(this.VelicinaSobeTB);
            this.Controls.Add(this.CijenaNociTB);
            this.Controls.Add(this.TipSobeTB);
            this.Controls.Add(this.BrojSobeTB);
            this.Controls.Add(this.DodajSoba);
            this.Name = "Dodaj_soba";
            this.Text = "Dodaj_soba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajSoba;
        private System.Windows.Forms.TextBox BrojSobeTB;
        private System.Windows.Forms.TextBox TipSobeTB;
        private System.Windows.Forms.TextBox CijenaNociTB;
        private System.Windows.Forms.TextBox VelicinaSobeTB;
        private System.Windows.Forms.Label BrojSobeLabel;
        private System.Windows.Forms.Label TipSobeLabel;
        private System.Windows.Forms.Label CijenaNociLabel;
        private System.Windows.Forms.Label VelicinaSobeLabel;
    }
}