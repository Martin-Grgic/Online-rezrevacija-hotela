namespace Online_rezervacija_hotela_2._0
{
    partial class Dodaj
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
            this.BrojSobeTextBox = new System.Windows.Forms.TextBox();
            this.TipSobeTextBox = new System.Windows.Forms.TextBox();
            this.CijenaNociTextbox = new System.Windows.Forms.TextBox();
            this.VelicinaSobeTextBox = new System.Windows.Forms.TextBox();
            this.dodajbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrojSobeTextBox
            // 
            this.BrojSobeTextBox.Location = new System.Drawing.Point(169, 102);
            this.BrojSobeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrojSobeTextBox.Name = "BrojSobeTextBox";
            this.BrojSobeTextBox.Size = new System.Drawing.Size(183, 22);
            this.BrojSobeTextBox.TabIndex = 0;
            // 
            // TipSobeTextBox
            // 
            this.TipSobeTextBox.Location = new System.Drawing.Point(169, 183);
            this.TipSobeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TipSobeTextBox.Name = "TipSobeTextBox";
            this.TipSobeTextBox.Size = new System.Drawing.Size(183, 22);
            this.TipSobeTextBox.TabIndex = 1;
            // 
            // CijenaNociTextbox
            // 
            this.CijenaNociTextbox.Location = new System.Drawing.Point(169, 263);
            this.CijenaNociTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CijenaNociTextbox.Name = "CijenaNociTextbox";
            this.CijenaNociTextbox.Size = new System.Drawing.Size(183, 22);
            this.CijenaNociTextbox.TabIndex = 2;
            // 
            // VelicinaSobeTextBox
            // 
            this.VelicinaSobeTextBox.Location = new System.Drawing.Point(169, 348);
            this.VelicinaSobeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VelicinaSobeTextBox.Name = "VelicinaSobeTextBox";
            this.VelicinaSobeTextBox.Size = new System.Drawing.Size(183, 22);
            this.VelicinaSobeTextBox.TabIndex = 3;
            // 
            // dodajbutton
            // 
            this.dodajbutton.Location = new System.Drawing.Point(515, 219);
            this.dodajbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajbutton.Name = "dodajbutton";
            this.dodajbutton.Size = new System.Drawing.Size(189, 57);
            this.dodajbutton.TabIndex = 4;
            this.dodajbutton.Text = "Dodaj";
            this.dodajbutton.UseVisualStyleBackColor = true;
            this.dodajbutton.Click += new System.EventHandler(this.dodajbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Broj Sobe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tip Sobe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cijena Noći";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Veličina Sobe";
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajbutton);
            this.Controls.Add(this.VelicinaSobeTextBox);
            this.Controls.Add(this.CijenaNociTextbox);
            this.Controls.Add(this.TipSobeTextBox);
            this.Controls.Add(this.BrojSobeTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dodaj";
            this.Text = "Dodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BrojSobeTextBox;
        private System.Windows.Forms.TextBox TipSobeTextBox;
        private System.Windows.Forms.TextBox CijenaNociTextbox;
        private System.Windows.Forms.TextBox VelicinaSobeTextBox;
        private System.Windows.Forms.Button dodajbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}