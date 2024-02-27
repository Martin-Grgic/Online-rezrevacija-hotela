namespace Online_rezervacija_hotela_MAIN
{
    partial class SobaForm
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
            this.ListBoxSoba = new System.Windows.Forms.ListBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.UrediButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxSoba
            // 
            this.ListBoxSoba.FormattingEnabled = true;
            this.ListBoxSoba.Location = new System.Drawing.Point(85, 62);
            this.ListBoxSoba.Name = "ListBoxSoba";
            this.ListBoxSoba.Size = new System.Drawing.Size(219, 303);
            this.ListBoxSoba.TabIndex = 0;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(408, 102);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(114, 43);
            this.DodajButton.TabIndex = 1;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // UrediButton
            // 
            this.UrediButton.Location = new System.Drawing.Point(408, 187);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(114, 38);
            this.UrediButton.TabIndex = 2;
            this.UrediButton.Text = "Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            this.UrediButton.Click += new System.EventHandler(this.UrediButton_Click);
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(408, 283);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(114, 41);
            this.ObrisiButton.TabIndex = 3;
            this.ObrisiButton.Text = "Obrisi";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(586, 104);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(58, 39);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SobaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.UrediButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.ListBoxSoba);
            this.Name = "SobaForm";
            this.Text = "Soba";
            this.Load += new System.EventHandler(this.Soba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxSoba;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.Button ObrisiButton;
        private System.Windows.Forms.Button refreshButton;
    }
}