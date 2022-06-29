namespace ComputerBrands
{
    partial class AddBrandFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.countrybox = new System.Windows.Forms.TextBox();
            this.addbrandbutton = new System.Windows.Forms.Button();
            this.yearbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BrandName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BrandFoundationYear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BrandLocalCountry";
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.namebox.Location = new System.Drawing.Point(145, 13);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(113, 20);
            this.namebox.TabIndex = 4;
            // 
            // countrybox
            // 
            this.countrybox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.countrybox.Location = new System.Drawing.Point(145, 112);
            this.countrybox.Name = "countrybox";
            this.countrybox.Size = new System.Drawing.Size(113, 20);
            this.countrybox.TabIndex = 5;
            // 
            // addbrandbutton
            // 
            this.addbrandbutton.BackColor = System.Drawing.Color.Silver;
            this.addbrandbutton.Location = new System.Drawing.Point(246, 144);
            this.addbrandbutton.Name = "addbrandbutton";
            this.addbrandbutton.Size = new System.Drawing.Size(74, 42);
            this.addbrandbutton.TabIndex = 6;
            this.addbrandbutton.Text = "save";
            this.addbrandbutton.UseVisualStyleBackColor = false;
            this.addbrandbutton.Click += new System.EventHandler(this.addbrandbutton_Click);
            // 
            // yearbox
            // 
            this.yearbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yearbox.Location = new System.Drawing.Point(145, 61);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(113, 20);
            this.yearbox.TabIndex = 7;
            // 
            // AddBrandFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(328, 198);
            this.Controls.Add(this.yearbox);
            this.Controls.Add(this.addbrandbutton);
            this.Controls.Add(this.countrybox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBrandFrom";
            this.Text = "AddBrand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox countrybox;
        private System.Windows.Forms.Button addbrandbutton;
        private System.Windows.Forms.TextBox yearbox;
    }
}