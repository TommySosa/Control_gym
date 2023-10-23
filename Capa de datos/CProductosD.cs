using Control_Gym.Capa_logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_datos
{
    internal class CProductoD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;


        public void GuardarProducto(string nombre , int fecha_venc, double precio_costo, double precio_venta, double ganancia, int stock)
        {

            string query = "INSERT INTO productos(nombre, fecha_venc, precio_costo, precio_venta, ganancia, stock)VALUES(@nombre, @fechavencimiento, @preciocosto, @precioventa, @ganancia, @stock)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@fechavencimiento", fecha_venc);
                comando.Parameters.AddWithValue("@preciocosto", precio_costo);
                comando.Parameters.AddWithValue("@precioventa", precio_venta);
                comando.Parameters.AddWithValue("@ganancia", ganancia);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();
                MessageBox.Show("Nuevo producto agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir un nuevo producto" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public void ModificarProducto(int cod, string nombre, int fecha_venc, double precio_costo, double precio_venta, double ganancia, int stock)
        {
            string query = "UPDATE productos SET nombre = @nombre, fecha_venc = @fechavencimiento, precio_costo = @preciocosto, precio_venta = @precioventa, ganancia = @ganancia, stock = @stock WHERE cod_producto = @cod";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@fechavencimiento", fecha_venc);
                comando.Parameters.AddWithValue("@preciocosto", precio_costo);
                comando.Parameters.AddWithValue("@precioventa", precio_venta);
                comando.Parameters.AddWithValue("@ganancia", ganancia);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();
                MessageBox.Show("Nuevo producto agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir un nuevo producto" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

        public DataTable MostrarDatos()
        {

            string query = "SELECT * FROM productos";
            DataTable tabla = new DataTable();
            try
            {

                SqlDataReader leer;

                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                leer = comando.ExecuteReader();
                tabla.Load(leer);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            finally
            {
                conexionBD.CerrarConexion();
            }

            return tabla;
        }

        public void EliminarProducto(int cod, string nombre)
        {
            string query = "DELETE productos WHERE cod_producto='" + cod + "'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.ExecuteNonQuery();
                MessageBox.Show("Eliminaste los datos del producto " + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar un producto" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
    }
}