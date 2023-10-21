using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_presentacion
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }
        private CDetalleVenta cDetalle = new CDetalleVenta();
        private CVenta cVenta = new CVenta();

        private void FormVentas_Load(object sender, EventArgs e)
        {
            //dvgCarrito.Rows.Add("Test", "Test 2", "Test 3");
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (txtCodProducto.Text != "" && txtNombreProducto.Text != "" && txtPrecio.Text != "" && txtCantidad.Text != "")
            {
                decimal subtotal = 0; // Inicializa el subtotal a cero
                bool productoExistente = false;

                // Busca el código del producto en las filas existentes
                foreach (DataGridViewRow row in dvgCarrito.Rows)
                {
                    if (row.Cells["cod_producto"].Value != null)
                    {
                        long codigoExistente;
                        if (long.TryParse(row.Cells["cod_producto"].Value.ToString(), out codigoExistente) && codigoExistente == long.Parse(txtCodProducto.Text))
                        {
                            // El producto ya existe en el carrito, actualiza la cantidad
                            int cantidadExistente = int.Parse(row.Cells["cantidad"].Value.ToString());
                            int nuevaCantidad = int.Parse(txtCantidad.Text);
                            cantidadExistente += nuevaCantidad;
                            row.Cells["cantidad"].Value = cantidadExistente;
                            productoExistente = true;
                            break;
                        }
                    }
                }

                if (!productoExistente)
                {
                    // El producto no existe en el carrito, agrega una nueva fila
                    dvgCarrito.Rows.Add(txtCodProducto.Text, txtNombreProducto.Text, txtPrecio.Text, txtCantidad.Text);
                }

                // Calcular el subtotal para todas las filas
                foreach (DataGridViewRow row in dvgCarrito.Rows)
                {
                    if (row.Cells["precio_producto"].Value != null && row.Cells["cantidad"].Value != null)
                    {
                        decimal precio = 0;
                        int cantidad = 0;

                        // Intenta convertir los valores de las celdas en números
                        if (decimal.TryParse(row.Cells["precio_producto"].Value.ToString(), out precio) &&
                            int.TryParse(row.Cells["cantidad"].Value.ToString(), out cantidad))
                        {
                            subtotal += precio * cantidad;
                        }
                    }
                }

                // Actualiza el valor del subtotal después de calcularlo
                txtSubtotal.Text = subtotal.ToString();
            }
            else
            {
                MessageBox.Show("Llená todos los campos.");
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            int dniCliente, dniEmpleado;
            decimal descuento;

            if (int.TryParse(txtDniCliente.Text, out dniCliente) && int.TryParse(txtDniEmpleado.Text, out dniEmpleado) &&
                decimal.TryParse(txtDescuento.Text, out descuento))
            {
                // Crear una lista para almacenar los detalles de ventas
                List<CDetalleVenta> detallesVenta = new List<CDetalleVenta>();
                decimal subtotal = 0;

                foreach (DataGridViewRow row in dvgCarrito.Rows)
                {
                    if (row.Cells["cod_producto"].Value != null &&
                        row.Cells["precio_producto"].Value != null &&
                        row.Cells["cantidad"].Value != null)
                    {
                        long codProducto;
                        decimal precio;
                        int cantidad;

                        if (long.TryParse(row.Cells["cod_producto"].Value.ToString(), out codProducto) &&
                            decimal.TryParse(row.Cells["precio_producto"].Value.ToString(), out precio) &&
                            int.TryParse(row.Cells["cantidad"].Value.ToString(), out cantidad))
                        {
                            subtotal += precio * cantidad;
                            CDetalleVenta detalle = new CDetalleVenta
                            {
                                cod_producto = codProducto,
                                subtotal = precio * cantidad,
                                cantidad = cantidad
                            };
                            detallesVenta.Add(detalle);
                        }
                    }
                }

                txtSubtotal.Text = subtotal.ToString();
                cVenta.RealizarVenta(dniCliente, dniEmpleado, descuento, detallesVenta);

            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos de DNI y Descuento.");
            }

            // Llamar al procedimiento almacenado para realizar la venta
            //cVenta.RealizarVenta(dniCliente, dniEmpleado, descuento, detallesVenta);
            //foreach (DataGridViewRow row in dvgCarrito.Rows)
            //{
            //    if (!row.IsNewRow) 
            //    {
            //        int cod_producto = Convert.ToInt32(row.Cells["cod_producto"].Value);
            //        //string nombre = row.Cells["nombre"].Value.ToString();
            //        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
            //        decimal subtotal = 4000;
            //        int num_venta = 1;

            //        CDetalleVenta cDetalleVenta = new CDetalleVenta(num_venta,cod_producto,subtotal,cantidad);

            //        cVenta.RealizarDetalleVenta(cDetalleVenta);
            //    }
            //}
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            CVentaD cVentaD = new CVentaD();
            if (txtDniCliente.Text != "")
            {
                bool existe = cVentaD.ClienteExiste(Convert.ToInt32(txtDniCliente.Text));
                if (existe)
                {
                    MessageBox.Show("El cliente SI está registrado");
                }
                else
                {
                    FormAgregarCliente agregarClienteForm = new FormAgregarCliente();

                    DialogResult result = agregarClienteForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string dniCliente = agregarClienteForm.DniCliente;
                        string nombre = agregarClienteForm.Nombre;
                        string apellido = agregarClienteForm.Apellido;
                        string telefono = agregarClienteForm.Telefono;
                        string domicilio = agregarClienteForm.Domicilio;
                        string email = agregarClienteForm.Email;
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar el dni del cliente!");
            }
        }
    }
}
