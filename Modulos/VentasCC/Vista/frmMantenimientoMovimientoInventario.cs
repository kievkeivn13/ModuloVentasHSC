using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorMVentasCC;

namespace CapaVistaMVentasCC
{
	public partial class frmMantenimientoMovimientoInventario : Form
	{
		ControladorMovimientoInventario cn = new ControladorMovimientoInventario();
		public frmMantenimientoMovimientoInventario()
		{
			InitializeComponent();
			INVMostarMovimientos();
		}
		public void INVMostarMovimientos()
		{
			DataTable dt = cn.INVMostarMovimientos();
			dtgMovimiento.DataSource = dt;
		}

		private void btnIngresar_Click(object sender, EventArgs e)
        {
			INVMostarMovimientos();
		}
    }
}
