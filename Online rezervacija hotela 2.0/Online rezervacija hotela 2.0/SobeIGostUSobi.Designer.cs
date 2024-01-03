namespace Online_rezervacija_hotela_2._0
{
    partial class SobeIGostUSobi
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.DPButton = new System.Windows.Forms.Button();
            this.CBButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(84, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 147);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(84, 232);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 147);
            this.listBox2.TabIndex = 1;
            // 
            // DPButton
            // 
            this.DPButton.Location = new System.Drawing.Point(372, 118);
            this.DPButton.Name = "DPButton";
            this.DPButton.Size = new System.Drawing.Size(99, 35);
            this.DPButton.TabIndex = 2;
            this.DPButton.Text = "DP";
            this.DPButton.UseVisualStyleBackColor = true;
            // 
            // CBButton
            // 
            this.CBButton.Location = new System.Drawing.Point(372, 199);
            this.CBButton.Name = "CBButton";
            this.CBButton.Size = new System.Drawing.Size(99, 35);
            this.CBButton.TabIndex = 3;
            this.CBButton.Text = "CB";
            this.CBButton.UseVisualStyleBackColor = true;
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(372, 286);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(99, 35);
            this.ObrisiButton.TabIndex = 4;
            this.ObrisiButton.Text = "Obrisi";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // SobeIGostUSobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.CBButton);
            this.Controls.Add(this.DPButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "SobeIGostUSobi";
            this.Text = "SobeIGostUSobi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button DPButton;
        private System.Windows.Forms.Button CBButton;
        private System.Windows.Forms.Button ObrisiButton;
    }
}