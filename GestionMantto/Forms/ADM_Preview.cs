using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantto.Forms
{
    public partial class ADM_Preview : Form
    {
        public Image  Origen;
        public ADM_Preview()
        {
            InitializeComponent();
        }

        private void ADM_Preview_Load(object sender, EventArgs e)
        {
            vistaprevia.Image = Origen;
        }

        private void vistaprevia_Click(object sender, EventArgs e)
        {

        }
    }
}
