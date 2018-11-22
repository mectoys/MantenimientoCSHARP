using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace GestionMantto.Reportes
{
    public partial class reportes : Form
    {
        public ReportDocument cryRpt = new ReportDocument();

        public reportes()
        {
            InitializeComponent();
        }

        private void reportes_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cryRpt;
        }
    }
}
