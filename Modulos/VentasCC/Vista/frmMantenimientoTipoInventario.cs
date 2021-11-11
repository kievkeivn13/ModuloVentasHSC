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

namespace CapaVistaMVentasCC
{
	public partial class frmMantenimientoTipoInventario : Form
	{
		ControladorMovimientoInventario cn = new ControladorMovimientoInventario();
		public frmMantenimientoTipoInventario()
		{
			InitializeComponent();
			CenterToScreen();
			//INVMostarTipoInventarios();

			TextBox[] alias = navegador1.funAsignandoTexts(this);
			navegador1.funAsignarAliasVista(alias, "TipoInventario", "moduloventas");
			navegador1.funAsignarSalidadVista(this);

			navegador1.campoEstado = "estatus";

			navegador1.idAplicacion = "1";

			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";

			navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

			navegador1.pideGrid(dtgTipoInventario);
			navegador1.llenaTabla();

			navegador1.pedirRef(this);
		}

		public void INVMostarTipoInventarios()
		{
			/*
			DataTable dt = cn.INVMostarTipoInventarios();
			dtgTipoInventario.DataSource = dt;
			*/
		}


		private void btnIngresar_Click(object sender, EventArgs e)
        {
			/*
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
			*/
		}

        private void dtgTipoInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			/*
			txtidtinventario.Text = dtgTipoInventario.CurrentRow.Cells[0].Value.ToString();
			txtnombretinventario.Text = dtgTipoInventario.CurrentRow.Cells[1].Value.ToString();

			string ayuda = dtgTipoInventario.CurrentRow.Cells[2].Value.ToString();
			string ayuda2 = "1";
			if (ayuda.CompareTo(ayuda2) == 0)
			{
				rbnHabilitado.Checked = true;
				rbnInhabilitado.Checked = false;
			}
			else if (ayuda.CompareTo(ayuda2) != 0)
			{
				rbnHabilitado.Checked = false;
				rbnInhabilitado.Checked = true;
			}
			*/

		}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
			/*
			txtidtinventario.Text="";
			txtnombretinventario.Text="";
			rbnHabilitado.Checked = true;
			rbnInhabilitado.Checked = false;
			*/

		}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			/*
			string Pkid = txtidtinventario.Text;
			cn.INVBorrarTipoInventarios(Pkid);
			INVMostarTipoInventarios();
			*/

		}

        private void btnModificar_Click(object sender, EventArgs e)
        {
			/*
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
			cn.INVActualizarTipoInventarios(Pkid, Nombre,  Estatus);

			INVMostarTipoInventarios();
			*/
		}

        private void txtnombretinventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
			if (rbnHabilitado.Checked == true)
			{
				textEstado.Text = "A";

			}
			else if (rbnInhabilitado.Checked == true)
			{
				textEstado.Text = "I";

			}
		}

        private void frmMantenimientoTipoInventario_Load(object sender, EventArgs e)
        {

        }

		//Parametros Navegador

        private void dtgTipoInventario_SelectionChanged(object sender, EventArgs e)
        {
			navegador1.funSeleccionarDTVista(dtgTipoInventario);
        }

        private void rbnHabilitado_MouseClick(object sender, MouseEventArgs e)
        {
			navegador1.funCambioEstatusRBVista(textEstado, rbnHabilitado, "A");
        }

        private void rbnInhabilitado_MouseClick(object sender, MouseEventArgs e)
        {
			navegador1.funCambioEstatusRBVista(textEstado, rbnInhabilitado, "I");
		}

        private void textEstado_TextChanged(object sender, EventArgs e)
        {
			navegador1.funSetearRBVista(rbnHabilitado, rbnInhabilitado, textEstado);
        }
    }
}
