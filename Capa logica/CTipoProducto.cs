using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Control_Gym.Capa_logica;
using System.Windows.Forms;
using Control_Gym.Capa_de_datos;

namespace Control_Gym.Capa_logica
{
    internal class CTipoProducto
    {
        public int Cod_tipo_producto {  get; set; }
        public string Nombre { get; set; }

        public CTipoProducto(int Cod_tipo_producto, string nombre)
        {
            this.Cod_tipo_producto = Cod_tipo_producto;
            this.Nombre = nombre;
        }

        public CTipoProducto()
        {
        }
        public override string ToString()
        {
            return Nombre;
        }
        public void ActualizarProducto(int cod, string nombre)
        {
            CTipoProductoD cTipoProductoD = new CTipoProductoD();
            cTipoProductoD.ActualizarProducto(cod, nombre);
        }
        public void EliminarProducto(int cod, string nombre)
        {
            CTipoProductoD cTipoProductoD = new CTipoProductoD();
            cTipoProductoD.EliminarProducto(cod, nombre);
        }
        public void AgregarTipoProducto(string nombre)
        {
            CTipoProductoD cTipoProductoD = new CTipoProductoD();
            cTipoProductoD.AgregarTipoProducto(nombre);
        }
        public DataTable MostrarTipoProducto()
        {
            CTipoProductoD cTipoProductoD = new CTipoProductoD();
            DataTable tabla = new DataTable();
            tabla = cTipoProductoD.MostrarTipoProducto();
            return tabla;
        }
        public List<CTipoProducto> traerTiposProductos()
        {
            CTipoProductoD tiposD = new CTipoProductoD();
            return tiposD.traerTiposProducto();
        }


    }
}
