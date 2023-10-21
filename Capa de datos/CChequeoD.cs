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
            string query = "SELECT fecha_inicio, fecha_fin, cod_tipo_membresia FROM Membresias ";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int cod_tipo_membresia = Convert.ToInt32(reader["cod_tipo_membresia"].ToString());
                    DateTime fecha_inicio = DateTime.Parse(reader["fecha_inicio"].ToString());
                    DateTime fecha_fin = DateTime.Parse(reader["fecha_fin"].ToString());

                    // Crear un string con los valores y agregarlo a la lista de resultados
                    string resultString = $"cod_tipo_membresia: {cod_tipo_membresia}, fecha_inicio: {fecha_inicio}, fecha_fin: {fecha_fin}";
                    result.Add(resultString);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar las membresias: " + ex);
                throw;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }

            // Convertir la lista de resultados a un array de strings y retornarlo
            return result.ToArray();
        }
    }
}
