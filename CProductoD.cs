using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_datos
{
    internal class CProductoD
    {
        ConexionBD conexionBD = ConexionBD.Instancia;

        public List<CProducto> traerProductos()
        {
            List<CProducto> productos = new List<CProducto>();
            try
            {
                conexionBD.AbrirConexion();
                string query = "select * from productos";
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        CProducto producto = new CProducto
                        {
                            cod_producto = Convert.ToInt64(reader["cod_producto"]),
                            cod_proveedor = Convert.ToInt32(reader["cod_proveedor"]),
                            cod_tipo_producto = Convert.ToInt32(reader["cod_tipo_producto"]),
                            nombre = reader["nombre"].ToString(),
                            fecha_venc = Convert.ToDateTime(reader["fecha_venc"]),
                            precio_costo = Convert.ToDecimal(reader["precio_costo"]),
                            precio_venta = Convert.ToDecimal(reader["precio_venta"]),
                            ganancia = Convert.ToDecimal(reader["ganancia"]),
                            stock = Convert.ToInt32(reader["stock"])
                        };

                        productos.Add(producto);
                    }
                }
                return productos;
            }
            catch
            {
                MessageBox.Show("Error al traer los productos");
                return null;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
    }
}
