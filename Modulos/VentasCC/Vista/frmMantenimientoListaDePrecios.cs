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
	public partial class frmMantenimientoListaDePrecios : Form
	{
        ControladorMovimientoInventario cn = new ControladorMovimientoInventario();
        public frmMantenimientoListaDePrecios()
		{
			InitializeComponent();

            try
            {
                Limpiar();
                LISTAllenarcbxInventarios();
                LISTAllenarcbxMarca();
                LISTAllenarcbxLinea();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }


        public void LISTAllenarcbxInventarios()
        {
            DataTable dt = cn.LISTAllenarcbxInventarios();
            cbxTipo.DataSource = dt;
            cbxTipo.DisplayMember = "Nombre";
        }

        public void LISTAllenarcbxMarca()
        {
            DataTable dt = cn.LISTAllenarcbxMarca();
            cbxMarca.DataSource = dt;
            cbxMarca.DisplayMember = "nombre";
        }

        public void LISTAllenarcbxLinea()
        {
            DataTable dt = cn.LISTAllenarcbxLinea();
            cbxLinea.DataSource = dt;
            cbxLinea.DisplayMember = "nombre";
        }


        public void Limpiar()
        {
            try
            {
                rbnGlobal.Checked = false;
                rbnTipo.Checked = false;
                rbnMarca.Checked = false;
                rbnLinea.Checked = false;
                cbxTipo.Visible = false;
                cbxMarca.Visible = false;
                cbxLinea.Visible = false;
                rbnFijo.Checked = false;
                txtiFijo.Text = "";
                rbnDecuento.Checked = false;
                txtDescuento.Text = "";
                rbnAumento.Checked = false;
                txtAumento.Text = "";

                txtiFijo.Visible = false;
                txtDescuento.Visible = false;
                txtAumento.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void rbnCalculoPrecio()
        {

            try
            {
                if (rbnTipo.Checked == true && rbnFijo.Checked == true)
                {
                    string Valor1 = txtiFijo.Text;
                    float Valor = float.Parse(Valor1);
                    string Fktipoinventario = cbxTipo.Text;
                    cn.LISTATipoYFijo(Valor, Fktipoinventario);
                }
                else if (rbnTipo.Checked == true && rbnDecuento.Checked == true)
                {
                    string Valor1 = txtDescuento.Text;
                    float Valor = ((float.Parse(Valor1)) / 100);
                    string Fktipoinventario = cbxTipo.Text;
                    cn.LISTATipoYDescuento(Valor, Fktipoinventario);
                }
                else if (rbnTipo.Checked == true && rbnAumento.Checked == true)
                {
                    string Valor1 = txtAumento.Text;
                    float Valor = (1 + ((float.Parse(Valor1)) / 100));
                    string Fktipoinventario = cbxTipo.Text;
                    cn.LISTATipoYAumento(Valor, Fktipoinventario);
                }
                else if (rbnGlobal.Checked == true && rbnFijo.Checked == true)
                {
                    string Precio1 = txtiFijo.Text;
                    float Precio = float.Parse(Precio1);
                    cn.LISTAGlobalYFijo(Precio);

                }
                else if (rbnGlobal.Checked == true && rbnDecuento.Checked == true)
                {
                    string Precio1 = txtDescuento.Text;
                    float Precio = ((float.Parse(Precio1)) / 100);
                    cn.LISTAGlobalYDescuento(Precio);
                }
                else if (rbnGlobal.Checked == true && rbnAumento.Checked == true)
                {
                    string Precio1 = txtAumento.Text;
                    float Precio = (1 + ((float.Parse(Precio1)) / 100));
                    cn.LISTAGlobalYAumento(Precio);
                }




                else if (rbnMarca.Checked == true && rbnFijo.Checked == true)
                {
                    string Valor1 = txtiFijo.Text;
                    float Valor = float.Parse(Valor1);
                    string Fktipoinventario = txtMarca.Text;
                    cn.LISTAMarcaYFijo(Valor, Fktipoinventario);
                }
                else if (rbnMarca.Checked == true && rbnDecuento.Checked == true)
                {
                    string Valor1 = txtDescuento.Text;
                    float Valor = ((float.Parse(Valor1)) / 100);
                    string Fktipoinventario = txtMarca.Text;
                    cn.LISTAMarcaYDescuento(Valor, Fktipoinventario);
                }
                else if (rbnMarca.Checked == true && rbnAumento.Checked == true)
                {
                    string Valor1 = txtAumento.Text;
                    float Valor = (1 + ((float.Parse(Valor1)) / 100));
                    string Fktipoinventario = txtMarca.Text;
                    cn.LISTAMarcaYAumento(Valor, Fktipoinventario);
                }




                else if (rbnLinea.Checked == true && rbnFijo.Checked == true)
                {
                    string Valor1 = txtiFijo.Text;
                    float Valor = float.Parse(Valor1);
                    string Fktipoinventario = txtLinea.Text;
                    cn.LISTALineaYFijo(Valor, Fktipoinventario);
                }
                else if (rbnLinea.Checked == true && rbnDecuento.Checked == true)
                {
                    string Valor1 = txtDescuento.Text;
                    float Valor = ((float.Parse(Valor1)) / 100);
                    string Fktipoinventario = txtLinea.Text;
                    cn.LISTALineaYDescuento(Valor, Fktipoinventario);
                }
                else if (rbnLinea.Checked == true && rbnAumento.Checked == true)
                {
                    string Valor1 = txtAumento.Text;
                    float Valor = (1 + ((float.Parse(Valor1)) / 100));
                    string Fktipoinventario = txtLinea.Text;
                    cn.LISTALineaYAumento(Valor, Fktipoinventario);
                }







            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            
        }

            public void rbnMostar()
        {
            //rbnGlobal
            //rbnTipo & cbxTipo
            //rbnFijo & txtiFijo
            //rbnDecuento & txtDescuento
            //rbnAumento & txtAumento

            try
            {
                if (rbnTipo.Checked == true)
                {
                    cbxTipo.Visible = true;
                    cbxMarca.Visible = false;
                    cbxLinea.Visible = false;

                }
                else if (rbnMarca.Checked == true)
                {
                    cbxTipo.Visible = false;
                    cbxMarca.Visible = true;
                    cbxLinea.Visible = false;
                }
                else if (rbnLinea.Checked == true)
                {
                    cbxTipo.Visible = false;
                    cbxMarca.Visible = false;
                    cbxLinea.Visible = true;
                }
                else if (rbnGlobal.Checked == true)
                {
                    cbxTipo.Visible = false;
                    cbxMarca.Visible = false;
                    cbxLinea.Visible = false;
                }



                if (rbnFijo.Checked == true)
                {
                    txtiFijo.Visible = true;

                }
                else if (rbnFijo.Checked == false)
                {
                    txtiFijo.Visible = false;
                }

                if (rbnDecuento.Checked == true)
                {
                    txtDescuento.Visible = true;

                }
                else if (rbnDecuento.Checked == false)
                {
                    txtDescuento.Visible = false;
                }

                if (rbnAumento.Checked == true)
                {
                    txtAumento.Visible = true;

                }
                else if (rbnAumento.Checked == false)
                {
                    txtAumento.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                rbnCalculoPrecio();

                string message = "Precio Modificado";
                MessageBox.Show(message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

        private void rbnGlobal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rbnMostar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void rbnTipo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rbnMostar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void rbnFijo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rbnMostar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void rbnDecuento_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rbnMostar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void rbnAumento_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rbnMostar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rbnMostar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void rbnLinea_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rbnMostar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IndexMarca = (cbxMarca.SelectedIndex + 1).ToString();
            txtMarca.Text = IndexMarca;
        }

        private void cbxLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IndexLinea = (cbxLinea.SelectedIndex + 1).ToString();
            txtLinea.Text = IndexLinea;
        }
    }
}
