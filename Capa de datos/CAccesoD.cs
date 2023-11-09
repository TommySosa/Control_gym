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
    internal class CAccesoD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;
        public bool EmpleadoExiste(int dni)
        {
            string query = "SELECT COUNT(*) FROM empleados WHERE dni_empleado = '" + dni + "'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                int resultado = (int)comando.ExecuteScalar();
                if (resultado == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si el empleado existe."+ ex);
                return false;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }

        }
        public List<CAcceso> Login(CAcceso cAcc)
        {
                string query = "select * from empleados where dni_empleado = '"+cAcc.dni_empleado+"' and contraseña = '"+cAcc.contraseña+"';";
                List<CAcceso> datos = new List<CAcceso>();
                try
                {
                    SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        CAcceso acceso = new CAcceso
                        {
                            dni_empleado = Convert.ToInt32(reader["dni_empleado"].ToString()),
                            nombre = reader["nombre"].ToString(),
                            apellido = reader["apellido"].ToString(),
                            telefono = reader["telefono"].ToString(),
                            fecha_nac = DateTime.Parse(reader["fecha_nac"].ToString()),
                            domicilio = reader["domicilio"].ToString(),
                            email = reader["email"].ToString(),
                            contraseña = reader["contraseña"].ToString()
                        };
                        //return acceso;
                        datos.Add(acceso);
                    }
                        reader.Close();

                    if (datos.Count > 1)
                    {
                        return datos;
                    }
                    else
                    {
                        datos.Add (null);
                        return datos;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al mostrar las membresias: " + ex);
                    throw;
                }
            }
    }
}
