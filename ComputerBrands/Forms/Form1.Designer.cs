namespace ComputerBrands
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrandList = new System.Windows.Forms.DataGridView();
            this.BrandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandFoundationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandLocalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchbutton = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBrandToolStripMenuItem,
            this.removeBrandToolStripMenuItem,
            this.updateBrandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addBrandToolStripMenuItem
            // 
            this.addBrandToolStripMenuItem.Name = "addBrandToolStripMenuItem";
            this.addBrandToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.addBrandToolStripMenuItem.Text = "Add Brand";
            this.addBrandToolStripMenuItem.Click += new System.EventHandler(this.addBrandToolStripMenuItem_Click);
            // 
            // removeBrandToolStripMenuItem
            // 
            this.removeBrandToolStripMenuItem.Name = "removeBrandToolStripMenuItem";
            this.removeBrandToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.removeBrandToolStripMenuItem.Text = "Remove Brand";
            this.removeBrandToolStripMenuItem.Click += new System.EventHandler(this.removeBrandToolStripMenuItem_Click);
            // 
            // updateBrandToolStripMenuItem
            // 
            this.updateBrandToolStripMenuItem.Name = "updateBrandToolStripMenuItem";
            this.updateBrandToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.updateBrandToolStripMenuItem.Text = "Update Brand";
            this.updateBrandToolStripMenuItem.Click += new System.EventHandler(this.updateBrandToolStripMenuItem_Click);
            // 
            // BrandList
            // 
            this.BrandList.AllowUserToAddRows = false;
            this.BrandList.AllowUserToDeleteRows = false;
            this.BrandList.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.BrandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BrandList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrandId,
            this.BrandName,
            this.BrandFoundationYear,
            this.BrandLocalCountry});
            this.BrandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandList.Location = new System.Drawing.Point(0, 24);
            this.BrandList.Name = "BrandList";
            this.BrandList.ReadOnly = true;
            this.BrandList.Size = new System.Drawing.Size(586, 333);
            this.BrandList.TabIndex = 1;
            // 
            // BrandId
            // 
            this.BrandId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrandId.HeaderText = "Id";
            this.BrandId.Name = "BrandId";
            this.BrandId.ReadOnly = true;
            this.BrandId.Width = 41;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "BrandNmae";
            this.BrandName.MinimumWidth = 20;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 130;
            // 
            // BrandFoundationYear
            // 
            this.BrandFoundationYear.HeaderText = "BrandFoundationYear";
            this.BrandFoundationYear.MinimumWidth = 50;
            this.BrandFoundationYear.Name = "BrandFoundationYear";
            this.BrandFoundationYear.ReadOnly = true;
            this.BrandFoundationYear.Width = 130;
            // 
            // BrandLocalCountry
            // 
            this.BrandLocalCountry.HeaderText = "BrandLocalCountry";
            this.BrandLocalCountry.Name = "BrandLocalCountry";
            this.BrandLocalCountry.ReadOnly = true;
            this.BrandLocalCountry.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.textsearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 100);
            this.panel1.TabIndex = 2;
            // 
            // searchbutton
            // 
            this.searchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbutton.BackgroundImage = global::ComputerBrands.Properties.Resources.search_icon_125165;
            this.searchbutton.Location = new System.Drawing.Point(549, 10);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(34, 32);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // textsearch
            // 
            this.textsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textsearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textsearch.Location = new System.Drawing.Point(374, 10);
            this.textsearch.Multiline = true;
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(171, 32);
            this.textsearch.TabIndex = 1;
            this.textsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ComputerBrands  Search\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(586, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BrandList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBrandToolStripMenuItem;
        private System.Windows.Forms.DataGridView BrandList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandFoundationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandLocalCountry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbutton;
    }
}

