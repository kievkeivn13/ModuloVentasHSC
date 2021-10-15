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
	public class Controlador
	{
        private Sentencias sn = new Sentencias();
        //Mantenimiento Clientes Kevin Flores 9959-18-17632

        //Mantenimiento Fraccionamiento  Kevin Flores 9959-18-17632

        //Mantenimiento inventarios Danny Saldaña 0901-18-18686............................................................
        public DataTable INVMostarInventarios()
        {
            OdbcDataAdapter dt = sn.INVMostarInventarios();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void INVInsertarInventarios(string Pkid, string Nombre, string Fktipoinventario, int Stock, float Costo, float Precio, string Estatus)
        {
            sn.INVInsertarInventarios(Pkid, Nombre, Fktipoinventario, Stock, Costo, Precio, Estatus);

        }

        public OdbcDataReader INVllenarcbxTipoInventarios()
        {
            string sql = "SELECT nombre FROM TipoInventario;";
            return sn.INVllenarcbxTipoInventarios(sql);
        }

        public DataTable INVObtenerIdTipoInventario(string TipoInventario)
        {
            OdbcDataAdapter dt = sn.INVObtenerIdTipoInventario(TipoInventario);
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
        //Mantenimiento Mora Kevin Flores 9959-18-17632

        //Mantenimiento tipo Documento Kevin Flores 9959-18-17632 

    }
}
