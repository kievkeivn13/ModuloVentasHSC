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
   public class ControladorCC
	{
        SentenciasCC sn = new SentenciasCC();

        //Cuentas por cobrar Ashly Barrios
        public void llamarInsertMCC(string id, string cliente, string emision, string vencimiento, string fraccionamiento, string documento, string pago, string caja, string moneda, string banco, string cuenta, string mora, float total, float faltante,float abono, string estatus)
        {

            sn.funInsertarMCC( id,  cliente,  emision,  vencimiento,  fraccionamiento,  documento,  pago,  caja,  moneda,  banco,  cuenta,  mora,  total,  faltante , abono,  estatus);
        }

        public void llamarModifMCC(string id, string cliente, string emision, string vencimiento, string fraccionamiento, string documento, string pago, string caja, string moneda, string banco, string cuenta, string mora, float total, float faltante, float abono, string estatus)
        {

            sn.funModifMCC(id, cliente, emision, vencimiento, fraccionamiento, documento, pago, caja, moneda, banco, cuenta, mora, total, faltante, abono,  estatus);
        }

        public void llamarElimMCC(string id)
        {

            sn.funElimMCC(id);
        }
        public DataTable llenarMCC(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarMCC(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public OdbcDataReader llenarcbxCliente()
        {
            string sql = "SELECT Nombre FROM Cliente ;";
            return sn.llenarcbxCliente(sql);
        }

        public OdbcDataReader llenarcbxFraccionamiento()
        {
            string sql = "SELECT Nombre FROM Fraccionamiento ;";
            return sn.llenarcbxFraccionamiento(sql);
        }
        public OdbcDataReader llenarcbxTipoDocumento()
        {
            string sql = "SELECT Nombre FROM TipoDocumento ;";
            return sn.llenarcbxTipoDocumento(sql);
        }
        public OdbcDataReader llenarcbxFormaPago()
        {
            string sql = "SELECT Nombre FROM FormaPago ;";
            return sn.llenarcbxFormaPago(sql);
        }
        public OdbcDataReader llenarcbxCaja()
        {
            string sql = "SELECT Nombre FROM Caja ;";
            return sn.llenarcbxCaja(sql);
        }
        public OdbcDataReader llenarcbxMoneda()
        {
            string sql = "SELECT nombreMoneda FROM Moneda ;";
            return sn.llenarcbxMoneda(sql);
        }
        public OdbcDataReader llenarcbxMora()
        {
            string sql = "SELECT Nombre FROM Mora ;";
            return sn.llenarcbxMora(sql);
        }

        public OdbcDataReader llenarcbxCuentaBancaria()
        {
            string sql = "SELECT nombreCuentaB FROM CuentasBancos ;";
            return sn.llenarcbxCuentaBancaria(sql);
        }
        public OdbcDataReader llenarcbxBanco()
        {
            string sql = "SELECT nombreBanco FROM banco ; ";
            return sn.llenarcbxBanco(sql);
        }


        public string consultaCliente(string nombre)
        {
            string id = sn.consultaCliente(nombre);
            return id;
        }

        public string consultaFraccionamiento(string nombre)
        {
            string id = sn.consultaFraccionamiento(nombre);
            return id;
        }
        public string consultaTipoDocumento(string nombre)
        {
            string id = sn.consultaTipoDocumento(nombre);
            return id;
        }
        public string consultaFormaPago(string nombre)
        {
            string id = sn.consultaFormaPago(nombre);
            return id;
        }
        public string consultaCaja(string nombre)
        {
            string id = sn.consultaCaja(nombre);
            return id;
        }
        public string consultaMoneda(string nombre)
        {
            string id = sn.consultaMoneda(nombre);
            return id;
        }
        public string consultaBanco(string nombre)
        {
            string id = sn.consultaBanco(nombre);
            return id;
        }
        public string consultaCuentaBancaria(string nombre)
        {
            string id = sn.consultaCuentaBancaria(nombre);
            return id;
        }
        public string consultaMora(string nombre)
        {
            string id = sn.consultaMora(nombre);
            return id;
        }

        public DataTable llenarDataGrid(string tabla)
        {
            DataTable table = new DataTable();
            table = sn.llenarTabla(tabla);
            return table;
        }

    }
}
