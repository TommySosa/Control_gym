using Control_Gym.Capa_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Gym.Capa_logica
{
    internal class CVenta
    {
        public int num_venta { get; set; }
        public int dni_cliente { get; set; }
        public int dni_empleado { get; set; }
        public DateTime fecha { get; set; }
        public decimal descuento { get; set; }

        private CVentaD cVentaD = new CVentaD();
        private CDetalleVentaD cDetalleD = new CDetalleVentaD();
        public CVenta() { 

        }
        public CVenta(int num_venta, int dni_cliente, int dni_empleado, DateTime fecha, decimal descuento)
        {
            this.num_venta = num_venta;
            this.dni_cliente = dni_cliente;
            this.dni_empleado = dni_empleado;
            this.fecha = fecha;
            this.descuento = descuento;
        }
        public CVenta( int dni_cliente, int dni_empleado, DateTime fecha, decimal descuento)
        {
            this.dni_cliente = dni_cliente;
            this.dni_empleado = dni_empleado;
            this.fecha = fecha;
            this.descuento = descuento;
        }

        public void RealizarVenta(int dniCliente, int dniEmpleado, decimal descuento, List<CDetalleVenta> detallesVenta)
        {
            cVentaD.RealizarVenta(dniCliente, dniEmpleado, descuento, detallesVenta);
        }

        public void RealizarDetalleVenta(CDetalleVenta detalle)
        {
            cDetalleD.RealizarDetalleVenta(detalle);
        }
    }
}
