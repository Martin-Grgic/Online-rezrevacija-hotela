namespace Online_Rezervacija_hotela_MAIN.Forme
{
    partial class Dodaj_Gost_U_Sobi
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
            this.ImeTB = new System.Windows.Forms.TextBox();
            this.PrezimeTB = new System.Windows.Forms.TextBox();
            this.OIBTB = new System.Windows.Forms.TextBox();
            this.DodajGost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ImeTB
            // 
            this.ImeTB.Location = new System.Drawing.Point(151, 97);
            this.ImeTB.Name = "ImeTB";
            this.ImeTB.Size = new System.Drawing.Size(149, 20);
            this.ImeTB.TabIndex = 0;
            // 
            // PrezimeTB
            // 
            this.PrezimeTB.Location = new System.Drawing.Point(151, 163);
            this.PrezimeTB.Name = "PrezimeTB";
            this.PrezimeTB.Size = new System.Drawing.Size(149, 20);
            this.PrezimeTB.TabIndex = 1;
            // 
            // OIBTB
            // 
            this.OIBTB.Location = new System.Drawing.Point(151, 235);
            this.OIBTB.Name = "OIBTB";
            this.OIBTB.Size = new System.Drawing.Size(149, 20);
            this.OIBTB.TabIndex = 2;
            // 
            // DodajGost
            // 
            this.DodajGost.Location = new System.Drawing.Point(463, 97);
            this.DodajGost.Name = "DodajGost";
            this.DodajGost.Size = new System.Drawing.Size(148, 57);
            this.DodajGost.TabIndex = 4;
            this.DodajGost.Text = "Dodaj";
            this.DodajGost.UseVisualStyleBackColor = true;
            this.DodajGost.Click += new System.EventHandler(this.DodajGost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soba";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(151, 288);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 108);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Dodaj_Gost_U_Sobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajGost);
            this.Controls.Add(this.OIBTB);
            this.Controls.Add(this.PrezimeTB);
            this.Controls.Add(this.ImeTB);
            this.Name = "Dodaj_Gost_U_Sobi";
            this.Text = "Dodaj_Gost_U_Sobi";
            this.Load += new System.EventHandler(this.Dodaj_Gost_U_Sobi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImeTB;
        private System.Windows.Forms.TextBox PrezimeTB;
        private System.Windows.Forms.TextBox OIBTB;
        private System.Windows.Forms.Button DodajGost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}