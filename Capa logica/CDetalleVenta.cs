using Control_Gym.Capa_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Gym.Capa_logica
{
    internal class CDetalleVenta
    {
        public int num_venta { get; set; }
        public long cod_producto { get; set; }
        public decimal subtotal { get; set; }
        public int cantidad { get; set; }


        public CDetalleVenta() { }

        public CDetalleVenta(int num_venta, long cod_producto, decimal subtotal, int cantidad)
        {
            this.num_venta = num_venta;
            this.cod_producto = cod_producto;
            this.subtotal = subtotal;
            this.cantidad = cantidad;
        }
        public CDetalleVenta(long cod_producto, decimal subtotal, int cantidad)
        {
            this.cod_producto = cod_producto;
            this.subtotal = subtotal;
            this.cantidad = cantidad;
        }
    }
}
