using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Dekoracija
{
    public partial class FrmDodajDekoraciju : Form
    {
        DekoracijaController controller;
        public FrmDodajDekoraciju()
        {
            InitializeComponent();
            controller = new DekoracijaController(this);
        }
    }
}
