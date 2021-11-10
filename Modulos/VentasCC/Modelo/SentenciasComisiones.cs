using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloMVentasCC
{    //Forma y Programación realizada por Kevin Flores requerimiento individual 
    public class SentenciasComisiones
    {
        Conexion cn = new Conexion();
                
        //Comisiones
        public DataTable llenarTabla(string tabla1)// metodo  que obtinene el contenido de una tabla
        {
            DataTable table = new DataTable();
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());

                dataTable.Fill(table);

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            return table;
        }

        public void funLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {

            cbx.DataSource = null;
            cbx.Items.Clear();

            String psql = "SELECT * FROM " + " " + tabla + " " + "WHERE " + " " + estatus + "= 'A' or " + estatus + "= '1' ";
            //cbx.Items.Add(psql);

            OdbcConnection conect = cn.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                OdbcDataAdapter data = new OdbcDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbx.Items.Add("Selecione un elemento").ToString();
                cbx.ValueMember = value;
                cbx.DisplayMember = display;
                cbx.DataSource = dt;
                /*OdbcCommand busI = new OdbcCommand(psql, conect);
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    cbx.Items.Add(lector[0] + " " + lector[1] + " " + lector[2] + " ");
                }*/
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                cn.desconexion(conect);
            }
        }
        public string consultaID(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where nombre= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["pkIdEmpleado"].ToString();
            }
            return id;
        }
        public string consultaFacturaID(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where Pkid= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["Fkidempleado"].ToString();
            }
            return id;
        }
        public string consultaTotal(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where Pkid= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["Total"].ToString();
            }
            return id;
        }
        public string consultaPorcentaje(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where nombre= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["porcentaje"].ToString();
            }
            return id;
        }

        public string consultaIDComision(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where nombre= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["Pkid"].ToString();
            }
            return id;
        }

        public void funLlenarComboFecha(ComboBox cbx, string tabla, string value, string display, string estatus, string fecha)
        {

            cbx.DataSource = null;
            cbx.Items.Clear();
            String psql = "SELECT * FROM " + " " + tabla + " " + "WHERE " + " " + estatus + "= 'A' or " + estatus + "= '1' and Fechaemision like '" + fecha + "-%' ;";
            //cbx.Items.Add(psql);
            // MessageBox.Show(psql);
            OdbcConnection conect = cn.conexion();

            try
            {
                OdbcCommand datos = new OdbcCommand(psql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                cbx.Items.Clear();
                OdbcDataReader datareader = (leer);
                cbx.Items.Add("Selecione un Modulo");
                while (datareader.Read())
                {
                    cbx.Items.Add(datareader[0].ToString());
                }
                cbx.SelectedIndex = 0;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                cn.desconexion(conect);
            }
        }
        public string consultaIdCambio(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where Pkid= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["fkidtipocambio"].ToString();
            }
            return id;
        }
        public string consultaCambio(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where idTipoc= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["cambioTipoC"].ToString();
            }
            return id;
        }

        public void metodoInsertarEncabezado(string id, string idempleado, string comisionmes, string fecha)
        {

            string cadena = "INSERT INTO comisionasignadaencabezado VALUES ('" + id + "','" + idempleado + "','" + comisionmes + "','" + fecha + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public void metodoModifarEncabezado(string id, string idempleado, string comisionesmes, string fecha)
        {
            string cadena = "UPDATE comisionasignadaencabezado SET Fkidempleado = '" + idempleado + "', Comisionesmes= '" + comisionesmes + "', FechaComisiones ='" + fecha + "' WHERE Pkid= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public void metodoEliminarEncabezado(string id)
        {
            string cadena = "DELETE FROM comisionasignadaencabezado WHERE Pkid = '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public DataTable llenarTablaDetalle(string tabla1, string id)// metodo  que obtinene el contenido de una tabla
        {
            DataTable table = new DataTable();
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "select * from " + tabla1 + " where FkidEncabezado= '" + id + "';";
            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
                dataTable.Fill(table);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            return table;
        }

        public void metodoInsertarDetalle(string id, string idencabezado, string idfactura, string idComision, string montofactura, string Cantidadcomision)
        {

            string cadena = "INSERT INTO comisionasignadadetalle VALUES ('" + id + "','" + idencabezado + "','" + idfactura + "','" + idComision + "','" + montofactura + "','" + Cantidadcomision + "');";
            //MessageBox.Show(cadena);
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public void metodoModifarDetalle(string id, string idencabezado, string idfactura, string idComision, string montofactura, string Cantidadcomision)
        {
            string cadena = "UPDATE comisionasignadadetalle SET FkidEncabezado = '" + idencabezado + "', Fkidfactura= '" + idfactura + "', FkidComision ='" + idComision + "', Montofactura= '" + montofactura + "', Cantidadcomision ='" + Cantidadcomision + "' WHERE Pkid= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public void metodoEliminarDetalle(string id)
        {
            string cadena = "DELETE FROM comisionasignadadetalle WHERE Pkid = '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public void metodoEliminarDetalleE(string id)
        {
            string cadena = "DELETE FROM comisionasignadadetalle WHERE FkidEncabezado = '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //funcion para llenar los permisos del usuario sobre la aplicacion
        public string llenarpermisos(string id, string app)
        {
            string Query = "SELECT  *    from   usuarioAplicacion   WHERE fkIdUsuario = " + id + " AND fkIdAplicacion= " + app + ";";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            string cadena = "";
            if (busqueda.Read())
            {
                string escritura = busqueda["permisoEscritura"].ToString();
                string lectura = busqueda["permisoLectura"].ToString();
                string imprimir = busqueda["permisoImprimir"].ToString();
                string eliminar = busqueda["permisoEliminar"].ToString();
                string modificar = busqueda["permisoModificar"].ToString();
                cadena = escritura + lectura + imprimir + eliminar + modificar;
            }
            return cadena;
        }

        //Mantenimiento tipo inventario Heydi Quemé 9959-18-5335

        //Mantenimiento Mora Kevin Flores 9959-18-17632

        //Mantenimiento tipo Documento Kevin Flores 9959-18-17632 
        public void metodoModifarComisionmes(string id, string Cantidadcomision)
        {
            string cadena = "UPDATE comisionasignadaencabezado SET Comisionesmes = '" + Cantidadcomision + "' WHERE Pkid= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public string metodoComisionmes(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where Pkid= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["Comisionesmes"].ToString();
            }
            return id;
        }
        public string metodoComisionmesfac(string nombre, string tabla)
        {
            string id = "";
            string Query = "select * from " + tabla + " where Pkid= '" + nombre + "';";
            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();
            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();
            if (busqueda.Read())
            {
                id = busqueda["Cantidadcomision"].ToString();
            }
            return id;
        }
    }
}
