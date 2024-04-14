using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class PrijavaController
    {
        private FrmPrijava frmPrijava;

        public PrijavaController(FrmPrijava frmPrijava)
        {
          
            this.frmPrijava = frmPrijava;
            this.frmPrijava.TextBox1.Text = "filip@filip";
            this.frmPrijava.TextBox2.Text = "filip123";
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            frmPrijava.Button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik k=new Korisnik();
            string username = frmPrijava.TextBox1.Text;
            string password = frmPrijava.TextBox2.Text;



            k.Username = username;
            k.Password = password;

            try
            {
                k = Communication.Instance.Prijava(k);
                if (k != null)
                {
                    FrmController.Instance.korisnik = k;
                    System.Windows.Forms.MessageBox.Show("Uspesno ste se prijavili na sistem!");
                    FrmController.Instance.ShowFrm(new FrmGlavniMeni(k));


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da prijavi korisnika!");
                    return;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska kod prijavacontroller"+ex.Message+ex.StackTrace);
            }

        }
    }
}
