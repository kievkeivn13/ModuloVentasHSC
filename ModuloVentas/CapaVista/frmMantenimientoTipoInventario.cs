using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorMVentasCC;

namespace CapaVista
{
	public partial class frmMantenimientoTipoInventario : Form
	{
		Controlador cn = new Controlador();
		public frmMantenimientoTipoInventario()
		{
			InitializeComponent();
			CenterToScreen();
			INVMostarTipoInventarios();
		}

		public void INVMostarTipoInventarios()
		{
			DataTable dt = cn.INVMostarTipoInventarios();
			dtgTipoInventario.DataSource = dt;
		}


		private void btnIngresar_Click(object sender, EventArgs e)
        {
			string Pkid = txtidtinventario.Text;
			string Nombre = txtnombretinventario.Text;
			string Estatus = "0";
			if (rbnHabilitado.Checked == true)
			{
				rbnHabilitado.Checked = true;
				Estatus = "1";

			}
			else if (rbnInhabilitado.Checked == true)
			{
				rbnInhabilitado.Checked = true;
				Estatus = "0";

			}
			cn.INVInsertarTipoInventarios(Pkid, Nombre, Estatus);

			INVMostarTipoInventarios();
		}

        private void dtgTipoInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			txtidtinventario.Text = dtgTipoInventario.CurrentRow.Cells[0].Value.ToString();
		}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
			txtidtinventario.Text="";
			txtnombretinventario.Text="";
			rbnHabilitado.Checked = true;
			rbnInhabilitado.Checked = false;

		}
    }
}
