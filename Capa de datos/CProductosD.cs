using Control_Gym.Capa_logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_datos
{
    internal class CProductosD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;


        public void GuardarProducto(long cod_producto, int cod_proveedor, int cod_tipo_producto, string nombre , DateTime fecha_venc, decimal precio_costo, decimal precio_venta, decimal ganancia, int stock)
        {

            string query = "INSERT INTO productos(cod_producto, cod_proveedor, cod_tipo_producto, nombre, fecha_venc,  precio_costo, precio_venta, ganancia, stock)VALUES(@codigoproducto, @codigoproveedor, @codigotipoproducto, @nombre, @fechavencimiento, @preciocosto, @precioventa, @ganancia, @stock)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.Parameters.AddWithValue("@codigoproducto", cod_producto);
                comando.Parameters.AddWithValue("@codigoproveedor", cod_proveedor);
                comando.Parameters.AddWithValue("@codigotipoproducto", cod_tipo_producto);
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
        public void ModificarProducto(string cod, long cod_producto, int cod_proveedor, int cod_tipo_producto, string nombre, DateTime fecha_venc, decimal precio_costo, decimal precio_venta, decimal ganancia, int stock)
        {
            string query = "UPDATE productos SET cod_producto = @codigoproducto, cod_tipo_producto = @codigotipoproducto, cod_proveedor = @codigoproveedor, nombre = @nombre, fecha_venc = @fechavencimiento, precio_costo = @preciocosto, precio_venta = @precioventa, ganancia = @ganancia, stock = @stock WHERE cod_producto = @cod";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.AddWithValue("@codigoproducto", cod_producto);
                comando.Parameters.AddWithValue("@codigotipoproducto", cod_tipo_producto);
                comando.Parameters.AddWithValue("@codigoproveedor", cod_proveedor);
                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@fechavencimiento", fecha_venc);
                comando.Parameters.AddWithValue("@preciocosto", precio_costo);
                comando.Parameters.AddWithValue("@precioventa", precio_venta);
                comando.Parameters.AddWithValue("@ganancia", ganancia);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();
                MessageBox.Show("Producto modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto" + ex);
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

        public void EliminarProducto(string cod, string nombre)
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
        public DataTable MostrarTipoProducto()
        {
            string query = "SELECT * FROM tipos_productos";
            DataTable tabla = new DataTable();
            
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                tabla.Load(comando.ExecuteReader());
                comando.ExecuteNonQuery();
                
                
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
        public DataTable MostrarProveedor()
        {
            string query = "SELECT * FROM proveedores";
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                tabla.Load(comando.ExecuteReader());
                comando.ExecuteNonQuery();


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
        public DataTable Filtrar(string cod)
        {
            ClsSocio clsSocio = new ClsSocio();
            string query = "SELECT * FROM productos WHERE nombre LIKE '%" + cod + "%' OR cod_producto LIKE '%" + cod + "%'";
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
    }
}