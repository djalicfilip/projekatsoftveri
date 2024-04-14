namespace Client
{
    partial class FrmGlavniMeni
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
            this.kandidatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiKandidataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniKandidataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiRadnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDekoracijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiDekoracijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniDekoracijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiDekoracijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angažovanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajAngažovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniAngažovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kandidatiToolStripMenuItem,
            this.inventarToolStripMenuItem,
            this.angažovanjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kandidatiToolStripMenuItem
            // 
            this.kandidatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajRadnikaToolStripMenuItem,
            this.obrišiKandidataToolStripMenuItem,
            this.izmeniKandidataToolStripMenuItem,
            this.prikažiRadnikeToolStripMenuItem});
            this.kandidatiToolStripMenuItem.Name = "kandidatiToolStripMenuItem";
            this.kandidatiToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.kandidatiToolStripMenuItem.Text = "Osoblje";
            // 
            // dodajRadnikaToolStripMenuItem
            // 
            this.dodajRadnikaToolStripMenuItem.Name = "dodajRadnikaToolStripMenuItem";
            this.dodajRadnikaToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.dodajRadnikaToolStripMenuItem.Text = "Dodaj radnika";
            this.dodajRadnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajRadnikaToolStripMenuItem_Click_1);
            // 
            // obrišiKandidataToolStripMenuItem
            // 
            this.obrišiKandidataToolStripMenuItem.Name = "obrišiKandidataToolStripMenuItem";
            this.obrišiKandidataToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.obrišiKandidataToolStripMenuItem.Text = "Obriši radnika";
            this.obrišiKandidataToolStripMenuItem.Click += new System.EventHandler(this.obrišiRadnikaToolStripMenuItem_Click);
            // 
            // izmeniKandidataToolStripMenuItem
            // 
            this.izmeniKandidataToolStripMenuItem.Name = "izmeniKandidataToolStripMenuItem";
            this.izmeniKandidataToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.izmeniKandidataToolStripMenuItem.Text = "Izmeni radnika";
            this.izmeniKandidataToolStripMenuItem.Click += new System.EventHandler(this.izmeniKandidataToolStripMenuItem_Click);
            // 
            // prikažiRadnikeToolStripMenuItem
            // 
            this.prikažiRadnikeToolStripMenuItem.Name = "prikažiRadnikeToolStripMenuItem";
            this.prikažiRadnikeToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.prikažiRadnikeToolStripMenuItem.Text = "Prikaži radnike";
            this.prikažiRadnikeToolStripMenuItem.Click += new System.EventHandler(this.prikažiRadnikeToolStripMenuItem_Click);
            // 
            // inventarToolStripMenuItem
            // 
            this.inventarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajDekoracijuToolStripMenuItem,
            this.prikažiDekoracijeToolStripMenuItem,
            this.izmeniDekoracijuToolStripMenuItem,
            this.obrišiDekoracijuToolStripMenuItem});
            this.inventarToolStripMenuItem.Name = "inventarToolStripMenuItem";
            this.inventarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.inventarToolStripMenuItem.Text = "Inventar";
            // 
            // dodajDekoracijuToolStripMenuItem
            // 
            this.dodajDekoracijuToolStripMenuItem.Name = "dodajDekoracijuToolStripMenuItem";
            this.dodajDekoracijuToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.dodajDekoracijuToolStripMenuItem.Text = "Dodaj dekoraciju";
            this.dodajDekoracijuToolStripMenuItem.Click += new System.EventHandler(this.dodajDekoracijuToolStripMenuItem_Click);
            // 
            // prikažiDekoracijeToolStripMenuItem
            // 
            this.prikažiDekoracijeToolStripMenuItem.Name = "prikažiDekoracijeToolStripMenuItem";
            this.prikažiDekoracijeToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.prikažiDekoracijeToolStripMenuItem.Text = "Prikaži dekoracije";
            this.prikažiDekoracijeToolStripMenuItem.Click += new System.EventHandler(this.prikažiDekoracijeToolStripMenuItem_Click);
            // 
            // izmeniDekoracijuToolStripMenuItem
            // 
            this.izmeniDekoracijuToolStripMenuItem.Name = "izmeniDekoracijuToolStripMenuItem";
            this.izmeniDekoracijuToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.izmeniDekoracijuToolStripMenuItem.Text = "Izmeni dekoraciju";
            this.izmeniDekoracijuToolStripMenuItem.Click += new System.EventHandler(this.izmeniDekoracijuToolStripMenuItem_Click);
            // 
            // obrišiDekoracijuToolStripMenuItem
            // 
            this.obrišiDekoracijuToolStripMenuItem.Name = "obrišiDekoracijuToolStripMenuItem";
            this.obrišiDekoracijuToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.obrišiDekoracijuToolStripMenuItem.Text = "Obriši dekoraciju";
            this.obrišiDekoracijuToolStripMenuItem.Click += new System.EventHandler(this.obrišiDekoracijuToolStripMenuItem_Click);
            // 
            // angažovanjaToolStripMenuItem
            // 
            this.angažovanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajAngažovanjeToolStripMenuItem,
            this.izmeniAngažovanjeToolStripMenuItem});
            this.angažovanjaToolStripMenuItem.Name = "angažovanjaToolStripMenuItem";
            this.angažovanjaToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.angažovanjaToolStripMenuItem.Text = "Angažovanja";
            // 
            // dodajAngažovanjeToolStripMenuItem
            // 
            this.dodajAngažovanjeToolStripMenuItem.Name = "dodajAngažovanjeToolStripMenuItem";
            this.dodajAngažovanjeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajAngažovanjeToolStripMenuItem.Text = "Dodaj angažovanje";
            this.dodajAngažovanjeToolStripMenuItem.Click += new System.EventHandler(this.dodajAngažovanjeToolStripMenuItem_Click);
            // 
            // izmeniAngažovanjeToolStripMenuItem
            // 
            this.izmeniAngažovanjeToolStripMenuItem.Name = "izmeniAngažovanjeToolStripMenuItem";
            this.izmeniAngažovanjeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniAngažovanjeToolStripMenuItem.Text = "Izmeni angažovanje";
            this.izmeniAngažovanjeToolStripMenuItem.Click += new System.EventHandler(this.izmeniAngažovanjeToolStripMenuItem_Click);
            // 
            // FrmGlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGlavniMeni";
            this.Text = "GlavniMeni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kandidatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiKandidataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniKandidataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajDekoracijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiDekoracijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniDekoracijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiDekoracijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angažovanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajAngažovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniAngažovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiRadnikeToolStripMenuItem;
    }
}