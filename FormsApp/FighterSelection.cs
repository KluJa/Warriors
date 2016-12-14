using Pretorians;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class FighterSelection : Form
    {
        public FighterSelection()
        {
            InitializeComponent();
        }

        public Pretorian radioPretorian_Click(object sender, EventArgs e)
        {
            return new Pretorian();
        }

        private void radioMag_Click(object sender, EventArgs e)
        {

        }
    }
}
