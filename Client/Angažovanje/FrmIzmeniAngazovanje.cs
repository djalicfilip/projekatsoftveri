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
    public partial class FrmIzmeniAngazovanje : Form
    {
        AngazovanjeController controller;
        public FrmIzmeniAngazovanje()
        {
            InitializeComponent();
            controller = new AngazovanjeController(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
