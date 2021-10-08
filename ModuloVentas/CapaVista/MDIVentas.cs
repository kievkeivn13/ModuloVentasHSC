using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
	public partial class MDIVentas : Form
	{
		public MDIVentas()
		{
			InitializeComponent();
			CenterToScreen();
			this.WindowState = FormWindowState.Maximized;
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
