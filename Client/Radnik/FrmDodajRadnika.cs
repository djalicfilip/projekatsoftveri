using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Radnik
{
    public partial class FrmDodajRadnika : Form
    {
        RadnikController radnikController;
        public FrmDodajRadnika()
        {
            InitializeComponent();
            radnikController=new RadnikController(this);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
