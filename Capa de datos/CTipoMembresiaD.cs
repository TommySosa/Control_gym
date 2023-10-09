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
                string query = "select * from tipos_membresias";
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        int cod_tipo_membresia = Convert.ToInt32(reader["cod_tipo_membresia"]);
                        string nombre = reader["nombre"].ToString();
                        int cantidadDias = Convert.ToInt32(reader["cantidad_dias"]);

                        CTipoMembresia tipoMembresia = new CTipoMembresia(cod_tipo_membresia, nombre);
                        tipoMembresia.cantidad_dias = cantidadDias;
                        tipos_membresias.Add(tipoMembresia);
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
