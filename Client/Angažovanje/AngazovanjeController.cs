using Client.Dekoracija;
using Client.Radnik;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal class AngazovanjeController
    {
        private FrmDodajAngazovanje frmDodajAngazovanje;
        BindingList<Domain.StavkaAngazovanja> stavke = new BindingList<Domain.StavkaAngazovanja>();
        StavkaCenovnika stavka = new StavkaCenovnika();
        Angazovanje angazovanje = new Angazovanje();
        Domain.Radnik radnik = new Domain.Radnik();
        Domain.Angazovanje zaIzmenu = new Domain.Angazovanje();
        public AngazovanjeController(FrmDodajAngazovanje frmDodajAngazovanje)
        {
            this.frmDodajAngazovanje = frmDodajAngazovanje;
            popuniFormu();
            obradiAkcije();
        }

        public AngazovanjeController(FrmIzmeniAngazovanje frmIzmeniAngazovanje)
        {
            this.frmIzmeniAngazovanje = frmIzmeniAngazovanje;
            RefreshPrikaz();
           InitializeEvenetHandlers();

        }

        private void InitializeEvenetHandlers()
        {
            frmIzmeniAngazovanje.BtnPretraga.Click += PretraziAngazovanja;
            frmIzmeniAngazovanje.BtnIzaberi.Click += IzaberiAngazovanje;
            frmIzmeniAngazovanje.BtnIzmeniAngazovanje.Click += IzmeniAngazovanje;
            frmIzmeniAngazovanje.BtnDodajStavku.Click += DodajStavku1;
            frmIzmeniAngazovanje.BtnPretragaCenovnika.Click += PretraziCenovnik1;
            frmIzmeniAngazovanje.BtnObrisiStavku.Click += ObrisiStavku1;
        }

        private void IzmeniAngazovanje(object sender, EventArgs e)
        {
           List<StavkaAngazovanja> lista = new List<StavkaAngazovanja>();
            foreach (StavkaAngazovanja stavka in stavke)
            {
                lista.Add(stavka);
            }

            Angazovanje novoAng = new Angazovanje
            {
                ID = zaIzmenu.ID,
                TipAngazovanja = (TipAngazovanja)frmIzmeniAngazovanje.ComboBox1.SelectedItem,
                Radnik = zaIzmenu.Radnik,
                StavkaAngazovanja = lista
            };
            DateTime datum;

            if (!DateTime.TryParse(frmIzmeniAngazovanje.TxtDatum.Text, out datum))
            {
                MessageBox.Show("Neispravan format datuma!Molim unesite datum u formatu: DD-MM-YYYY");
                return;
            }
            novoAng.DatumObavljanja = datum;

            try
            {
                string input = frmIzmeniAngazovanje.TxtVreme.Text;
                TimeSpan parsedTime;
                if (TimeSpan.TryParse(input, out parsedTime))
                {
                    novoAng.VremeObavljanja = parsedTime;
                    Console.WriteLine(angazovanje.VremeObavljanja);
                }
                else
                {
                    MessageBox.Show("Pogrešan format vremena. Unesite vreme u formatu:HH:MM");
                    return;
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine("Greska kod vremena u terminu" + ex.Message);
            }
            
            stavke.Clear();
            try
            {
                Communication.Instance.IzmeniAngazovanje(novoAng);
                MessageBox.Show("Angažovanje uspešno izmenjeno!");
                RefreshPrikaz();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne moze da zapamti angažovanje!" + ex.Message);
                return;
            }
        }

        private void IzaberiAngazovanje(object sender, EventArgs e)
        {
            if (frmIzmeniAngazovanje.DgvAngazovanja.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmeniAngazovanje.DgvAngazovanja.SelectedRows[0];
                if (obj.DataBoundItem is Domain.Angazovanje a)
                {
                    zaIzmenu = a;
                    frmIzmeniAngazovanje.TxtDatum.Text = zaIzmenu.DatumObavljanja.ToString();
                    frmIzmeniAngazovanje.TxtVreme.Text = zaIzmenu.VremeObavljanja.ToString() ;
                    frmIzmeniAngazovanje.ComboBox1.SelectedItem = zaIzmenu.TipAngazovanja;
                    List<StavkaAngazovanja> lista = Communication.Instance.UcitajSveStavkeAngazovanja(a);
                    stavke.Clear();
                    foreach (StavkaAngazovanja stavka in lista)
                    {
                        stavke.Add(stavka);
                        ukupanIznos1 += stavka.UkupnaCena;
                    }
                    frmIzmeniAngazovanje.DgvStavkeA.DataSource = stavke;
                    frmIzmeniAngazovanje.TxtUkupanIznos.Text = ukupanIznos1.ToString() + " " + valuta1;
                } MessageBox.Show("Sistem je ucitao izabrano angazovanje!");
            }
        }

        private void PretraziAngazovanja(object sender, EventArgs e)
        {

            string text = frmIzmeniAngazovanje.TxtImeRadnika.Text;

          List<Angazovanje>  angazovanja = Communication.Instance.PretraziAngazovanja(text);
            if (angazovanja.Count == 0)
            {
                MessageBox.Show("Nema angažovanja za tog radnika!");
                return;
            }
            frmIzmeniAngazovanje.DgvAngazovanja.DataSource = angazovanja;
            MessageBox.Show("Sistem je ucitao angažovanja po zadatom kriterijumu");
        }

        private void RefreshPrikaz()
        {
            List<StavkaCenovnika> stavkeC = Communication.Instance.UcitajSveStavkeCenovnika();
            frmIzmeniAngazovanje.DgvCenovnik.DataSource = stavkeC;
    
            Array tipovi = Enum.GetValues(typeof(TipAngazovanja));

            // Dodajte kategorije u ComboBox
            foreach (TipAngazovanja tip in tipovi)
            {
                frmIzmeniAngazovanje.ComboBox1.Items.Add(tip);
            }
            frmIzmeniAngazovanje.DgvAngazovanja.DataSource = Communication.Instance.UcitajSvaAngazovanja();
            frmIzmeniAngazovanje.DgvAngazovanja.Refresh();
        }

        private void obradiAkcije()
        {
            frmDodajAngazovanje.BtnDodajStavku.Click += DodajStavku;
            frmDodajAngazovanje.BtnPretragaCenovnik1.Click += PretraziCenovnik;
            frmDodajAngazovanje.BtnObrisiStavku.Click += ObrisiStavku;
            frmDodajAngazovanje.ButtonSacuvaj.Click += SacuvajAngazovanje;
        }

        private void PretraziCenovnik(object sender, EventArgs e)
        {
            List<StavkaCenovnika> stavkeC = Communication.Instance.UcitajSveStavkeCenovnika();
            List<StavkaCenovnika> noveStavke = new List<StavkaCenovnika>();
            string imeDekor = frmDodajAngazovanje.TxtDeko.Text;
            foreach(StavkaCenovnika sc in stavkeC)
            {
                if (sc.Dekoracija.ToString().Contains(imeDekor))
                {
                    noveStavke.Add(sc);
                }
            }
            frmDodajAngazovanje.DataGridView4.DataSource = noveStavke;

        }

        private void PretraziCenovnik1(object sender, EventArgs e)
        {
            List<StavkaCenovnika> stavkeC = Communication.Instance.UcitajSveStavkeCenovnika();
            List<StavkaCenovnika> noveStavke = new List<StavkaCenovnika>();
            string imeDekor = frmIzmeniAngazovanje.TxtDekoracija.Text;
            foreach (StavkaCenovnika sc in stavkeC)
            {
                if (sc.Dekoracija.ToString().Contains(imeDekor))
                {
                    noveStavke.Add(sc);
                }
            }
            frmIzmeniAngazovanje.DgvCenovnik.DataSource = noveStavke;

        }

        private void SacuvajAngazovanje(object sender, EventArgs e)
        {
            if (frmDodajAngazovanje.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = frmDodajAngazovanje.DataGridView1.SelectedRows[0];


                if (selectedRow.DataBoundItem is Domain.Radnik selectedRadnik)
                {

                    angazovanje.Radnik = selectedRadnik;
                }
            }
            else
            {
                MessageBox.Show("Izaberite radnika!");
                return;
            }
            if (frmDodajAngazovanje.DataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = frmDodajAngazovanje.DataGridView2.SelectedRows[0];


                if (selectedRow.DataBoundItem is Lokal selectedLokal)
                {

                    angazovanje.Lokal = selectedLokal;
                }
            }
            else
            {
                MessageBox.Show("Izaberite lokal!");
                return;
            }
            if (frmDodajAngazovanje.ComboBox1.SelectedIndex != -1)
            {
                angazovanje.TipAngazovanja = (TipAngazovanja)frmDodajAngazovanje.ComboBox1.SelectedItem;
            }
            else
            {
                MessageBox.Show("Morate izabrati tip angažovanja!");
                return;
            }
            if (string.IsNullOrWhiteSpace(frmDodajAngazovanje.TxtDatum.Text))
            {
                MessageBox.Show("Unesite datum!");
                return;
            }

            DateTime datum;

            if (!DateTime.TryParse(frmDodajAngazovanje.TxtDatum.Text, out datum))
            {
                MessageBox.Show("Neispravan format datuma! Unesite datum u formatu: DD-MM-YYYY");
                return;
            }
     
            angazovanje.DatumObavljanja = datum;

            if (string.IsNullOrWhiteSpace(frmDodajAngazovanje.TxtVreme.Text))
            {
                MessageBox.Show("Unesite vreme!");
                return;
            }
            try
            {
                string input = frmDodajAngazovanje.TxtVreme.Text;
                TimeSpan parsedTime;
                if (TimeSpan.TryParse(input, out parsedTime))
                {
                    angazovanje.VremeObavljanja = parsedTime;
                    Console.WriteLine(angazovanje.VremeObavljanja);
                }
                else
                {
                    MessageBox.Show("Pogrešan format vremena. Unesite vreme u formatu:HH:MM");
                    return;
                }
            }


            catch (Exception ex)
            {

                Console.WriteLine("Greska kod vremena u terminu" + ex.Message);
            }

            foreach (Domain.StavkaAngazovanja s in stavke)
            {

                angazovanje.StavkaAngazovanja.Add(s);

            }


            try
            {
                Communication.Instance.SacuvajAngazovanje(angazovanje);
                MessageBox.Show("Angazovanje je kreirano!");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti angažovanje!");
            }

        }
        double ukupanIznos = 0;
        string valuta = "";
        private FrmIzmeniAngazovanje frmIzmeniAngazovanje;

        private void ObrisiStavku(object sender, EventArgs e)
    {
        if (frmDodajAngazovanje.DataGridView3.SelectedRows.Count > 0)
        {
            DataGridViewRow obj = frmDodajAngazovanje.DataGridView3.SelectedRows[0];
            if (obj.DataBoundItem is Domain.StavkaAngazovanja t)
            {
                    
                stavke.Remove(t);
                ukupanIznos -= t.UkupnaCena;
                frmDodajAngazovanje.TxtUkupanIznos.Text = ukupanIznos.ToString()+" "+valuta;
                frmDodajAngazovanje.DataGridView3.Refresh();
            }
        }
    }
        double ukupanIznos1 = 0;
        string valuta1 = "";

        private void ObrisiStavku1(object sender, EventArgs e)
        {
            if (frmIzmeniAngazovanje.DgvStavkeA.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmeniAngazovanje.DgvStavkeA.SelectedRows[0];
                if (obj.DataBoundItem is Domain.StavkaAngazovanja t)
                {

                    stavke.Remove(t);
                    ukupanIznos1 -= t.UkupnaCena;
                    frmIzmeniAngazovanje.TxtUkupanIznos.Text = ukupanIznos1.ToString() + " " + valuta1;
                    frmIzmeniAngazovanje.DgvStavkeA.Refresh();
                }
            }
        }
        private void DodajStavku(object sender, EventArgs e)
    {
            Domain.StavkaAngazovanja sa = new Domain.StavkaAngazovanja();
            if (!string.IsNullOrWhiteSpace(frmDodajAngazovanje.TxtKolicina.Text))
            {
                sa.Kolicina = Convert.ToInt32(frmDodajAngazovanje.TxtKolicina.Text);
            } else
            {
                MessageBox.Show("Niste uneli kolicinu!");
                return;
            }
         
           


        if (frmDodajAngazovanje.DataGridView4.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = frmDodajAngazovanje.DataGridView4.SelectedRows[0];


            if (selectedRow.DataBoundItem is StavkaCenovnika selectedStavka)
            {

                stavka = selectedStavka;

                    frmDodajAngazovanje.TxtCena.Text = stavka.CenaSaPDV.ToString();
                    // Postavljamo sve kolone kao samo za čitanje
                    foreach (DataGridViewColumn column in frmDodajAngazovanje.DataGridView3.Columns)
                    {
                        column.ReadOnly = true;             
                    }

 
                    frmDodajAngazovanje.DataGridView3.Columns["kolicina"].ReadOnly = false;
                    valuta = stavka.Valuta.ToString();
                }
            }
        else
        {
            MessageBox.Show("Izaberite stavku cenovnika!");
                return;
        }

        sa.CenaSaPDV = stavka.CenaSaPDV;
        sa.UkupnaCena = (double)sa.CenaSaPDV * sa.Kolicina;
        sa.Dekoracija = stavka.Dekoracija;

        stavke.Add(sa);
        frmDodajAngazovanje.DataGridView3.Refresh();

            ukupanIznos += sa.UkupnaCena;
            frmDodajAngazovanje.TxtUkupanIznos.Text = ukupanIznos.ToString()+" "+valuta;
        }


        private void DodajStavku1(object sender, EventArgs e)
        {
            Domain.StavkaAngazovanja sa = new Domain.StavkaAngazovanja();
            if (!string.IsNullOrWhiteSpace(frmIzmeniAngazovanje.TxtKolicina.Text))
            {
                sa.Kolicina = Convert.ToInt32(frmIzmeniAngazovanje.TxtKolicina.Text);
            }
            else
            {
                MessageBox.Show("Niste uneli kolicinu!");
                return;
            }

            if (frmIzmeniAngazovanje.DgvCenovnik.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = frmIzmeniAngazovanje.DgvCenovnik.SelectedRows[0];


                if (selectedRow.DataBoundItem is StavkaCenovnika selectedStavka)
                {

                    stavka = selectedStavka;

                    frmIzmeniAngazovanje.TxtPdv.Text = stavka.CenaSaPDV.ToString();
                    valuta1 = stavka.Valuta.ToString();
                }
            }
            else
            {
                MessageBox.Show("Izaberite stavku cenovnika!");

            }

            sa.CenaSaPDV = stavka.CenaSaPDV;
            sa.UkupnaCena = (double)sa.CenaSaPDV * sa.Kolicina;
            sa.Dekoracija = stavka.Dekoracija;

            stavke.Add(sa);
            frmIzmeniAngazovanje.DgvStavkeA.Refresh();

            ukupanIznos1 += sa.UkupnaCena;
            frmIzmeniAngazovanje.TxtUkupanIznos.Text = ukupanIznos1.ToString() + " " + valuta1;
        }
        private void popuniFormu()
    {
        List<StavkaCenovnika> stavkeC = Communication.Instance.UcitajSveStavkeCenovnika();
        frmDodajAngazovanje.DataGridView4.DataSource = stavkeC;
        frmDodajAngazovanje.DataGridView3.DataSource = stavke;
        frmDodajAngazovanje.DataGridView1.DataSource = Communication.Instance.UcitajSveRadnike();
        frmDodajAngazovanje.DataGridView2.DataSource = Communication.Instance.UcitajSveLokale();

        Array tipovi = Enum.GetValues(typeof(TipAngazovanja));

        // Dodajte kategorije u ComboBox
        foreach (TipAngazovanja tip in tipovi)
        {
            frmDodajAngazovanje.ComboBox1.Items.Add(tip);
        }
    }
}
}
