using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_datos
{
    internal class CVentaD
    {
        private ConexionBD conexionBD = ConexionBD.Instancia;
        //public void RealizarVenta(CVenta venta)
        //{
        //    string query = "INSERT INTO ventas(dni_cliente, dni_empleado, fecha, descuento) values (@dni_cliente,@dni_empleado,@fecha, @descuento)";
        //    try
        //    {
        //        SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

        //        comando.Parameters.Add(new SqlParameter("@dni_cliente", venta.dni_cliente));
        //        comando.Parameters.Add(new SqlParameter("@dni_empleado", venta.dni_empleado));
        //        comando.Parameters.Add(new SqlParameter("@fecha", venta.fecha));
        //        comando.Parameters.Add(new SqlParameter("@descuento", venta.descuento));

        //        comando.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al realizar la venta." + ex.Message);
        //    }
        //    finally
        //    {
        //        conexionBD.CerrarConexion();
        //    }
        //}

        public void RealizarDetalleVenta(CDetalleVenta detalle)
        {
            string query = "INSERT INTO detalles_ventas(num_venta, cod_producto, subtotal, cantidad) values (@num_venta,@cod_producto, @subtotal, @cantidad)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.Add(new SqlParameter("@num_venta", detalle.num_venta));
                comando.Parameters.Add(new SqlParameter("@cod_producto", detalle.cod_producto));
                comando.Parameters.Add(new SqlParameter("@subtotal", detalle.subtotal));
                comando.Parameters.Add(new SqlParameter("@cantidad", detalle.cantidad));

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta." + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public void RealizarVenta(int dniCliente, int dniEmpleado, decimal descuento, List<CDetalleVenta> detallesVenta)
        {
            try
            {
                //using (SqlConnection connection = new SqlConnection(conexionBD.AbrirConexion())) // Reemplaza con tu cadena de conexión
                //{
                //    connection.Open();

                    // Crear un comando para llamar al procedimiento almacenado
                    using (SqlCommand cmd = new SqlCommand("spRealizarVenta", conexionBD.AbrirConexion()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros necesarios
                        cmd.Parameters.Add(new SqlParameter("@dni_cliente", SqlDbType.Int)).Value = dniCliente;
                        cmd.Parameters.Add(new SqlParameter("@dni_empleado", SqlDbType.Int)).Value = dniEmpleado;
                        cmd.Parameters.Add(new SqlParameter("@descuento", SqlDbType.Decimal)).Value = descuento;

                        // Crear una tabla de detalles de venta (DataTable) y llenarla con los detalles
                        DataTable detallesTable = new DataTable();
                        detallesTable.Columns.Add("cod_producto", typeof(long));
                        detallesTable.Columns.Add("subtotal", typeof(decimal));
                        detallesTable.Columns.Add("cantidad", typeof(int));

                        foreach (var detalle in detallesVenta)
                        {
                            detallesTable.Rows.Add(detalle.cod_producto, detalle.subtotal, detalle.cantidad);
                        }

                        // Agregar el parámetro para los detalles de venta
                        SqlParameter detallesParam = cmd.Parameters.AddWithValue("@detallesVenta", detallesTable);
                        detallesParam.SqlDbType = SqlDbType.Structured;
                        detallesParam.TypeName = "dbo.DETALLES_VENTAS_TYPE"; // Reemplaza con el esquema correcto

                        cmd.ExecuteNonQuery();
                    }
                //}

                MessageBox.Show("Venta realizada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta: " + ex.Message);
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
    }
}
