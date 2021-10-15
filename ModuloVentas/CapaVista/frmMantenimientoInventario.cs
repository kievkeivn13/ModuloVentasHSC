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

namespace CapaVista
{
	public partial class frmMantenimientoInventario : Form
	{
		Controlador cn = new Controlador();

		public frmMantenimientoInventario()
		{
			InitializeComponent();
			CenterToScreen();
			INVMostarInventarios();
			llenarcbxPerfil();
		}

		public void INVMostarInventarios()
		{
			DataTable dt = cn.INVMostarInventarios();
			dtgInventario.DataSource = dt;
		}
		public void llenarcbxPerfil()
		{
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
		}


		public void INVObtenerIdTipoInventario()
		{
			string TipoInventario = cbxTipoinventario.Text;
			DataTable dt = cn.INVObtenerIdTipoInventario(TipoInventario);
			string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
			txtIdTipoInv.Text = dta;
		}



		private void frmMantenimientoInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
			string Pkid = txtidinventario.Text;
			string Nombre = txtnombreinventario.Text;
			INVObtenerIdTipoInventario();
			string Fktipoinventario = txtIdTipoInv.Text;
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
			cn.INVInsertarInventarios(Pkid, Nombre, Fktipoinventario, Stock, Costo, Precio, Estatus);

			INVMostarInventarios();


		}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
			txtidinventario.Text="";
			txtnombreinventario.Text = "";
			txtIdTipoInv.Text = "";
			txtstockinventario.Text = "";
			txtcostoinventario.Text = "";
			txtprecioinventario.Text = "";
			rbnInactivo.Checked = true;
			rbnInactivo.Checked = false;
		}

        private void dtgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
			txtidinventario.Text = dtgInventario.CurrentRow.Cells[0].Value.ToString();

		}

        private void dtgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			txtidinventario.Text = dtgInventario.CurrentRow.Cells[0].Value.ToString();
		}
    }
}
