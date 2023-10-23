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
    internal class CDetalleVentaD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;
        public void RealizarDetalleVenta(CDetalleVenta detalle)
        {
            string query = "INSERT INTO detalles_ventas(num_venta, cod_producto, subtotal, cantidad) values (@num_venta,@cod_producto, @subtotal,@cantidad)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.Add(new SqlParameter("@num_venta", detalle.num_venta));
                comando.Parameters.Add(new SqlParameter("@cod_producto", detalle.cod_producto));
                comando.Parameters.Add(new SqlParameter("@subtotal", detalle.subtotal));
                comando.Parameters.Add(new SqlParameter("@cantidad", detalle.cantidad));


                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta." + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
    }
}
