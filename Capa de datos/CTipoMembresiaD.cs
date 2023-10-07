using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Gym.Capa_logica;

namespace Control_Gym.Capa_de_datos
{
    internal class CTipoMembresiaD
    {
        public List<CTipoMembresia> traerTipos()
        {
            ConexionBD conexionBD = ConexionBD.Instancia;
            List<CTipoMembresia> tipos_membresias = new List<CTipoMembresia>();
            try
            {
                conexionBD.AbrirConexion();
                string query = "select cod_tipo_membresia, nombre from tipos_membresias";
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        int cod_tipo_membresia = Convert.ToInt32(reader["cod_tipo_membresia"]);
                        string nombre = reader["nombre"].ToString();
                        tipos_membresias.Add(new CTipoMembresia(cod_tipo_membresia, nombre));
                    }
                }
                return tipos_membresias;
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
