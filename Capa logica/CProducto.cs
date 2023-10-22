﻿using Control_Gym.Capa_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Gym.Capa_logica
{
    internal class CProducto
    {
        public long cod_producto { get; set; }
        public int cod_proveedor { get; set; }
        public int cod_tipo_producto { get; set; }
        public string nombre { get; set; }
        public DateTime fecha_venc { get; set; }
        public decimal precio_costo { get; set; }
        public decimal precio_venta { get; set; }
        public decimal ganancia { get; set; }
        public int stock { get; set; }

        public CProducto() { }
        public CProducto(int cod_proveedor, int cod_tipo_producto, string nombre, DateTime fecha_venc, decimal precio_costo, decimal precio_venta, decimal ganancia, int stock)
        {
            this.cod_proveedor = cod_proveedor;
            this.cod_tipo_producto = cod_tipo_producto;
            this.nombre = nombre;
            this.fecha_venc = fecha_venc;
            this.precio_costo = precio_costo;
            this.precio_venta = precio_venta;
            this.ganancia = ganancia;
            this.stock = stock;
        }
        public CProducto(long cod_producto, int cod_proveedor, int cod_tipo_producto, string nombre, DateTime fecha_venc, decimal precio_costo, decimal precio_venta, decimal ganancia, int stock)
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

        public override string ToString()
        {
            return nombre;
        }

        public List<CProducto> traerProductos()
        {
            CProductoD productoD = new CProductoD();
            return productoD.traerProductos();
        }
    }
}