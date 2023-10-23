using Control_Gym.Capa_de_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Gym.Capa_logica
{
    internal class CProducto
    {
        public int cod_producto { get; set; }
        public int cod_proveedor { get; set; }
        public int cod_tipo_producto { get; set; }
        public string nombre { get; set; }
        public int fecha_venc { get; set; }
        public double precio_costo { get; set; }
        public double precio_venta { get; set; }
        public double ganancia { get; set; }
        public int stock { get; set; }

        public CProducto(int cod_producto, int cod_proveedor, int cod_tipo_producto, int fecha_venc, double precio_costo, double precio_venta, double ganancia, int stock)
        {
            this.cod_producto = cod_producto;
            this.cod_proveedor = cod_proveedor;
            this.cod_tipo_producto = cod_tipo_producto;
            this.nombre = nombre;
            this.fecha_venc = fecha_venc;
            this.precio_costo = precio_costo;
            this.precio_venta = precio_venta;
            this.ganancia = ganancia;
            this.stock = stock;
        }
        public CProducto()
        {

        }
        public void GuardarProducto(int cod_producto, int cod_proveedor, int cod_tipo_producto, int fecha_venc, double precio_costo, double precio_venta, double ganancia, int stock)
        {
            CProducto CProductoD = new CProducto();
            CProductoD.GuardarProducto(cod_producto, cod_proveedor, cod_tipo_producto, fecha_venc, precio_costo, precio_venta, ganancia, stock);
        }
        public void ModificarProducto(int cod, int cod_producto, int cod_proveedor, int cod_tipo_producto, int fecha_venc, double precio_costo, double precio_venta, double ganancia, int stock)
        {
            CProducto CProductoD = new CProducto();
            CProductoD.ModificarProducto(cod, cod_producto, cod_proveedor, cod_tipo_producto, fecha_venc, precio_costo, precio_venta, ganancia, stock);

        }
        public DataTable MostrarDatos()
        {

            CProducto CProductoD = new CProducto();
            DataTable tabla = new DataTable();
            tabla = CProductoD.MostrarDatos();

            return tabla;
        }
        public void EliminarProducto(int cod, string nombre)
        {
            CProducto CProductoD = new CProducto();
            CProductoD.EliminarProducto(cod, nombre);
        }


    }
}