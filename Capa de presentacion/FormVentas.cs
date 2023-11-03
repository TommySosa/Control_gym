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
        private int dni_empleado;
        private string nombre;
        public FormVentas(int dni_empleado, string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.dni_empleado = dni_empleado;
        }
        private CVenta cVenta = new CVenta();
        private CProducto cProducto = new CProducto();

        private void FormVentas_Load(object sender, EventArgs e)
        {
            try
            {
                List<CProducto> productos = cProducto.traerProductos();
                cbCodProducto.DataSource = productos;
                btnQuitar.Visible = false;
                txtNombreProducto.Text = "";
                txtPrecio.Text = "";
                txtSubtotal.Text = "";
                txtDniEmpleado.Text = dni_empleado.ToString();

                txtStock.Text = "";

                txtCodProducto.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private decimal CalcultarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dvgCarrito.Rows)
            {
                decimal subtotal = 0;
                if (row.Cells["subtotal_producto"].Value != null)
                {

                    if (decimal.TryParse(row.Cells["subtotal_producto"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }
            return total;
        }

        private decimal CalcularTodosSubtotales()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dvgCarrito.Rows)
            {
                if (row.Cells["subtotal_producto"].Value != null)
                {
                    decimal subtotal = 0;

                    if (decimal.TryParse(row.Cells["subtotal_producto"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            return total;
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProducto.Text != "" && txtNombreProducto.Text != "" && txtPrecio.Text != "" && txtCantidad.Text != "" && txtStock.Text != "")
                {
                    decimal subtotal = 0;
                    bool productoExistente = false;

                    foreach (DataGridViewRow row in dvgCarrito.Rows)
                    {
                        if (row.Cells["cod_producto"].Value != null)
                        {
                            long codigoExistente;
                            if (long.TryParse(row.Cells["cod_producto"].Value.ToString(), out codigoExistente) && codigoExistente == long.Parse(txtCodProducto.Text))
                            {
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
                        dvgCarrito.Rows.Add(txtCodProducto.Text, txtNombreProducto.Text, txtPrecio.Text, txtCantidad.Text, txtStock.Text, txtSubtotal.Text);
                    }

                    foreach (DataGridViewRow row in dvgCarrito.Rows)
                    {
                        if (row.Cells["precio_producto"].Value != null && row.Cells["cantidad"].Value != null)
                        {
                            decimal precio = 0;
                            int cantidad = 0;
                            decimal descuento = 0;

                            if (decimal.TryParse(row.Cells["precio_producto"].Value.ToString(), out precio) &&
                                int.TryParse(row.Cells["cantidad"].Value.ToString(), out cantidad) && decimal.TryParse(txtDescuento.Text, out descuento))
                            {
                                subtotal = (precio - (precio * descuento / 100)) * cantidad;
                                row.Cells["subtotal_producto"].Value = subtotal;
                            }
                        }
                    }
                    lblTotal.Text = "$ " + CalcularTodosSubtotales().ToString();

                    txtSubtotal.Text = CalcultarTotal().ToString();
                }
                else
                {
                    MessageBox.Show("Llená todos los campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar al carrito: " + ex.Message);
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int dniCliente, dniEmpleado;
                decimal descuento;

                if (int.TryParse(txtDniCliente.Text, out dniCliente) && int.TryParse(txtDniEmpleado.Text, out dniEmpleado) &&
                    decimal.TryParse(txtDescuento.Text, out descuento) && Convert.ToInt32(txtPrecio.Text) > 0)
                {
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
                                int.TryParse(row.Cells["cantidad"].Value.ToString(), out cantidad)
                            )
                            {
                                subtotal += precio * cantidad;
                                CDetalleVenta detalle = new CDetalleVenta
                                {
                                    cod_producto = codProducto,
                                    subtotal = (precio - (precio * descuento / 100)) * cantidad,
                                    cantidad = cantidad,
                                    descuento = descuento
                                };
                                detallesVenta.Add(detalle);
                            }
                        }
                    }

                    decimal total = CalcularTodosSubtotales();

                    bool ventaExitosa = cVenta.RealizarVenta(dniCliente, dniEmpleado, descuento, total, detallesVenta);

                    if (!ventaExitosa)
                    {
                        MessageBox.Show("No hay suficiente stock disponible para completar la venta.");
                    }
                    else
                    {
                        MessageBox.Show("Venta realizada con éxito.");
                        List<CProducto> productos = cProducto.traerProductos();
                        Limpiar();

                        cbCodProducto.DataSource = productos;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos de DNI y Descuento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta: " + ex.Message);
            }
        }

        public void Limpiar()
        {
            if (dvgCarrito.Rows.Count > 0)
            {
                dvgCarrito.ClearSelection();

                dvgCarrito.Rows.Clear();
                lblTotal.Text = "$ 0.00";
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
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
                    MessageBox.Show("Debes ingresar el DNI del cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar cliente: " + ex.Message);
            }
        }

        private void cbCodProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CProducto cProducto = new CProducto();
                if (cbCodProducto.SelectedItem != null)
                {
                    CProducto productoSeleccionado = (CProducto)cbCodProducto.SelectedItem;
                    long cod_producto = productoSeleccionado.cod_producto;
                    cProducto.cod_producto = cod_producto;

                    txtNombreProducto.Text = productoSeleccionado.nombre;
                    txtCodProducto.Text = productoSeleccionado.cod_producto.ToString();
                    txtPrecio.Text = productoSeleccionado.precio_venta.ToString();
                    txtStock.Text = productoSeleccionado.stock.ToString();
                    txtSubtotal.Text = "$ " + CalcultarTotal().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar producto: " + ex.Message);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgCarrito.SelectedRows.Count > 0)
                {
                    dvgCarrito.Rows.Remove(dvgCarrito.SelectedRows[0]);
                    lblTotal.Text = "$ " + CalcularTodosSubtotales().ToString();
                }
                else
                {
                    MessageBox.Show("Selecciona una fila");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar elemento del carrito: " + ex.Message);
            }
        }

        private void dvgCarrito_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dvgCarrito.SelectedRows.Count > 0)
            {
                btnQuitar.Visible = true;
            }
        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodProducto.Text))
                {
                    long codigo = Convert.ToInt64(txtCodProducto.Text);
                    CProducto producto = cVenta.BuscarPorCod(codigo);
                    if (producto != null)
                    {
                        lblNoEncontrado.Visible = false;
                        txtNombreProducto.Text = producto.nombre;
                        txtPrecio.Text = producto.precio_venta.ToString();
                        txtStock.Text = producto.stock.ToString();
                        txtSubtotal.Text = "$ " + CalcultarTotal().ToString();
                    }
                    else
                    {
                        lblNoEncontrado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message);
            }
        }

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
