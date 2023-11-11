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
    internal class CProveedoresD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;


        public void AgregarProv( string nombre, string cuit, string telefono, string direccion, string email)
        {

            string query = "INSERT INTO proveedores(nombre,cuit,telefono,direccion,email)VALUES(@nombre,@cuit, @telefono, @direccion, @email)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

               
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cuit", cuit);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@email", email);

                comando.ExecuteNonQuery();
                MessageBox.Show("Agregaste un nuevo proveedor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar un nuevo proveedor" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public void ModificarProv(string cod, string nombre, string cuit, string telefono, string direccion, string email)
        {

            string query = "UPDATE proveedores SET nombre = @nombre, cuit = @cuit, telefono = @telefono, direccion = @direccion, email = @email WHERE cod_proveedor = @cod";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cuit", cuit);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@email", email);

                comando.ExecuteNonQuery();
                MessageBox.Show("Modificaste al proveedor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un proveedor" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public void EliminarDatos(string cod, string name)
        {
            string query = "DELETE proveedores WHERE cod_proveedor= @cod";
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
        public DataTable Filtrar(string cod)
        {
            ClsSocio clsSocio = new ClsSocio();
            string query = "SELECT * FROM proveedores WHERE nombre LIKE '%" + cod + "%' OR cuit LIKE '%" + cod + "%'";
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












        public DataTable CargarDatos()
        {

            string query = "SELECT * FROM proveedores";
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
        public List<ClsProvedores> traerTiposProveedores()
        {
            ConexionBD conexionBD = ConexionBD.Instancia;
            List<ClsProvedores> tipos_proveedores = new List<ClsProvedores>();
            try
            {
                conexionBD.AbrirConexion();
                string query = "select * from proveedores";
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        int cod_proveedor = Convert.ToInt32(reader["cod_proveedor"]);
                        string nombre = reader["nombre"].ToString();

                        ClsProvedores tipoProveedor = new ClsProvedores(cod_proveedor, nombre);
                        tipos_proveedores.Add(tipoProveedor);
                    }
                }
                return tipos_proveedores;
            }
            catch
            {
                MessageBox.Show("Error al traer los tipos");
                return null;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
    }
}
