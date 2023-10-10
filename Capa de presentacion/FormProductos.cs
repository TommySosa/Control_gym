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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void lvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboProductos.Text = "(Seleccione producto)";
            cboTipo.Text = "(Seleccione tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("ARS");
            cboProductos.Focus();
        }

        double precio = 0;
        private void FormProductos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("ARS");
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProductos.Text;

            if (producto.Equals("Producto1")) precio = 250;
            if (producto.Equals("Producto2")) precio = 450;
            if (producto.Equals("Producto3")) precio = 650;

            lblPrecio.Text = precio.ToString("ARS");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validacion
            if (cboProductos.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar una cantidad!");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de pago!");
            else
            {
                string producto = cboProductos.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;

                double subtotal = cantidad * precio;
                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double precioFinal = subtotal - descuento + recargo;

                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());

                lvVenta.Items.Add(fila);
                btnCancelar_Click(sender, e);
            }
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
