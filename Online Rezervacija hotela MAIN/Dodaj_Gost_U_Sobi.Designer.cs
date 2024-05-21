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
            this.SobaLB = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImeTB
            // 
            this.ImeTB.Location = new System.Drawing.Point(201, 119);
            this.ImeTB.Margin = new System.Windows.Forms.Padding(4);
            this.ImeTB.Name = "ImeTB";
            this.ImeTB.Size = new System.Drawing.Size(197, 22);
            this.ImeTB.TabIndex = 0;
            // 
            // PrezimeTB
            // 
            this.PrezimeTB.Location = new System.Drawing.Point(201, 201);
            this.PrezimeTB.Margin = new System.Windows.Forms.Padding(4);
            this.PrezimeTB.Name = "PrezimeTB";
            this.PrezimeTB.Size = new System.Drawing.Size(197, 22);
            this.PrezimeTB.TabIndex = 1;
            // 
            // OIBTB
            // 
            this.OIBTB.Location = new System.Drawing.Point(201, 289);
            this.OIBTB.Margin = new System.Windows.Forms.Padding(4);
            this.OIBTB.Name = "OIBTB";
            this.OIBTB.Size = new System.Drawing.Size(197, 22);
            this.OIBTB.TabIndex = 2;
            // 
            // DodajGost
            // 
            this.DodajGost.Location = new System.Drawing.Point(617, 119);
            this.DodajGost.Margin = new System.Windows.Forms.Padding(4);
            this.DodajGost.Name = "DodajGost";
            this.DodajGost.Size = new System.Drawing.Size(197, 70);
            this.DodajGost.TabIndex = 4;
            this.DodajGost.Text = "Dodaj";
            this.DodajGost.UseVisualStyleBackColor = true;
            this.DodajGost.Click += new System.EventHandler(this.DodajGost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soba";
            // 
            // SobaLB
            // 
            this.SobaLB.FormattingEnabled = true;
            this.SobaLB.ItemHeight = 16;
            this.SobaLB.Location = new System.Drawing.Point(201, 354);
            this.SobaLB.Margin = new System.Windows.Forms.Padding(4);
            this.SobaLB.Name = "SobaLB";
            this.SobaLB.Size = new System.Drawing.Size(233, 132);
            this.SobaLB.TabIndex = 9;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(933, 36);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 58);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "⟳";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Dodaj_Gost_U_Sobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.SobaLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajGost);
            this.Controls.Add(this.OIBTB);
            this.Controls.Add(this.PrezimeTB);
            this.Controls.Add(this.ImeTB);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ListBox SobaLB;
        private System.Windows.Forms.Button refreshButton;
    }
}