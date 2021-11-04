using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmReporteAdm : Form
    {
        public frmReporteAdm()
        {
            InitializeComponent();
        }
        public frmReporteAdm(String texto)
        {
            InitializeComponent();
            textBox1.Text = texto;
            mostrar();
        }
        public void mostrar()
        {
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(textBox1.Text);
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }
    }
}
