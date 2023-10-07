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
    internal class CMembresiaD
    {
        public void CrearMembresia(CMembresia cMembresia)
        {
            ConexionBD conexionBD = ConexionBD.Instancia;
            string query = "insert into membresias(cod_tipo_membresia, dni_socio, fecha_inicio, fecha_fin) values('" + cMembresia.cod_tipo_membresia + "','" + cMembresia.dni_socio + "','" + cMembresia.fecha_inicio + "','" + cMembresia.fecha_fin + "')";
			try
			{
				SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

				comando.ExecuteNonQuery();
				MessageBox.Show("Membresia creada correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al crear la membresia"+ ex);
			}
			finally
			{
				conexionBD.CerrarConexion();
			}
        }

    }
}
