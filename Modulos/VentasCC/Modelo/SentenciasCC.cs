using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloMVentasCC
{
	public class SentenciasCC
	{
        Conexion cn = new Conexion();

        //Cuentas por cobrar Ashly Barrios 9959-18-649
        public void funInsertarMCC(string id, string cliente, string emision, string vencimiento, string fraccionamiento, string documento, string pago,string caja,string moneda,string banco,string cuenta,string mora,float total,float faltante,float abono,string estatus)
        {

            string cadena = "INSERT INTO CuentasporCobrar VALUES ('" + id + "','" + cliente + "','" + emision + "','" + vencimiento + "','" + fraccionamiento + "','" + documento + "','" + pago + "','" + caja + "','" + moneda + "','" + banco + "','" + cuenta + "','" + mora + "','" + total + "','" + faltante + "','" + abono + "','" + estatus + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifMCC(string id, string cliente, string emision, string vencimiento, string fraccionamiento, string documento, string pago, string caja, string moneda, string banco, string cuenta, string mora, float total, float faltante,float abono, string estatus)
        {
            string cadena = "UPDATE CuentasporCobrar SET Fkcliente = '" + cliente + "', Fechaemision ='" + emision + "', Fechavencimiento = '" + vencimiento + "', Fkfraccionamiento = '" + fraccionamiento + "', Fktipodocumento = '" + documento + "', Fkformapago  = '" + pago + "', Fkcaja   = '" + caja + "', Fkmoneda   = '" + moneda + "', Fkbanco   = '" + banco+ "', Fkcuentabancaria    = '" + cuenta + "', Fkmora    = '" + mora + "', Totalmonto    = '" + total  + "', Faltantemonto     = '" + faltante + "', Abono     = '" + abono + "', Estatus  = '" + estatus + "' WHERE Pkid = '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public void funElimMCC(string id)
        {
            string cadena = "DELETE FROM CuentasporCobrar WHERE Pkid = '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarMCC(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Llenando cbx
        public OdbcDataReader llenarcbxCliente(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxFraccionamiento(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarcbxTipoDocumento(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarcbxFormaPago(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarcbxCaja(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarcbxMoneda(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarcbxBanco(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarcbxCuentaBancaria(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarcbxMora(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Obteniendo id del tipo de poliza
        public string consultaCliente(string nombre)
        {

            string id = "";
            string Query = "select * from Cliente  where Nombre='" + nombre + "';";

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

        public string consultaFraccionamiento(string nombre)
        {

            string id = "";
            string Query = "select * from Fraccionamiento  where Nombre='" + nombre + "';";

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
        public string consultaTipoDocumento(string nombre)
        {

            string id = "";
            string Query = "select * from TipoDocumento   where Nombre='" + nombre + "';";

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
        public string consultaFormaPago(string nombre)
        {

            string id = "";
            string Query = "select * from FormaPago   where Nombre='" + nombre + "';";

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
        public string consultaCaja(string nombre)
        {

            string id = "";
            string Query = "select * from Caja   where Nombre='" + nombre + "';";

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
        public string consultaMoneda(string nombre)
        {

            string id = "";
            string Query = "select * from Moneda   where nombreMoneda='" + nombre + "';";

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
        public string consultaBanco(string nombre)
        {

            string id = "";
            string Query = "select * from banco   where nombreBanco='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["IdBanco"].ToString();

            }


            return id;
        }
        public string consultaMora(string nombre)
        {

            string id = "";
            string Query = "select * from Mora   where Nombre='" + nombre + "';";

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
        public string consultaCuentaBancaria(string nombre)
        {

            string id = "";
            string Query = "select * from CuentasBancos   where nombreCuentaB='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["IdCuenta"].ToString();

            }


            return id;
        }

        //función general para llenar una tabla
        public DataTable llenarTabla(string tabla)// metodo  que obtinene el contenido de una tabla
        {
            DataTable table = new DataTable();
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
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



    }
}
