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
    internal class CSociosD
    {
        ConexionBD conexion; 


        public void GuardarSocio(ClsSocio clsSocio)
        {
            ConexionBD conexionBD = ConexionBD.Instancia;
            string query = "INSERT INTO socios(dni_socio,nombre,apellido,telefono,fecha_nac,domicilio,email)VALUES('"+ clsSocio.Dni + "','" + clsSocio.Nombre + "','" + clsSocio.Apellido + "','" + clsSocio.Telefono + "','" + clsSocio.FechaDeNacimiento + "','" + clsSocio.Domicilio + "','" + clsSocio.Email + "')";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.ExecuteNonQuery();
                MessageBox.Show("Socio aderido");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error añadir un nuevo socio" + ex);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
    
    }
}
