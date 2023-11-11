﻿using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_datos
{
    internal class CVentaD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;
        private bool VerificarStock(long cod_producto,int cantidad)
        {
            string query = "select stock from productos where cod_producto ='"+cod_producto+"'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                int resultado = (int)comando.ExecuteScalar();
                if (resultado < cantidad)
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
                MessageBox.Show("Error al verificar comprobar el stock.");
                return false;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }

        }

        public bool RealizarVenta(int dniCliente, int dniEmpleado, decimal descuento, decimal total, List<CDetalleVenta> detallesVenta)
        {
            try
            {
                conexionBD.AbrirConexion();

                SqlCommand cmd = new SqlCommand("spRealizarVenta", conexionBD.AbrirConexion());
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@dni_cliente", SqlDbType.Int)).Value = dniCliente;
                cmd.Parameters.Add(new SqlParameter("@dni_empleado", SqlDbType.Int)).Value = dniEmpleado;
                cmd.Parameters.Add(new SqlParameter("@descuento", SqlDbType.Decimal)).Value = descuento;
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal)).Value = total;

                DataTable detallesTable = new DataTable();
                detallesTable.Columns.Add("cod_producto", typeof(long));
                detallesTable.Columns.Add("subtotal", typeof(decimal));
                detallesTable.Columns.Add("cantidad", typeof(int));
                detallesTable.Columns.Add("descuento", typeof(decimal));

                bool haySuficienteStock = true;

                foreach (var detalle in detallesVenta)
                {
                   if (VerificarStock(detalle.cod_producto, detalle.cantidad))
                   {
                       detallesTable.Rows.Add(detalle.cod_producto, detalle.subtotal, detalle.cantidad, detalle.descuento);
                   }
                   else
                   {
                      haySuficienteStock = false;
                      break;
                   }
                }

                if (!haySuficienteStock)
                {
                   return false; 
                }

                SqlParameter detallesParam = cmd.Parameters.AddWithValue("@detallesVenta", detallesTable);
                detallesParam.SqlDbType = SqlDbType.Structured;
                detallesParam.TypeName = "dbo.DETALLES_VENTAS_TYPE"; 

                conexionBD.AbrirConexion();
                cmd.ExecuteNonQuery();
                

                conexionBD.CerrarConexion();

                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 51000 || ex.ErrorCode == 51000)
                {
                    MessageBox.Show("No hay suficiente stock");
                }
                else
                {
                    MessageBox.Show("Hubo un error inesperado");
                }
                return false;
            }
        }

        public bool ClienteExiste(int dni)
        {
            string query = "SELECT COUNT(*) FROM clientes WHERE dni_cliente = '" + dni + "'";
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
                MessageBox.Show("Error al verificar si el cliente existe.");
                return false;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }          

        }

        public CProducto BuscarPorCod(long cod)
        {
            string query = "SELECT * FROM productos WHERE cod_producto = @cod";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());
                comando.Parameters.AddWithValue("@cod", cod);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    CProducto producto = new CProducto
                    {
                        cod_producto = Convert.ToInt32(reader["cod_producto"]),
                        cod_proveedor = Convert.ToInt32(reader["cod_proveedor"]),
                        cod_tipo_producto = Convert.ToInt32(reader["cod_tipo_producto"]),
                        nombre = reader["nombre"].ToString(),
                        fecha_venc = DateTime.Parse(reader["fecha_venc"].ToString()),
                        precio_costo = Convert.ToDecimal(reader["precio_costo"]),
                        precio_venta = Convert.ToDecimal(reader["precio_venta"]),
                        ganancia = Convert.ToInt32(reader["ganancia"]),
                        stock = Convert.ToInt32(reader["stock"])
                    };

                    reader.Close();
                    return producto;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al buscar el producto: " + ex.Message);
                throw;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

    }
}
