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
using BitacoraUsuario;


namespace CapaVistaMVentasCC
{
    public partial class frmMovimientosCC : Form
    {
        //Ashly Barrios 9959-18-649
        ControladorCC con = new ControladorCC();
        Bitacora loggear = new Bitacora();
        public Boolean permisoIngreso = true;  //Valor que debe llegar de seguridad
        public Boolean permisoModificar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoEliminar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoConsultar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoReporteador = true;  //Valor que debe llegar de seguridad
        public frmMovimientosCC()
        {
            InitializeComponent();
            llenarcbxCliente();
            llenarcbxFraccionamiento();
            llenarcbxTipoDocumento();
            llenarcbxFormaPago();
            llenarcbxCaja();
            llenarcbxMoneda();
            llenarcbxBanco();
            llenarcbxCuentaBancaria();
            llenarcbxMora();
            actualizardatagriew("CuentasPorCobrar", dtgCuentas);

            CenterToScreen();


        }
        //funcion limpiar
        public void actualizardatagriew(string tabla1, DataGridView dtg1)
        {
            DataTable dt = con.llenarDataGrid(tabla1);
            dtg1.DataSource = dt;
           
        }
        private void funLimpiar()
        {
            txtAbono.Text = "";
            txtFaltantemonto.Text = "";
            txtFkbanco.Text = "";
            txtFkcaja.Text = "";
            txtFkcliente.Text = "";
            txtFkcuentabancaria.Text = "";
            txtFkformapago.Text = "";
            txtFkfraccionamiento.Text = "";
            txtFkmoneda.Text = "";
            txtFkmora.Text = "";
            txtFktipodocumento.Text = "";
            txtPkid.Text = "";
            txtTotalmonto.Text = "";

            cbxFkbanco.SelectedIndex = 0;
            cbxFkcaja.SelectedIndex = 0;
            cbxFkcliente.SelectedIndex = 0;
            cbxFkcuentabancaria.SelectedIndex = 0;
            cbxFkformapago.SelectedIndex = 0;
            cbxFkfraccionamiento.SelectedIndex = 0;
            cbxFkmoneda.SelectedIndex = 0;
            cbxFkmora.SelectedIndex = 0;
            cbxFktipodocumento.SelectedIndex = 0;
        }

        //Llenando combobox 
        public void llenarcbxCliente()
        {
            try
            {
                cbxFkcliente.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxCliente();
                cbxFkcliente.Items.Add("Selecione un Cliente");
                while (datareader.Read())
                {
                    cbxFkcliente.Items.Add(datareader[0].ToString());
                }
                cbxFkcliente.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        public void llenarcbxFraccionamiento()
        {
            try
            {
                cbxFkfraccionamiento.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxFraccionamiento();
                cbxFkfraccionamiento.Items.Add("Selecione un Fraccionamiento");
                while (datareader.Read())
                {
                    cbxFkfraccionamiento.Items.Add(datareader[0].ToString());
                }
                cbxFkfraccionamiento.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxTipoDocumento()
        {
            try
            {
                cbxFktipodocumento.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxTipoDocumento();
                cbxFktipodocumento.Items.Add("Selecione un tipo documento");
                while (datareader.Read())
                {
                    cbxFktipodocumento.Items.Add(datareader[0].ToString());
                }
                cbxFktipodocumento.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxFormaPago()
        {
            try
            {
                cbxFkformapago.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxFormaPago();
                cbxFkformapago.Items.Add("Selecione una forma de pago");
                while (datareader.Read())
                {
                    cbxFkformapago.Items.Add(datareader[0].ToString());
                }
                cbxFkformapago.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxCaja()
        {
            try
            {
                cbxFkcaja.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxCaja();
                cbxFkcaja.Items.Add("Selecione una caja");
                while (datareader.Read())
                {
                    cbxFkcaja.Items.Add(datareader[0].ToString());
                }
                cbxFkcaja.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxMoneda()
        {
            try
            {
                cbxFkmoneda.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxMoneda();
                cbxFkmoneda.Items.Add("Selecione una moneda");
                while (datareader.Read())
                {
                    cbxFkmoneda.Items.Add(datareader[0].ToString());
                }
                cbxFkmoneda.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxBanco()
        {
            try
            {
                cbxFkbanco.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxBanco();
                cbxFkbanco.Items.Add("Selecione un banco");
                while (datareader.Read())
                {
                    cbxFkbanco.Items.Add(datareader[0].ToString());
                }
                cbxFkbanco.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxCuentaBancaria()
        {
            try
            {
                cbxFkcuentabancaria.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxCuentaBancaria();
                cbxFkcuentabancaria.Items.Add("Selecione una cuenta bancaria");
                while (datareader.Read())
                {
                    cbxFkcuentabancaria.Items.Add(datareader[0].ToString());
                }
                cbxFkcuentabancaria.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxMora()
        {
            try
            {
                cbxFkmora.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxMora();
                cbxFkmora.Items.Add("Selecione un tipo de mora");
                while (datareader.Read())
                {
                    cbxFkmora.Items.Add(datareader[0].ToString());
                }
                cbxFkmora.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        //Consulta para traer el id
        public string consultaCliente(string nombre)
        {
            string id = con.consultaCliente(nombre);

            return id;
        }
        public string consultaFraccionamiento(string nombre)
        {
            string id = con.consultaFraccionamiento(nombre);

            return id;
        }
        public string consultaTipoDocumento(string nombre)
        {
            string id = con.consultaTipoDocumento(nombre);

            return id;
        }
        public string consultaFormaPago(string nombre)
        {
            string id = con.consultaFormaPago(nombre);

            return id;
        }
        public string consultaCaja(string nombre)
        {
            string id = con.consultaCaja(nombre);

            return id;
        }
        public string consultaMoneda(string nombre)
        {
            string id = con.consultaMoneda(nombre);

            return id;
        }

        public string consultaBanco(string nombre)
        {
            string id = con.consultaBanco(nombre);

            return id;
        }

        public string consultaCuentaBancaria(string nombre)
        {
            string id = con.consultaCuentaBancaria(nombre);

            return id;
        }

        public string consultaMora(string nombre)
        {
            string id = con.consultaMora(nombre);

            return id;
        }


        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxFkcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkcliente.Text = consultaCliente(cbxFkcliente.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbxFkfraccionamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkfraccionamiento.Text = consultaFraccionamiento(cbxFkfraccionamiento.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbxFktipodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFktipodocumento.Text = consultaTipoDocumento(cbxFktipodocumento.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbxFkformapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkformapago.Text = consultaFormaPago(cbxFkformapago.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

        }

        private void cbxFkcaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkcaja.Text = consultaCaja(cbxFkcaja.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbxFkmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkmoneda.Text = consultaMoneda(cbxFkmoneda.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbxFkbanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkbanco.Text = consultaBanco(cbxFkbanco.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbxFkcuentabancaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkcuentabancaria.Text = consultaCuentaBancaria(cbxFkcuentabancaria.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbxFkmora_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtFkmora.Text = consultaMora(cbxFkmora.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaEmision = dtEmision.Value.ToString("yyyy-MM-dd");
                string fechaVencimiento = dtVencimiento.Value.ToString("yyyy-MM-dd");
                string estatus = "A";
                float Total = float.Parse(txtTotalmonto.Text);
                float Abono = float.Parse(txtAbono.Text);
                float Faltante = Total - Abono;
                con.llamarInsertMCC(txtPkid.Text, txtFkcliente.Text, fechaEmision, fechaVencimiento,txtFkfraccionamiento.Text,txtFktipodocumento.Text,txtFkformapago.Text,txtFkcaja.Text,txtFkmoneda.Text,txtFkbanco.Text,txtFkcuentabancaria.Text,txtFkmora.Text,Total,Faltante,Abono,estatus);
                MessageBox.Show("Insercion realizada");
                funLimpiar();
                actualizardatagriew("CuentasPorCobrar", dtgCuentas);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Debes llenar todos los campos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaEmision = dtEmision.Value.ToString("yyyy-MM-dd");
                string fechaVencimiento = dtVencimiento.Value.ToString("yyyy-MM-dd");
                string estatus;
                float Total = float.Parse(txtTotalmonto.Text);
                float Abono = float.Parse(txtAbono.Text);
                float Faltante = Total - Abono;
                if (Faltante == 0)
                {
                    estatus = "0";
                    con.llamarModifMCC(txtPkid.Text, txtFkcliente.Text, fechaEmision, fechaVencimiento, txtFkfraccionamiento.Text, txtFktipodocumento.Text, txtFkformapago.Text, txtFkcaja.Text, txtFkmoneda.Text, txtFkbanco.Text, txtFkcuentabancaria.Text, txtFkmora.Text, Total, Faltante, Abono, estatus);
                }
                else if(Faltante>0)
                { 
                    estatus = "1";
                    con.llamarModifMCC(txtPkid.Text, txtFkcliente.Text, fechaEmision, fechaVencimiento, txtFkfraccionamiento.Text, txtFktipodocumento.Text, txtFkformapago.Text, txtFkcaja.Text, txtFkmoneda.Text, txtFkbanco.Text, txtFkcuentabancaria.Text, txtFkmora.Text, Total, Faltante, Abono, estatus);
                }
                
                MessageBox.Show("Modificacion realizada");
                funLimpiar();
                actualizardatagriew("CuentasPorCobrar", dtgCuentas);

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.llamarElimMCC(txtPkid.Text);
                MessageBox.Show("Eliminacion realizada");
                funLimpiar();
                actualizardatagriew("CuentasPorCobrar", dtgCuentas);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No has ingresado Id del registro a eliminar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funLimpiar();
            actualizardatagriew("CuentasPorCobrar", dtgCuentas);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReporteador_Click(object sender, EventArgs e)
        {
            ReporteMovimientosCC movimientosCC = new ReporteMovimientosCC();
            movimientosCC.Show();
            //loggear.guardarEnBitacora(IdUsuario, "3101", "3103", "Acceso a Reporte");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizardatagriew("CuentasPorCobrar", dtgCuentas);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}
