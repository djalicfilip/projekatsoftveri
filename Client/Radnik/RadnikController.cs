using Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Radnik
{
    internal class RadnikController
    {
        private FrmDodajRadnika frmDodajRadnika;
        private FrmObrisiRadnika frmObrisiRadnika;
        Domain.Radnik r = new Domain.Radnik();
        List<Domain.Radnik> radnici = new List<Domain.Radnik>();
        List<Domain.Radnik> radniciZaIzmenu = new List<Domain.Radnik>();
        private FrmPrikazRadnika frmPrikazRadnika;
        private FrmIzmenaRadnika frmIzmenaRadnika;
        Domain.Radnik zaIzmenu = new Domain.Radnik();

        public RadnikController(FrmDodajRadnika frmDodajRadnika)
        {
            this.frmDodajRadnika = frmDodajRadnika;
            OsveziPrikazGradova();
           InitializeEventHandlers();
        }

        public RadnikController(FrmObrisiRadnika frmObrisiRadnika)
        {
            this.frmObrisiRadnika = frmObrisiRadnika;
            RefreshDgv();
            InitializeEvents();
        }

        public RadnikController(FrmPrikazRadnika frmPrikazRadnika)
        {
            this.frmPrikazRadnika = frmPrikazRadnika;
            PrikazOperacija();
        }

        public RadnikController(FrmIzmenaRadnika frmIzmenaRadnika)
        {
            this.frmIzmenaRadnika = frmIzmenaRadnika;
            frmIzmenaRadnika.DataGridView2.DataSource = Communication.Instance.VratiSveGradove();
            RefreshPrikaz();
            ObradiAkcije();
        }

        private void RefreshPrikaz()
        {
            frmIzmenaRadnika.DataGridView1.DataSource = Communication.Instance.UcitajSveRadnike();
            frmIzmenaRadnika.DataGridView1.Refresh();
          


        }

        private void ObradiAkcije()
        {
            frmIzmenaRadnika.BtnPretraga.Click += BtnPretraga_Click;
            frmIzmenaRadnika.BtnIzmena.Click +=BtnIzmena_Click;
            frmIzmenaRadnika.DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (frmIzmenaRadnika.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmenaRadnika.DataGridView1.SelectedRows[0];
                if (obj.DataBoundItem is Domain.Radnik r)
                {
                    zaIzmenu = r;
                    frmIzmenaRadnika.TxtIme.Text = zaIzmenu.Ime;
                    frmIzmenaRadnika.TxtPrezime.Text = zaIzmenu.Prezime;
                    frmIzmenaRadnika.TxtBroj.Text = zaIzmenu.BrojTelefona;
                    frmIzmenaRadnika.TxtAdresa.Text = zaIzmenu.Adresa;
                    frmIzmenaRadnika.DateTimePicker1.Value = zaIzmenu.DatumRodjenja;
                    MessageBox.Show("Sistem je učitao radnika!");
                }
                else MessageBox.Show("Sistem nije učitao radnika!");

            }
           
        }

        private void BtnIzmena_Click(object sender, EventArgs e)
        {
            if (frmIzmenaRadnika.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmenaRadnika.DataGridView1.SelectedRows[0];
                if (obj.DataBoundItem is Domain.Radnik r)
                {
                    zaIzmenu = r;
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali radnika!");
                return;
            }
           


            if (!string.IsNullOrWhiteSpace(frmIzmenaRadnika.TxtIme.Text))
            {
                zaIzmenu.Ime = frmIzmenaRadnika.TxtIme.Text;

            }


            if (!string.IsNullOrWhiteSpace(frmIzmenaRadnika.TxtPrezime.Text))
            {
                zaIzmenu.Prezime = frmIzmenaRadnika.TxtPrezime.Text;
            }

            if (!string.IsNullOrWhiteSpace(frmIzmenaRadnika.TxtAdresa.Text))
            {
                zaIzmenu.Adresa = frmIzmenaRadnika.TxtAdresa.Text;
            }

            if (!string.IsNullOrWhiteSpace(frmIzmenaRadnika.TxtBroj.Text))
            {
                zaIzmenu.BrojTelefona = frmIzmenaRadnika.TxtBroj.Text;
            }
       
            zaIzmenu.DatumRodjenja = frmIzmenaRadnika.DateTimePicker1.Value;

           
            if (frmIzmenaRadnika.DataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmenaRadnika.DataGridView2.SelectedRows[0];
                if (obj.DataBoundItem is Grad g)
                {
                    zaIzmenu.Grad = g;
                }
            }


            try
            {
                Communication.Instance.IzmeniRadnika(zaIzmenu);
                MessageBox.Show("Sistem je zapamtio radnika!");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem nije uspeo da zapamti radnika!");
            }
        }

        private void BtnPretraga_Click(object sender, EventArgs e)
        {
            Domain.Radnik r = new Domain.Radnik();

            string ime = frmIzmenaRadnika.TxtImePretraga.Text;
            r.Ime = ime;
            radniciZaIzmenu = Communication.Instance.Pretrazi(r);
            if (radniciZaIzmenu.Count == 0)
            {
                MessageBox.Show("Sistem ne može da pronađe radnika po zadatoj vrednosti!");
                return;
            }
            frmIzmenaRadnika.DataGridView1.DataSource = radniciZaIzmenu;
            MessageBox.Show("Sistem je pronasao radnike po zadatom kriterijumu");
        }

        private void PrikazOperacija()
        {
            frmPrikazRadnika.Button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Domain.Radnik> radnici = new List<Domain.Radnik>();
            radnici = (List<Domain.Radnik>)Communication.Instance.UcitajSveRadnike();
            frmPrikazRadnika.DataGridView1.DataSource = radnici;
        }

        private void InitializeEvents()
        {
            frmObrisiRadnika.Button1.Click += PretraziPoImenu;
            frmObrisiRadnika.Button2.Click += ObrisiRadnika;
        }

        private void ObrisiRadnika(object sender, EventArgs e)
        {
            Domain.Radnik r = new Domain.Radnik();

            if (frmObrisiRadnika.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = frmObrisiRadnika.DataGridView1.SelectedRows[0];


                if (selectedRow.DataBoundItem is Domain.Radnik selectedRadnik)
                {

                    r = selectedRadnik;
                 
                }

            }
            
            else
            {
                MessageBox.Show("Niste odabrali radnika!");
                return;
            }

            try
            {
                Communication.Instance.ObrisiRadnika(r);
                MessageBox.Show("Sistem je obrisao radnika!");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem nije uspeo da obriše radnika!");
            }
            RefreshDgv();

        }

        private void PretraziPoImenu(object sender, EventArgs e)
        {
            Pretrazi();
        }

       
        private void Pretrazi()
        {
            string text = frmObrisiRadnika.TextBox1.Text;

            r.Ime = text;
            radnici = Communication.Instance.Pretrazi(r);
            if (radnici.Count == 0)
            {
                MessageBox.Show("Sistem nije pronasao radnike po zadatom kriterijumu!");
                return;
            }
            frmObrisiRadnika.DataGridView1.DataSource = radnici;
            MessageBox.Show("Sistem je pronasao radnike po zadatom kriterijumu");
        }

        private void RefreshDgv()
        {
            frmObrisiRadnika.DataGridView1.DataSource = Communication.Instance.UcitajSveRadnike();
        }

        private void InitializeEventHandlers()
        {
            frmDodajRadnika.BtnSacuvajRadnika.Click+= SacuvajRadnika;

        }

        private void SacuvajRadnika(object sender, EventArgs e)
        {
            Domain.Radnik radnik = new Domain.Radnik();
            if (string.IsNullOrWhiteSpace(frmDodajRadnika.TextBox1.Text))
            {
                MessageBox.Show("Unesite ime"); 
                return;
            }
            string inputText = frmDodajRadnika.TextBox1.Text;
            if (!char.IsUpper(inputText, 0))
            {
                MessageBox.Show("Ime radnika treba početi velikim slovom!");
                return;
            }
            radnik.Ime = frmDodajRadnika.TextBox1.Text;

            if (string.IsNullOrWhiteSpace(frmDodajRadnika.TextBox2.Text))
            {
                MessageBox.Show("Unesite prezime radnika!");
                return;
            }
            string prezime = frmDodajRadnika.TextBox2.Text;
            if (!char.IsUpper(prezime, 0))
            {
                MessageBox.Show("Prezime radnika treba početi velikim slovom!");
                return;
            }

            radnik.Prezime = frmDodajRadnika.TextBox2.Text;

            if (string.IsNullOrWhiteSpace(frmDodajRadnika.TextBox3.Text))
            {
                MessageBox.Show("Unesite telefonski broj radnika!");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(frmDodajRadnika.TextBox3.Text, @"^\+381"))
            {
                MessageBox.Show("Telefonski broj treba da bude u +381 formatu!");
                return;
            }
            radnik.BrojTelefona = frmDodajRadnika.TextBox3.Text;

            string adresa = frmDodajRadnika.TextBox4.Text;
            if (!char.IsUpper(adresa, 0))
            {
                MessageBox.Show("Prezime radnika treba početi velikim slovom!");
                return;
            }

            radnik.Adresa = frmDodajRadnika.TextBox4.Text;



            DateTime selectedDate = frmDodajRadnika.DateTimePicker1.Value;
 
            radnik.DatumRodjenja = selectedDate;




            if (frmDodajRadnika.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = frmDodajRadnika.DataGridView1.SelectedRows[0];


                if (selectedRow.DataBoundItem is Grad selectedGrad)
                {

                    radnik.Grad = selectedGrad;
                }

            }
            else
            {
                MessageBox.Show("Izaberite grad!");
                return;
            }



            try
            {
                Communication.Instance.DodajRadnika(radnik);
                MessageBox.Show("Uspesno sacuvan radnik!");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem nije uspeo da sačuva radnika!");
            }


        }
    

    private void OsveziPrikazGradova()
        {
            frmDodajRadnika.DataGridView1.DataSource = Communication.Instance.VratiSveGradove();
            frmDodajRadnika.DataGridView1.Refresh();
        }
    }
}
