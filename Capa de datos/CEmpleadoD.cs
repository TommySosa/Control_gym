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

    internal class CEmpleadoD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;
        
        // CRUD //

        public void CrearEmpleado(CEmpleado cEmpleado)
        {
            try
            {
                string query = "INSERT INTO Empleados(dni_empleado, nombre, apellido, telefono, fecha_nac, domicilio, email, contraseña) VALUES ('" + cEmpleado.dni_empleado + "','" + cEmpleado.nombre + "','" + cEmpleado.apellido + "','" + cEmpleado.telefono + "','" + cEmpleado.fecha_nac + "','" + cEmpleado.domicilio + "','" + cEmpleado.email + "','" + cEmpleado.contraseña + "')";

                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado agregado correctamente.");
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error al crear el empleado en la CAPA DE DATOS. ", ex);
            }
        }

        public void EditarEmpleado(CEmpleado cEmpleado)
        {
            try
            {
                string query = "UPDATE empleados SET dni_empleado = '" + cEmpleado.dni_empleado + "', nombre = '" + cEmpleado.nombre + "', apellido = '" + cEmpleado.apellido + "', telefono = '" + cEmpleado.telefono + "', fecha_nac = '" + cEmpleado.fecha_nac + "', domicilio = '" + cEmpleado.domicilio + "', email = '" + cEmpleado.email + "', contraseña = '" + cEmpleado.contraseña + "' WHERE cod_empleado = " + cEmpleado.cod_empleado;

                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado actualizado correctamente.");
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error al actualizar el empleado en la CAPA DE DATOS: ", ex);
            }
        }

        public void EliminarEmpleado(int id)
        {
            string query = "delete Empleados where cod_empleado = '" + id + "'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado en la CAPA DE DATOS: " + ex);
            }
        }

        // FIN CRUD //

        public List<CEmpleado> TraerEmpleados()
        {
            List<CEmpleado> Empleados = new List<CEmpleado>();
            string query = "select * from empleados";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CEmpleado Empleado = new CEmpleado
                    {
                        cod_empleado = Convert.ToInt32(reader["cod_empleado"].ToString()),
                        dni_empleado = Convert.ToInt32(reader["dni_empleado"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        apellido = reader["apellido"].ToString(),
                        telefono = reader["telefono"].ToString(),
                        fecha_nac = DateTime.Parse(reader["fecha_nac"].ToString()),
                        domicilio = reader["domicilio"].ToString(),
                        email = reader["email"].ToString(),
                        contraseña = reader["contraseña"].ToString(),
                    };

                    Empleados.Add(Empleado);
                }

                reader.Close();
                return Empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar los Empleados: " + ex);
                throw;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public List<CEmpleado> CargarGrilla()
        {
            List<CEmpleado> Empleados = new List<CEmpleado>();
            string query = "select cod_empleado as 'ID' dni_empleado as 'DNI', nombre as 'Nombre', apellido as 'Apellido', telefono as 'Teléfono', fecha_nac as 'Fecha de Nacimiento',domicilio as 'Domicilio', email as 'E-Mail', contraseña as 'Contraseña' from Empleados";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CEmpleado Empleado = new CEmpleado
                    {
                        cod_empleado = Convert.ToInt32(reader["ID"].ToString()),
                        dni_empleado = Convert.ToInt32(reader["DNI"].ToString()),
                        nombre = reader["Nombre"].ToString(),
                        apellido = reader["Apellido"].ToString(),
                        telefono = reader["Teléfono"].ToString(),
                        fecha_nac = DateTime.Parse(reader["Fecha de Nacimiento"].ToString()),
                        domicilio = reader["Domicilio"].ToString(),
                        email = reader["E-Mail"].ToString(),
                        contraseña = reader["Contraseña"].ToString()
                    };
                    Empleados.Add(Empleado);
                }

                reader.Close();
                return Empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar los Empleados: " + ex);
                throw;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

        public bool DniExiste(int dni)
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
            catch (Exception)
            {
                MessageBox.Show("Error al verificar si el DNI existe.");
                return false;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
    }
}
