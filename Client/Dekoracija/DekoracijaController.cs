using Client.Dekoracija;
using Client.Radnik;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    internal class DekoracijaController
    {
        private FrmIzmenaDekoracije frmIzmenaDekoracije;
        private FrmDodajDekoraciju frmDodajDekoraciju;
        private FrmObrisiDekoraciju frmObrisiDekoraciju;
        private FrmPrikazDekoracija frmPrikazDekoracija;
        Domain.Dekoracija d = new Domain.Dekoracija();
        List<Domain.Dekoracija> dekoracije = new List<Domain.Dekoracija>();
        List<Domain.Dekoracija> dekorZaIzmenu = new List<Domain.Dekoracija>();
        Domain.Dekoracija zaIzmenu = new Domain.Dekoracija();

        public DekoracijaController(FrmIzmenaDekoracije frmIzmenaDekoracije)
        {
            this.frmIzmenaDekoracije = frmIzmenaDekoracije;
            RefreshPrikaz();
            ObradiAkcije();
            IspuniCombo1();
        }

        private void RefreshPrikaz()
        {
            frmIzmenaDekoracije.DataGridView1.DataSource = Communication.Instance.UcitajSveDekoracije();
            frmIzmenaDekoracije.DataGridView1.Refresh();

        }

        private void ObradiAkcije()
        {
            frmIzmenaDekoracije.BtnPretraga.Click += BtnPretraga_Click;
            frmIzmenaDekoracije.BtnSacuvajDekoraciju.Click += BtnIzmena_Click;
            frmIzmenaDekoracije.DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
          
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (frmIzmenaDekoracije.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmenaDekoracije.DataGridView1.SelectedRows[0];
                if (obj.DataBoundItem is Domain.Dekoracija d)
                {
                    zaIzmenu = d;
                    frmIzmenaDekoracije.TxtNaziv.Text = zaIzmenu.Naziv;
                    frmIzmenaDekoracije.TxtSifra.Text = zaIzmenu.Sifra;
                    frmIzmenaDekoracije.ComboBox1.SelectedItem = zaIzmenu.Kategorija;
                    frmIzmenaDekoracije.ComboBox2.SelectedItem = zaIzmenu.Pdv;
                    MessageBox.Show("Sistem je učitao dekoraciju!");
                }
                else MessageBox.Show("Sistem nije učitao dekoraciju!");
            }
        }

        private void BtnIzmena_Click(object sender, EventArgs e)
        {
            if (frmIzmenaDekoracije.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmenaDekoracije.DataGridView1.SelectedRows[0];
                if (obj.DataBoundItem is Domain.Dekoracija d)
                {
                    zaIzmenu = d;
                } 
            }
            else
            {
                MessageBox.Show("Niste odabrali dekoraciju!");
                return;
            }


            zaIzmenu.Naziv = frmIzmenaDekoracije.TxtNaziv.Text;
            zaIzmenu.Sifra = frmIzmenaDekoracije.TxtSifra.Text;

            zaIzmenu.Kategorija =(Kategorija) frmIzmenaDekoracije.ComboBox1.SelectedItem;

            zaIzmenu.Pdv = (PDVStopa)frmIzmenaDekoracije.ComboBox2.SelectedItem;

            try
            {
                Communication.Instance.IzmeniDekoraciju(zaIzmenu);
                MessageBox.Show("Sistem je zapamtio dekoraciju!");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem nije uspeo da zapamti dekoraciju!");
            }
        }

        private void BtnPretraga_Click(object sender, EventArgs e)
        {
            Domain.Dekoracija d = new Domain.Dekoracija();

            string text = frmIzmenaDekoracije.TxtPretraga.Text;

            d.Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), text);
            dekorZaIzmenu = Communication.Instance.PretraziDekoracije(d);
            if (dekorZaIzmenu.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe dekoracije po zadatoj vrednosti!");
                return;
            }
            frmIzmenaDekoracije.DataGridView1.DataSource = dekorZaIzmenu;
            MessageBox.Show("Sistem je pronašao dekoracije po zadatom kriterijumu");
        }

        public DekoracijaController(FrmDodajDekoraciju frmDodajDekoraciju)
        {
            this.frmDodajDekoraciju = frmDodajDekoraciju;

            IspuniCombo();
            InitializeEvenetHandlers();

        }

        private void InitializeEvenetHandlers()
        {
            frmDodajDekoraciju.BtnSacuvaj.Click += SacuvajDekoraciju;
        }

        private void SacuvajDekoraciju(object sender, EventArgs e)
        {
            Domain.Dekoracija dekor = new Domain.Dekoracija();

           
            if (!string.IsNullOrWhiteSpace(frmDodajDekoraciju.TextBox1.Text))
            {
                dekor.Naziv = frmDodajDekoraciju.TextBox1.Text;

            }
            else
            {
                MessageBox.Show("Morate uneti naziv!");
                return;
            }


            if (!string.IsNullOrWhiteSpace(frmDodajDekoraciju.TextBox2.Text))
            {
                dekor.Sifra = frmDodajDekoraciju.TextBox2.Text;
            }
            else
            {
                MessageBox.Show("Morate uneti šifru!");
                return;
            }

            if (frmDodajDekoraciju.ComboBox1.SelectedIndex != -1)
            {
                dekor.Kategorija = (Kategorija)frmDodajDekoraciju.ComboBox1.SelectedItem;
            }
            else
            {
                MessageBox.Show("Morate izabrati kategoriju!");
                return;
            }

            if (frmDodajDekoraciju.ComboBox2.SelectedIndex != -1)
            {
                dekor.Pdv = (PDVStopa)frmDodajDekoraciju.ComboBox2.SelectedItem;
            }
            else
            {
                MessageBox.Show("Morate izabrati PDV stopu!");
                return;
            }


            try
            {
                Communication.Instance.DodajDekoraciju(dekor);
                MessageBox.Show("Sistem je zapamtio dekoraciju!");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem nije uspeo da zapamti dekoraciju!");
            }
        }

        private void IspuniCombo()
        {
            Array kategorije = Enum.GetValues(typeof(Kategorija));


            foreach (Kategorija category in kategorije)
            {
                frmDodajDekoraciju.ComboBox1.Items.Add(category);
            }


            Array stope = Enum.GetValues(typeof(PDVStopa));

            foreach (PDVStopa stopa in stope)
            {
                frmDodajDekoraciju.ComboBox2.Items.Add(stopa);
            }

        }

        private void IspuniCombo1()
        {

            Array kategorije = Enum.GetValues(typeof(Kategorija));

            foreach (Kategorija category in kategorije)
            {
                frmIzmenaDekoracije.ComboBox1.Items.Add(category);
            }


            Array stope = Enum.GetValues(typeof(PDVStopa));

            foreach (PDVStopa stopa in stope)
            {
                frmIzmenaDekoracije.ComboBox2.Items.Add(stopa);
            }

        }

        public DekoracijaController(FrmObrisiDekoraciju frmObrisiDekoraciju)
        {
            this.frmObrisiDekoraciju = frmObrisiDekoraciju;
            RefreshDgv();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            frmObrisiDekoraciju.BtnPretrazi.Click += PretraziPoNazivu;
            frmObrisiDekoraciju.BtnObrisi.Click += ObrisiDekoraciju;
        }

        private void ObrisiDekoraciju(object sender, EventArgs e)
        {
            Domain.Dekoracija d = new Domain.Dekoracija();

            if (frmObrisiDekoraciju.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = frmObrisiDekoraciju.DataGridView1.SelectedRows[0];


                if (selectedRow.DataBoundItem is Domain.Dekoracija selectedDeko)
                {

                    d= selectedDeko;
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali dekoraciju!");
                return;
            }

            try
            {
                Communication.Instance.ObrisiDekoraciju(d);
                MessageBox.Show("Dekoracija je obrisana!");
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem nije uspeo da obriše dekoraciju!");
            }

        }

        private void PretraziPoNazivu(object sender, EventArgs e)
        {
            Pretrazi();
        }


        private void Pretrazi()
        {
            string text = frmObrisiDekoraciju.TextBox1.Text;

            d.Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), text);
            dekoracije = Communication.Instance.PretraziDekoracije(d);
            if (dekoracije.Count == 0)
            {
                MessageBox.Show("Sistem nije pronašao dekoracije po zadatom kriterijumu!");
                return;
            }
            frmObrisiDekoraciju.DataGridView1.DataSource = dekoracije;
            MessageBox.Show("Sistem je pronašao dekoracije po zadatom kriterijumu");
        }

        private void RefreshDgv()
        {
            frmObrisiDekoraciju.DataGridView1.DataSource = Communication.Instance.UcitajSveDekoracije();
        }

        public DekoracijaController(FrmPrikazDekoracija frmPrikazDekoracija)
        {
            this.frmPrikazDekoracija = frmPrikazDekoracija;
            PrikazOperacija();
        }

        private void PrikazOperacija()
        {
            frmPrikazDekoracija.Button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Domain.Dekoracija> dekoracije = new List<Domain.Dekoracija>();
            dekoracije = (List<Domain.Dekoracija>)Communication.Instance.UcitajSveDekoracije();
            frmPrikazDekoracija.DataGridView1.DataSource = dekoracije;
        }
    }
}
