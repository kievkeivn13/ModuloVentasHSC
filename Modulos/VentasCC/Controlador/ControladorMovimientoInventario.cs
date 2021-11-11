using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloMVentasCC;

namespace CapaControladorMVentasCC
{
    public class ControladorMovimientoInventario
    {
        private SentenciasMovimientoInventario sn = new SentenciasMovimientoInventario();


        //Mantenimiento Movimiento Danny Saldaña 0901-18-18686s

        public DataTable INVMostarMovimientos()
        {
            OdbcDataAdapter dt = sn.INVMostarMovimientos();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Mantenimiento Lista de precios Danny Saldaña 0901-18-18686
        public DataTable LISTAllenarcbxInventarios()
        {
            OdbcDataAdapter dt = sn.LISTAllenarcbxInventarios();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable LISTAllenarcbxMarca()
        {
            OdbcDataAdapter dt = sn.LISTAllenarcbxMarca();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable LISTAllenarcbxLinea()
        {
            OdbcDataAdapter dt = sn.LISTAllenarcbxLinea();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public void LISTAGlobalYFijo(float Precio)
        {
            sn.LISTAGlobalYFijo(Precio);
        }

        public void LISTAGlobalYDescuento(float Precio)
        {
            sn.LISTAGlobalYDescuento(Precio);
        }

        public void LISTAGlobalYAumento(float Precio)
        {
            sn.LISTAGlobalYAumento(Precio);
        }

        public void LISTATipoYFijo(float Valor, string Fktipoinventario)
        {
            sn.LISTATipoYFijo(Valor, Fktipoinventario);
        }

        public void LISTATipoYDescuento(float Valor, string Fktipoinventario)
        {
            sn.LISTATipoYDescuento(Valor, Fktipoinventario);
        }

        public void LISTATipoYAumento(float Valor, string Fktipoinventario)
        {
            sn.LISTATipoYAumento(Valor, Fktipoinventario);
        }



        public void LISTAMarcaYFijo(float Valor, string Fktipoinventario)
        {
            sn.LISTAMarcaYFijo(Valor, Fktipoinventario);
        }

        public void LISTAMarcaYDescuento(float Valor, string Fktipoinventario)
        {
            sn.LISTAMarcaYDescuento(Valor, Fktipoinventario);
        }

        public void LISTAMarcaYAumento(float Valor, string Fktipoinventario)
        {
            sn.LISTAMarcaYAumento(Valor, Fktipoinventario);
        }




        public void LISTALineaYFijo(float Valor, string Fktipoinventario)
        {
            sn.LISTALineaYFijo(Valor, Fktipoinventario);
        }

        public void LISTALineaYDescuento(float Valor, string Fktipoinventario)
        {
            sn.LISTALineaYDescuento(Valor, Fktipoinventario);
        }

        public void LISTALineaYAumento(float Valor, string Fktipoinventario)
        {
            sn.LISTALineaYAumento(Valor, Fktipoinventario);
        }









        /*

        //Mantenimiento inventarios Danny Saldaña 0901-18-18686............................................................
        public DataTable INVMostarInventarios()
        {
            OdbcDataAdapter dt = sn.INVMostarInventarios();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void INVInsertarInventarios(string Pkid, string Nombre, string Fktipoinventario, string Fkidmarca, string Fkidlinea, int Stock, float Costo, float Precio, string Estatus)
        {
            sn.INVInsertarInventarios(Pkid, Nombre, Fktipoinventario, Fkidmarca, Fkidlinea, Stock, Costo, Precio, Estatus);

        }

        public void INVActualizarInventarios(string Pkid, string Nombre, string Fktipoinventario, string Fkidmarca, string Fkidlinea, int Stock, float Costo, float Precio, string Estatus)
        {
            sn.INVActualizarInventarios(Pkid, Nombre, Fktipoinventario, Fkidmarca, Fkidlinea, Stock, Costo, Precio, Estatus);

        }

        public void INVBorrarInventarios(string Pkid)
        {
            sn.INVBorrarInventarios(Pkid);

        }

        public OdbcDataReader INVllenarcbxTipoInventarios()
        {
            string sql = "SELECT nombre FROM TipoInventario;";
            return sn.INVllenarcbxTipoInventarios(sql);
        }

        public OdbcDataReader INVllenarcbxMarca()
        {
            string sql = "SELECT nombre FROM marca;";
            return sn.INVllenarcbxMarca(sql);
        }

        public OdbcDataReader INVllenarcbxLinea()
        {
            string sql = "SELECT nombre FROM linea;";
            return sn.INVllenarcbxLinea(sql);
        }

        public DataTable INVObtenerIdTipoInventario(string TipoInventario)
        {
            OdbcDataAdapter dt = sn.INVObtenerIdTipoInventario(TipoInventario);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable INVObtenerIdMarca(string Marca)
        {
            OdbcDataAdapter dt = sn.INVObtenerIdMarca(Marca);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable INVObtenerIdLinea(string Linea)
        {
            OdbcDataAdapter dt = sn.INVObtenerIdLinea(Linea);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Mantenimiento tipo inventario Danny Saldaña 0901-18-18686........................................................
        public DataTable INVMostarTipoInventarios()
        {
            OdbcDataAdapter dt = sn.INVMostarTipoInventarios();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void INVInsertarTipoInventarios(string Pkid, string Nombre, string Estatus)
        {
            sn.INVInsertarTipoInventarios(Pkid, Nombre, Estatus);

        }

        public void INVActualizarTipoInventarios(string Pkid, string Nombre, string Estatus)
        {
            sn.INVActualizarTipoInventarios(Pkid, Nombre, Estatus);

        }

        public void INVBorrarTipoInventarios(string Pkid)
        {
            sn.INVBorrarTipoInventarios(Pkid);

        }

        */

    }
}
