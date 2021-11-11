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
	public partial class frmMantenimientoInventario : Form
	{
		ControladorMovimientoInventario cn = new ControladorMovimientoInventario();

		public frmMantenimientoInventario()
		{
			InitializeComponent();
			CenterToScreen();
			//INVMostarInventarios();
			//llenarcbxPerfil();
			//llenarcbxMarca();
			//llenarcbxLinea();

			TextBox[] alias = navegador1.funAsignandoTexts(this);
			navegador1.funAsignarAliasVista(alias, "Inventario", "moduloventas");
			navegador1.funAsignarSalidadVista(this);

			navegador1.campoEstado = "estatus";

			navegador1.idAplicacion = "1";

			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";

			navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

			navegador1.pideGrid(dtgInventario);
			navegador1.llenaTabla();

			navegador1.pedirRef(this);

			navegador1.funLlenarComboControl(cbxTipoinventario, "TipoInventario", "Pkid", "Nombre", "estatus");
			navegador1.funLlenarComboControl(cbxMarca, "Marca", "id_marca", "nombre", "estatus");
			navegador1.funLlenarComboControl(cbxLinea, "Linea", "id_linea", "nombre", "estatus");

		}

		public void INVMostarInventarios()
		{
			/*
			DataTable dt = cn.INVMostarInventarios();
			dtgInventario.DataSource = dt;
			*/
		}
		public void llenarcbxPerfil()
		{
			/*
			try
			{
				cbxTipoinventario.Items.Clear();
				OdbcDataReader datareader = cn.INVllenarcbxTipoInventarios();
				//cbxTipoinventario.Items.Add("");
				while (datareader.Read())
				{
					cbxTipoinventario.Items.Add(datareader[0].ToString());
				}
				cbxTipoinventario.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			*/
		}

		public void llenarcbxMarca()
		{
			/*
			try
			{
				cbxMarca.Items.Clear();
				OdbcDataReader datareader = cn.INVllenarcbxMarca();
				//cbxTipoinventario.Items.Add("");
				while (datareader.Read())
				{
					cbxMarca.Items.Add(datareader[0].ToString());
				}
				cbxMarca.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			*/
		}

		public void llenarcbxLinea()
		{
			/*
			try
			{
				cbxLinea.Items.Clear();
				OdbcDataReader datareader = cn.INVllenarcbxLinea();
				//cbxTipoinventario.Items.Add("");
				while (datareader.Read())
				{
					cbxLinea.Items.Add(datareader[0].ToString());
				}
				cbxLinea.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			*/
		}


		public void INVObtenerIdTipoInventario()
		{
			/*
			string TipoInventario = cbxTipoinventario.Text;
			DataTable dt = cn.INVObtenerIdTipoInventario(TipoInventario);
			string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
			txtIdTipoInv.Text = dta;
			*/
		}

		public void INVObtenerIdMarca()
		{
			/*
			string Marca = cbxMarca.Text;
			DataTable dt = cn.INVObtenerIdMarca(Marca);
			string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
			txtMarca.Text = dta;
			*/
		}

		public void INVObtenerIdLinea()
		{
			/*
			string Linea = cbxLinea.Text;
			DataTable dt = cn.INVObtenerIdLinea(Linea);
			string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
			txtLinea.Text = dta;
			*/
		}


		private void frmMantenimientoInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
			/*
			string Pkid = txtidinventario.Text;
			string Nombre = txtnombreinventario.Text;
			INVObtenerIdTipoInventario();
			string Fktipoinventario = txtIdTipoInv.Text;
			INVObtenerIdMarca();
			string Fkidmarcas = txtMarca.Text;
			INVObtenerIdLinea();
			string Fkidlinea = txtLinea.Text;
			string Stock1 = txtstockinventario.Text;
			int Stock = int.Parse(Stock1);
			string Costo1 = txtcostoinventario.Text;
			float Costo = float.Parse(Costo1);
			string Precio1 = txtprecioinventario.Text;
			float Precio = float.Parse(Precio1);
			string Estatus = "0";
			if (rbnActivo.Checked == true)
			{
				rbnActivo.Checked = true;
				Estatus = "1";
				
			}
			else if (rbnInactivo.Checked == true)
			{
				rbnInactivo.Checked = true;
				Estatus = "0";
				
			}
			cn.INVInsertarInventarios(Pkid, Nombre, Fktipoinventario, Fkidmarcas, Fkidlinea, Stock, Costo, Precio, Estatus);

			INVMostarInventarios();

			*/
		}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
			/*
			txtidinventario.Text="";
			txtnombreinventario.Text = "";
			txtIdTipoInv.Text = "";
			txtMarca.Text = "";
			txtLinea.Text = "";
			txtstockinventario.Text = "";
			txtcostoinventario.Text = "";
			txtprecioinventario.Text = "";
			rbnActivo.Checked = true;
			rbnInactivo.Checked = false;
			*/
		}

        private void dtgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			


		}

        private void dtgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			/*
			txtidinventario.Text = dtgInventario.CurrentRow.Cells[0].Value.ToString();
			txtnombreinventario.Text = dtgInventario.CurrentRow.Cells[1].Value.ToString();
			txtIdTipoInv.Text = dtgInventario.CurrentRow.Cells[2].Value.ToString();
			txtMarca.Text = dtgInventario.CurrentRow.Cells[3].Value.ToString();
			txtLinea.Text = dtgInventario.CurrentRow.Cells[4].Value.ToString();
			txtstockinventario.Text = dtgInventario.CurrentRow.Cells[5].Value.ToString();
			txtcostoinventario.Text = dtgInventario.CurrentRow.Cells[6].Value.ToString();
			txtprecioinventario.Text = dtgInventario.CurrentRow.Cells[7].Value.ToString();

			string ayuda3 = dtgInventario.CurrentRow.Cells[2].Value.ToString();
			int ayuda4 =  int.Parse(ayuda3)-1;
			cbxTipoinventario.SelectedIndex = ayuda4;
			txtIdTipoInv.Text = ayuda3;

			string ayuda5 = dtgInventario.CurrentRow.Cells[3].Value.ToString();
			int ayuda6 = int.Parse(ayuda3) - 1;
			cbxMarca.SelectedIndex = ayuda4;
			txtMarca.Text = ayuda3;

			string ayuda7 = dtgInventario.CurrentRow.Cells[4].Value.ToString();
			int ayuda8 = int.Parse(ayuda3) - 1;
			cbxLinea.SelectedIndex = ayuda4;
			txtLinea.Text = ayuda3;

			string ayuda = dtgInventario.CurrentRow.Cells[8].Value.ToString();
			string ayuda2 = "1";
			if (ayuda.CompareTo(ayuda2) == 0)
            {
				rbnActivo.Checked = true;
				rbnInactivo.Checked = false;
			}else if (ayuda.CompareTo(ayuda2) != 0)
			{
				rbnActivo.Checked = false;
				rbnInactivo.Checked = true;
			}
			*/
		}

		private void btnModificar_Click(object sender, EventArgs e)
        {
			/*
			string Pkid = txtidinventario.Text;
			string Nombre = txtnombreinventario.Text;
			INVObtenerIdTipoInventario();
			string Fktipoinventario = txtIdTipoInv.Text;
			INVObtenerIdMarca();
			string Fkidmarcas = txtMarca.Text;
			INVObtenerIdLinea();
			string Fkidlinea = txtLinea.Text;
			string Stock1 = txtstockinventario.Text;
			int Stock = int.Parse(Stock1);
			string Costo1 = txtcostoinventario.Text;
			float Costo = float.Parse(Costo1);
			string Precio1 = txtprecioinventario.Text;
			float Precio = float.Parse(Precio1);
			string Estatus = "0";
			if (rbnActivo.Checked == true)
			{
				rbnActivo.Checked = true;
				Estatus = "1";

			}
			else if (rbnInactivo.Checked == true)
			{
				rbnInactivo.Checked = true;
				Estatus = "0";

			}
			cn.INVActualizarInventarios(Pkid, Nombre, Fktipoinventario, Fkidmarcas, Fkidlinea, Stock, Costo, Precio, Estatus);

			INVMostarInventarios();
			*/
		}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			/*
			string Pkid = txtidinventario.Text;
			cn.INVBorrarInventarios(Pkid);
			INVMostarInventarios();
			*/
		}

        private void rbnActivo_CheckedChanged(object sender, EventArgs e)
        {
			/*
			if (rbnActivo.Checked == true)
			{
				textEstado.Text = "1";

			}
			else if (rbnInactivo.Checked == true)
			{
				textEstado.Text = "0";

			}
			*/
		}

		//Navegador
        private void dtgInventario_SelectionChanged(object sender, EventArgs e)
        {
			navegador1.funSeleccionarDTVista(dtgInventario);
		}

        private void rbnActivo_MouseClick(object sender, MouseEventArgs e)
        {
			navegador1.funCambioEstatusRBVista(textEstado, rbnActivo, "A");
		}

        private void rbnInactivo_MouseClick(object sender, MouseEventArgs e)
        {
			navegador1.funCambioEstatusRBVista(textEstado, rbnInactivo, "I");
		}

        private void textEstado_TextChanged(object sender, EventArgs e)
        {
			navegador1.funSetearRBVista(rbnActivo, rbnInactivo, textEstado);
		}

        private void cbxTipoinventario_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.funComboTextboxVista(cbxTipoinventario, txtIdTipoInv);
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.funComboTextboxVista(cbxMarca, txtMarca);
		}

        private void cbxLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.funComboTextboxVista(cbxLinea, txtLinea);
		}
    }
}
