using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModeloMVentasCC
{
    public class SentenciasMovimientoInventario
    {
        private Conexion cn = new Conexion();


        //Mantenimiento Movimiento Danny Saldaña 0901-18-18686
        public OdbcDataAdapter INVMostarMovimientos()
        {
            //Busca los datos de todos los inventarios disponibles
            string sql = "SELECT * FROM movimientoinventario;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Mantenimiento Lista de precios Danny Saldaña 0901-18-18686

        public OdbcDataAdapter LISTAllenarcbxInventarios()
        {
            //Busca los datos de todos los inventarios disponibles
            string sql = "SELECT nombre FROM Inventario;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter LISTAllenarcbxMarca()
        {
            //Busca los datos de todas las lineas
            string sql = "SELECT nombre FROM marca;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter LISTAllenarcbxLinea()
        {
            //Busca los datos de todos las Marcas
            string sql = "SELECT nombre FROM linea;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }




        public void LISTAGlobalYFijo(float Precio)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio =" + Precio + ";";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTAGlobalYDescuento(float Valor)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio - Precio * " + Valor + ";";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTAGlobalYAumento(float Valor)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio * " + Valor + ";";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        public void LISTATipoYFijo(float Precio, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio =" + Precio + " Where Nombre =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTATipoYDescuento(float Valor, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio - Precio * " + Valor + " Where Nombre =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTATipoYAumento(float Valor, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio * " + Valor + " Where Nombre =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }




        public void LISTAMarcaYFijo(float Precio, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio =" + Precio + " Where Fkidmarca =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTAMarcaYDescuento(float Valor, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio - Precio * " + Valor + " Where Fkidmarca =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTAMarcaYAumento(float Valor, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio * " + Valor + " Where Fkidmarca =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }




        public void LISTALineaYFijo(float Precio, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio =" + Precio + " Where Fkidlinea =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTALineaYDescuento(float Valor, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio - Precio * " + Valor + " Where Fkidlinea =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void LISTALineaYAumento(float Valor, string Fktipoinventario)
        {
            //Actualizar Precio (Global y Fijo)
            string cadena = "UPDATE Inventario SET Precio = Precio * " + Valor + " Where Fkidlinea =" + Fktipoinventario + " ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }






        /*
        //Mantenimiento inventarios Danny Saldaña 0901-18-18686

        public OdbcDataAdapter INVMostarInventarios()
        {
            //Busca los datos de todos los inventarios disponibles
            string sql = "SELECT * FROM Inventario;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void INVInsertarInventarios(string Pkid, string Nombre, string Fktipoinventario, string Fkidmarca, string Fkidlinea, int Stock, float Costo, float Precio, string Estatus)
        {
            //Insertar en la base de datos los nuevos inventarios
            string cadena = "INSERT INTO Inventario VALUES ('" + Pkid + "', '" + Nombre + "', '" + Fktipoinventario + "', '" + Fkidmarca + "', '" + Fkidlinea + "',  " + Stock + ", " + Costo + ", " + Precio + ", '" + Estatus + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void INVActualizarInventarios(string Pkid, string Nombre, string Fktipoinventario, string Fkidmarca, string Fkidlinea, int Stock, float Costo, float Precio, string Estatus)
        {
            //Insertar en la base de datos los nuevos inventarios
            string cadena = "UPDATE inventario SET Pkid='" + Pkid + "', Nombre='" + Nombre + "', Fktipoinventario='" + Fktipoinventario + "', Fkidmarca='" + Fkidmarca + "', Fkidlinea='" + Fkidlinea + "', Stock=" + Stock + ", Costo=" + Costo + ", Precio=" + Precio + ", Estatus='" + Estatus + "'  WHERE Pkid='" + Pkid + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void INVBorrarInventarios(string Pkid)
        {
            //Insertar en la base de datos los nuevos inventarios
            string cadena = "DELETE FROM `inventario` WHERE Pkid='" + Pkid + "';";

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

        public OdbcDataReader INVllenarcbxMarca(string sql)
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

        public OdbcDataReader INVllenarcbxLinea(string sql)
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
            string sql = "SELECT Pkid FROM tipoinventario WHERE Nombre = '" + TipoInventario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter INVObtenerIdMarca(string Marca)
        {
            //Obtener el Id del tipo de inventario seleccionado 
            string sql = "SELECT id_marca FROM marca WHERE Nombre = '" + Marca + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter INVObtenerIdLinea(string Linea)
        {
            //Obtener el Id del tipo de inventario seleccionado 
            string sql = "SELECT id_linea FROM linea WHERE Nombre = '" + Linea + "';";
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

        public void INVActualizarTipoInventarios(string Pkid, string Nombre, string Estatus)
        {
            //Insertar en la base de datos los nuevos inventarios
            string cadena = "UPDATE tipoinventario SET Pkid='" + Pkid + "', Nombre='" + Nombre + "', Estatus='" + Estatus + "'  WHERE Pkid='" + Pkid + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void INVBorrarTipoInventarios(string Pkid)
        {
            //Insertar en la base de datos los nuevos inventarios
            string cadena = "DELETE FROM tipoinventario WHERE Pkid='" + Pkid + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        */
    }
}
