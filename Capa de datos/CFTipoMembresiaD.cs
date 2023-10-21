using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Control_Gym.Capa_logica;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_datos
{
    internal class CFTipoMembresiaD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;

        public void AgregarTipo(string nombre, decimal precio, int dias)
        {

            string query = "INSERT INTO tipos_membresias(nombre,precio,cantidad_dias)VALUES(@nombre,@precio, @dias)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());


                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@dias", dias);

                comando.ExecuteNonQuery();
                MessageBox.Show("Agregaste un nuevo tipo de membresia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar un nuevo tipo de membresia" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

        public void ModificarTipo(string cod, string nombre,decimal precio,int dias)
        {

            string query = "UPDATE tipos_membresias SET nombre = @nombre, precio = @precio, cantidad_dias = @dias WHERE cod_tipo_membresia = @cod";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@dias", dias);

                comando.ExecuteNonQuery();
                MessageBox.Show("Modificaste el tipo de membresia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un tipo de membresia" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public void EliminarDatos(string cod, string name)
        {
            string query = "DELETE tipos_membresias WHERE cod_tipo_membresia= @cod";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.Parameters.AddWithValue("@cod", cod);

                comando.ExecuteNonQuery();
                MessageBox.Show("Eliminaste los datos del proveedor " + name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar un proveedor" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public DataTable CargarDatos()
        {

            string query = "SELECT * FROM tipos_membresias";
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
        public DataTable Filtrar(string cod)
        {
            ClsSocio clsSocio = new ClsSocio();
            string query = "SELECT * FROM tipos_membresias WHERE nombre LIKE '%" + cod + "%' OR precio LIKE '%" + cod + "%'";
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
