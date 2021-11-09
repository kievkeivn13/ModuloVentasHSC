using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloMVentasCC;

namespace CapaControladorMVentasCC
{
    public class ContoladorComisiones
    {
        SentenciasComisiones sn = new SentenciasComisiones();

        //Forma y Programación realizada por Kevin Flores requerimiento individual 

        //Comisiones
        public DataTable llenarDataGrid(string tabla1)
        {
            DataTable table = new DataTable();
            table = sn.llenarTabla(tabla1);
            return table;
        }
        public DataTable llenarDataGridDetalle(string tabla1, string id)
        {
            DataTable table = new DataTable();
            table = sn.llenarTablaDetalle(tabla1, id);
            return table;
        }
        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            sn.funLlenarCombo(cbx, tabla, value, display, estatus);
        }
        public string consultaID(string nombre, string tabla)
        {
            string id = sn.consultaID(nombre, tabla);
            return id;
        }
        public string consultaFacturaID(string nombre, string tabla)
        {
            string id = sn.consultaFacturaID(nombre, tabla);
            return id;
        }
        public string consultaTotal(string nombre, string tabla)
        {
            string total = sn.consultaTotal(nombre, tabla);
            return total;
        }
        public string consultaPorcentaje(string nombre, string tabla)
        {
            string porcentaje = sn.consultaPorcentaje(nombre, tabla);
            return porcentaje;
        }
        public string consultaIDComision(string nombre, string tabla)
        {
            string id = sn.consultaIDComision(nombre, tabla);
            return id;
        }
        public void metodoLlenarComboControlFecha(ComboBox cbx, string tabla, string value, string display, string estatus, string fecha)
        {
            sn.funLlenarComboFecha(cbx, tabla, value, display, estatus, fecha);
        }
        public string consultaIdCambio(string nombre, string tabla)
        {
            string idcambio = sn.consultaIdCambio(nombre, tabla);
            return idcambio;
        }
        public string consultaCambio(string nombre, string tabla)
        {
            string cambio = sn.consultaCambio(nombre, tabla);
            return cambio;
        }

        public void llamarInsertaEncabezado(string id, string idempleado, string cotizacionmes, string fecha)
        {
            sn.metodoInsertarEncabezado(id, idempleado, cotizacionmes, fecha);
        }

        public void llamarModificarEncabezado(string id, string idempleado, string cotizacionmes, string fecha)
        {
            sn.metodoModifarEncabezado(id, idempleado, cotizacionmes, fecha);
        }

        public void llamarEliminarEnacabezado(string id)
        {
            sn.metodoEliminarEncabezado(id);
        }

        public void llamarInsertaDetalle(string id, string idencabezado, string idfactura, string idComision, string montofactura, string Cantidadcomision)
        {
            sn.metodoInsertarDetalle(id, idencabezado, idfactura, idComision, montofactura, Cantidadcomision);
        }

        public void llamarModificarDetalle(string id, string idencabezado, string idfactura, string idComision, string montofactura, string Cantidadcomision)
        {
            sn.metodoModifarDetalle(id, idencabezado, idfactura, idComision, montofactura, Cantidadcomision);
        }

        public void llamarEliminarDetalle(string id)
        {
            sn.metodoEliminarDetalle(id);
        }
        public void llamarEliminarDetalleE(string id)
        {
            sn.metodoEliminarDetalleE(id);
        }
        public string bloqueo(string id, string app)
        {
            string cadena = sn.llenarpermisos(id, app);

            return cadena;

        }
        public void llamarModificarComisionmes(string id, string comisionmes)
        {

            sn.metodoModifarComisionmes(id, comisionmes);
        }
        public string llamarConsultaComisionesmes(string id, string tabla)
        {

            string valor= sn.metodoComisionmes(id, tabla);
            return valor;
        }
        public string llamarConsultaComisionesfac(string id, string comisionmes)
        {

            string valor = sn.metodoComisionmesfac(id, comisionmes);
            return valor;
        }
    }
}
