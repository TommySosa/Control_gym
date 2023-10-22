using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_datos
{
    internal class CTipoProductoD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;
        public void AgregarTipoProducto(string nombre)
        {

            string query = "INSERT INTO tipos_productos(nombre)VALUES (@nombre)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.ExecuteNonQuery();

                MessageBox.Show("Nuevo tipo de producto agregado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tipo de producto" + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public DataTable MostrarTipoProducto()
        {

            string query = "SELECT * FROM tipos_productos";
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer;
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                leer= comando.ExecuteReader();
                tabla.Load(leer);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar tipo de producto" + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
            return tabla;
        }
        public void ActualizarProducto(int cod, string nombre)
        {

            string query = "UPDATE tipos_productos SET nombre = @nombre WHERE cod_tipo_producto = @cod";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@nombre", nombre);
        
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizaste el tipo de producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public void EliminarProducto(int cod, string nombre)
        {
            string query = "delete tipos_productos where cod_tipo_producto = '" + cod + "'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al eliminar el tipo de producto" +  ex);
            }
        }
    }
}
