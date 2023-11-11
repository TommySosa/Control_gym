﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Gym.Capa_logica;

namespace Control_Gym.Capa_de_datos
{
    internal class CMembresiaD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;

        public bool TieneTipoMembresia(int dni, int cod_tipo)
        {
            string query = "select COUNT(cod_membresia) from membresias where dni_socio = @dni_socio and cod_tipo_membresia = @cod_tipo_membresia;";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.Add(new SqlParameter("@dni_socio", dni));
                comando.Parameters.Add(new SqlParameter("@cod_tipo_membresia", cod_tipo));

                int resultado = (int)comando.ExecuteScalar();

                if (resultado >= 1)
                {
                    return true;    
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex);
                return false;
            }
        }

        public void CrearMembresia(CMembresia cMembresia)
        {
            string query = "INSERT INTO membresias(cod_tipo_membresia, dni_socio, fecha_inicio, fecha_fin) VALUES (@cod_tipo_membresia, @dni_socio, @fecha_inicio, @fecha_fin)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.Add(new SqlParameter("@cod_tipo_membresia", cMembresia.cod_tipo_membresia));
                comando.Parameters.Add(new SqlParameter("@dni_socio", cMembresia.dni_socio));
                comando.Parameters.Add(new SqlParameter("@fecha_inicio", cMembresia.fecha_inicio));
                comando.Parameters.Add(new SqlParameter("@fecha_fin", cMembresia.fecha_fin));

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear la membresia.");
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

        public bool SocioExiste(int dni)
        {
            string query = "SELECT COUNT(*) FROM socios WHERE dni_socio = '" + dni + "'";
			try
			{
				SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
				int resultado = (int)comando.ExecuteScalar();
				if(resultado == 0)
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
				MessageBox.Show("Error al verificar si el socio existe.");
				return false;
			}
			finally
			{
				conexionBD.CerrarConexion();
			}
        }

        public bool EmailExiste(string email)
        {
            string query = "SELECT COUNT(*) FROM socios WHERE email = '" + email + "'";
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
                MessageBox.Show("Error al verificar si el E-mail existe.");
                return false;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }

        }

        public List<CMembresia> TraerMembresias()
        {
            List<CMembresia> membresias = new List<CMembresia>();
            string query = "select * from membresias inner join tipos_membresias on membresias.cod_tipo_membresia = tipos_membresias.cod_tipo_membresia";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CMembresia membresia = new CMembresia
                    {
                        cod_membresia = Convert.ToInt32(reader["cod_membresia"].ToString()),
                        cod_tipo_membresia = Convert.ToInt32(reader["cod_tipo_membresia"].ToString()),
                        dni_socio = Convert.ToInt32(reader["dni_socio"].ToString()),
                        fecha_inicio = DateTime.Parse(reader["fecha_inicio"].ToString()),
                        fecha_fin = DateTime.Parse(reader["fecha_fin"].ToString()),
                        nombre_tipo = reader["nombre"].ToString(),
                        precio_tipo = Convert.ToDecimal(reader["precio"].ToString()),
                        cantidad_dias = Convert.ToInt32(reader["cantidad_dias"].ToString())
                    };

                    membresias.Add(membresia);
                }

                reader.Close();
                return membresias;
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
        }
        public List<CMembresia> CargarGrilla()
        {
            List<CMembresia> membresias = new List<CMembresia>();
            string query = "select cod_membresia as 'ID', dni_socio as 'Dni socio', fecha_inicio as 'Fecha de inicio', fecha_fin as 'Fecha de fin', nombre as 'Tipo de membresia',precio as 'Precio' from membresias inner join tipos_membresias on membresias.cod_tipo_membresia = tipos_membresias.cod_tipo_membresia";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CMembresia membresia = new CMembresia
                    {
                        cod_membresia = Convert.ToInt32(reader["ID"].ToString()),
                        dni_socio = Convert.ToInt32(reader["Dni socio"].ToString()),
                        fecha_inicio = DateTime.Parse(reader["Fecha de inicio"].ToString()),
                        fecha_fin = DateTime.Parse(reader["Fecha de fin"].ToString()),
                        nombre_tipo = reader["Tipo de membresia"].ToString(),
                        precio_tipo = Convert.ToDecimal(reader["Precio"].ToString()),
                    };
                    membresias.Add(membresia);
                }

                reader.Close();
                return membresias;
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
        }

        public void EditarMembresia(CMembresia cMembresia)
        {
            string query = "UPDATE membresias SET cod_tipo_membresia = @cod_tipo_membresia, dni_socio = @dni_socio, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin WHERE cod_membresia = @cod_membresia";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.Add(new SqlParameter("@cod_tipo_membresia", cMembresia.cod_tipo_membresia));
                comando.Parameters.Add(new SqlParameter("@dni_socio", cMembresia.dni_socio));
                comando.Parameters.Add(new SqlParameter("@fecha_inicio", cMembresia.fecha_inicio));
                comando.Parameters.Add(new SqlParameter("@fecha_fin", cMembresia.fecha_fin));
                comando.Parameters.Add(new SqlParameter("@cod_membresia", cMembresia.cod_membresia));

                comando.ExecuteNonQuery();
                MessageBox.Show("Membresía actualizada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la membresía: " + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }


        public void EliminarMembresia(int id)
        {
            string query = "delete membresias where cod_membresia = '" + id + "'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("Membresia eliminada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la membresia" + ex);
            }
        }

        public List<CMembresia> BuscarPorDNI(int dni)
        {

            string query = "select cod_membresia as 'ID', membresias.cod_tipo_membresia as 'ID tipo',dni_socio as 'Dni socio', fecha_inicio as 'Fecha de inicio', fecha_fin as 'Fecha de fin', nombre as 'Tipo de membresia',precio as 'Precio', cantidad_dias as 'Dias de duración' from membresias inner join tipos_membresias on membresias.cod_tipo_membresia = tipos_membresias.cod_tipo_membresia where dni_socio ='" + dni + "'";
            List<CMembresia> membresias = new List<CMembresia>();
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CMembresia membresia = new CMembresia
                    {
                        cod_membresia = Convert.ToInt32(reader["ID"].ToString()),
                        cod_tipo_membresia = Convert.ToInt32(reader["ID tipo"].ToString()),
                        dni_socio = Convert.ToInt32(reader["Dni socio"].ToString()),
                        fecha_inicio = DateTime.Parse(reader["Fecha de inicio"].ToString()),
                        fecha_fin = DateTime.Parse(reader["Fecha de fin"].ToString()),
                        nombre_tipo = reader["Tipo de membresia"].ToString(),
                        precio_tipo = Convert.ToDecimal(reader["Precio"].ToString()),
                        cantidad_dias = Convert.ToInt32(reader["Dias de duración"].ToString())
                    };

                    membresias.Add(membresia);
                }

                reader.Close();
                return membresias;
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
        }
    }
}
