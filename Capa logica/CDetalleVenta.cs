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
        public string nombre_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_producto { get; set; }
        public decimal descuento { get; set; }
        public decimal subtotal { get; set; }


        public CDetalleVenta() { }

        public CDetalleVenta(int num_venta, long cod_producto, decimal subtotal, int cantidad, decimal descuento)
        {
            this.num_venta = num_venta;
            this.cod_producto = cod_producto;
            this.subtotal = subtotal;
            this.cantidad = cantidad;
            this.descuento = descuento;

        }
        public CDetalleVenta(long cod_producto, decimal subtotal, int cantidad, decimal descuento)
        {
            this.cod_producto = cod_producto;
            this.subtotal = subtotal;
            this.cantidad = cantidad;
            this.descuento = descuento;
        }
    }
}
