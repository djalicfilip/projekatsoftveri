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
    public partial class FrmObrisiRadnika : Form
    {
        private RadnikController controller; 
        public FrmObrisiRadnika()
        {
            InitializeComponent();
            controller = new RadnikController(this);
        }
    }
}
