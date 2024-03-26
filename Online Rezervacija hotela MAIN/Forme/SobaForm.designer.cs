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
            this.SearchSoba = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.SortSoba = new System.Windows.Forms.ComboBox();
            this.UpDown = new System.Windows.Forms.Button();
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
            this.DodajButton.Location = new System.Drawing.Point(538, 106);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(114, 43);
            this.DodajButton.TabIndex = 1;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // UrediButton
            // 
            this.UrediButton.Location = new System.Drawing.Point(538, 183);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(114, 38);
            this.UrediButton.TabIndex = 2;
            this.UrediButton.Text = "Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            this.UrediButton.Click += new System.EventHandler(this.UrediButton_Click);
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(538, 262);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(114, 41);
            this.ObrisiButton.TabIndex = 3;
            this.ObrisiButton.Text = "Obrisi";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(707, 26);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 47);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "⟳";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SearchSoba
            // 
            this.SearchSoba.Location = new System.Drawing.Point(358, 53);
            this.SearchSoba.Margin = new System.Windows.Forms.Padding(2);
            this.SearchSoba.Name = "SearchSoba";
            this.SearchSoba.Size = new System.Drawing.Size(126, 20);
            this.SearchSoba.TabIndex = 5;
            this.SearchSoba.TextChanged += new System.EventHandler(this.SearchSoba_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(356, 37);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            // 
            // SortSoba
            // 
            this.SortSoba.FormattingEnabled = true;
            this.SortSoba.Items.AddRange(new object[] {
            "Cijena noci",
            "Velicina sobe"});
            this.SortSoba.Location = new System.Drawing.Point(358, 130);
            this.SortSoba.Margin = new System.Windows.Forms.Padding(2);
            this.SortSoba.Name = "SortSoba";
            this.SortSoba.Size = new System.Drawing.Size(126, 21);
            this.SortSoba.TabIndex = 7;
            this.SortSoba.SelectedIndexChanged += new System.EventHandler(this.SortSoba_SelectedIndexChanged);
            // 
            // UpDown
            // 
            this.UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown.Location = new System.Drawing.Point(393, 175);
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(45, 46);
            this.UpDown.TabIndex = 8;
            this.UpDown.Text = "↑↓";
            this.UpDown.UseVisualStyleBackColor = true;
            this.UpDown.Visible = false;
            this.UpDown.Click += new System.EventHandler(this.UpDown_Click);
            // 
            // SobaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpDown);
            this.Controls.Add(this.SortSoba);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchSoba);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.UrediButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.ListBoxSoba);
            this.Name = "SobaForm";
            this.Text = "Soba";
            this.Load += new System.EventHandler(this.Soba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxSoba;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.Button ObrisiButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox SearchSoba;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ComboBox SortSoba;
        private System.Windows.Forms.Button UpDown;
    }
}