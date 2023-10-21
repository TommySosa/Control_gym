using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Control_Gym.Capa_logica;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlTypes;

namespace Control_Gym.Capa_de_datos
{
    internal class CSociosD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;


        public void GuardarSocio(int dni, string nombre, string apellido, DateTime fechaNacimiento, string telefono, string domicilio, string email)
        {
           
            string query = "INSERT INTO socios(dni_socio,nombre,apellido,fecha_nac,telefono,domicilio,email)VALUES(@dni, @nombre, @apellido, @fechaNacimiento, @telefono, @domicilio, @email)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@domicilio", domicilio);
                comando.Parameters.AddWithValue("@email", email);

                comando.ExecuteNonQuery();
                MessageBox.Show("Nuevo socio aderido");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir un nuevo socio" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public void ModificarSocio(string cod, int dni, string nombre, string apellido, DateTime fechaNacimiento, string telefono, string domicilio, string email)
        {
            string query = "UPDATE socios SET dni_socio = @dni, nombre = @nombre, apellido = @apellido, fecha_nac = @fechaNacimiento, telefono = @telefono, domicilio = @domicilio, email = @email WHERE dni_socio = @cod";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@domicilio", domicilio);
                comando.Parameters.AddWithValue("@email", email);

                comando.ExecuteNonQuery();
                MessageBox.Show("Datos modificados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un socio: " + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

        public DataTable CargarDatos()
        {
          
            string query = "SELECT * FROM socios";
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
                MessageBox.Show("Error" + ex);
            }
           
             finally
            {
                conexionBD.CerrarConexion();
            }

            return tabla;
        }

        public void EliminarDatos(string cod, string name)
        {
            string query = "DELETE socios WHERE dni_socio= @cod";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.Parameters.AddWithValue("@cod", cod);
                comando.ExecuteNonQuery();
                MessageBox.Show("Eliminaste los datos del socio "+ name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar un socio" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

        public DataTable Filtrar(string cod)
        {
            ClsSocio clsSocio= new ClsSocio();
            string query = "SELECT * FROM socios WHERE nombre LIKE '%"+cod+"%' OR apellido LIKE '%"+cod+ "%' OR dni_socio LIKE '%"+cod+"%'";
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
