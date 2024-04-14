using Client.Dekoracija;
using Client.Radnik;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmGlavniMeni : Form
    {
        private Korisnik k;

        public FrmGlavniMeni()
        {
           
        }

        public FrmGlavniMeni(Korisnik k)
        {
            InitializeComponent();
            this.k = k;
            this.Text ="Glavni meni"+" "+ k.ToString();
           // label1.Text = k.ToString();
        }

       
        private void dodajRadnikaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmDodajRadnika());
        }

        private void obrišiRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmObrisiRadnika());
        }

        private void prikažiRadnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmPrikazRadnika());
        }

        private void izmeniKandidataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmIzmenaRadnika());
        }

        private void dodajDekoracijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmDodajDekoraciju());
        }

        private void prikažiDekoracijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmPrikazDekoracija());
        }

        private void izmeniDekoracijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmIzmenaDekoracije());
        }

        private void obrišiDekoracijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmObrisiDekoraciju());
        }

        private void dodajAngažovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmDodajAngazovanje());
        }

        private void izmeniAngažovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmIzmeniAngazovanje());
        }
    }
}
