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
    internal class CChequeoD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;

        public int ContarTiposMembresia(int dni)
        {
            string query = "select COUNT(dni_socio) from membresias where dni_soci = '" + dni + "'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                int resultado = (int)comando.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al verificar si el socio existe.");
                return 0;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }

        }

        public string[] buscarPorDni(int dni)
        {
            List<string> result = new List<string>();

            string query = "SELECT fecha_inicio, fecha_fin  FROM Membresias WHERE dni_socio = @dni";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.Parameters.AddWithValue("@dni", dni);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    DateTime fecha_inicio = DateTime.Parse(reader["fecha_inicio"].ToString());
                    DateTime fecha_fin = DateTime.Parse(reader["fecha_fin"].ToString());
                    DateTime fecha_actual = DateTime.Now; 
                    TimeSpan diferencia = fecha_fin - fecha_actual;
                    int dias_restantes = diferencia.Days;

                    result.Add(fecha_inicio.ToString("dd/MM"));
                    result.Add(fecha_fin.ToString("dd/MM"));
                    result.Add(dias_restantes.ToString());
                    
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al buscar el DNI: " + ex);
                throw;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }

            return result.ToArray();
        }
    }
}
