
namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namaBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namaBarangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namaBarangToolStripMenuItem,
            this.namaBarangToolStripMenuItem1,
            this.cetakBarangToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // namaBarangToolStripMenuItem
            // 
            this.namaBarangToolStripMenuItem.Name = "namaBarangToolStripMenuItem";
            this.namaBarangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.namaBarangToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.namaBarangToolStripMenuItem.Text = "Nama Barang";
            this.namaBarangToolStripMenuItem.Click += new System.EventHandler(this.namaBarangToolStripMenuItem_Click);
            // 
            // namaBarangToolStripMenuItem1
            // 
            this.namaBarangToolStripMenuItem1.Name = "namaBarangToolStripMenuItem1";
            this.namaBarangToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.namaBarangToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.namaBarangToolStripMenuItem1.Text = "Tambah Barang";
            this.namaBarangToolStripMenuItem1.Click += new System.EventHandler(this.namaBarangToolStripMenuItem1_Click);
            // 
            // cetakBarangToolStripMenuItem
            // 
            this.cetakBarangToolStripMenuItem.Name = "cetakBarangToolStripMenuItem";
            this.cetakBarangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.cetakBarangToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cetakBarangToolStripMenuItem.Text = "Cetak Barang";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.editToolStripMenuItem.Text = "Exit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namaBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namaBarangToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakBarangToolStripMenuItem;
    }
}

