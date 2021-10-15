using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace CapaModeloMVentasCC
{
	public class Sentencias
	{
        private Conexion cn = new Conexion();
        private OdbcCommand Comm;
        //Mantenimiento Clientes Kevin Flores 9959-18-17632

        //Mantenimiento Fraccionamiento  Kevin Flores 9959-18-17632

        //Mantenimiento inventarios Danny Saldaña 0901-18-18686

        public OdbcDataAdapter INVMostarInventarios()
        {
                        //Busca los datos de todos los inventarios disponibles
            string sql = "SELECT * FROM Inventario;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void INVInsertarInventarios(string Pkid, string Nombre, string Fktipoinventario, int Stock, float Costo, float Precio, string Estatus)
        {
                    //Insertar en la base de datos los nuevos inventarios
            string cadena = "INSERT INTO Inventario VALUES ('" + Pkid + "', '" + Nombre + "', '" + Fktipoinventario + "', " + Stock + ", " + Costo + ", " + Precio + ", '" + Estatus + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public OdbcDataReader INVllenarcbxTipoInventarios(string sql)
        {
                    //Llenar ComboBox con los tipos de inventario disponibles
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

        public OdbcDataAdapter INVObtenerIdTipoInventario(string TipoInventario)
        {
            //Obtener el Id del tipo de inventario seleccionado 
            string sql = "SELECT Pkid FROM tipoinventario WHERE Nombre = '"+ TipoInventario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }



        //Mantenimiento tipo inventario Danny Saldaña 0901-18-18686

        public OdbcDataAdapter INVMostarTipoInventarios()
        {
            //Busca los datos de todos los inventarios disponibles
            string sql = "SELECT * FROM TipoInventario;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void INVInsertarTipoInventarios(string Pkid, string Nombre, string Estatus)
        {
            //Insertar en la base de datos los nuevos inventarios
            string cadena = "INSERT INTO TipoInventario VALUES ('" + Pkid + "', '" + Nombre + "', '" + Estatus + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        //Mantenimiento Mora Kevin Flores 9959-18-17632

        //Mantenimiento tipo Documento Kevin Flores 9959-18-17632 

    }
}
