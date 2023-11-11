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
    public partial class FormTipoMembresia : Form
    {
        public FormTipoMembresia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtPrecio.Text != "" && txtDias.Text != "")
                {
                    ClsTipoMembresia clsTipoMembresia = new ClsTipoMembresia();

                    string nombre = txtNombre.Text.Trim();
                    decimal precio = Convert.ToDecimal(txtPrecio.Text);
                    int dias = Convert.ToInt32(txtDias.Text);

                    clsTipoMembresia.AgregarTipo(nombre, precio, dias);
                    dgvTipoMembresia.DataSource = clsTipoMembresia.CargarDatos();

                    cancelarActualizar();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor complete todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tipo de membresía: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsTipoMembresia clsTipoMembresia = new ClsTipoMembresia();

                string cod = txtCod.Text;
                string nombre = txtNombre.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int dias = Convert.ToInt32(txtDias.Text);

                clsTipoMembresia.ModificarTipo(cod, nombre, precio, dias);
                dgvTipoMembresia.DataSource = clsTipoMembresia.CargarDatos();

                cancelarActualizar();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el tipo de membresía: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTipoMembresia_Load(object sender, EventArgs e)
        {
            cancelarActualizar();

            ClsTipoMembresia clsTipoMembresia = new ClsTipoMembresia();
            dgvTipoMembresia.DataSource = clsTipoMembresia.CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsTipoMembresia clsTipo = new ClsTipoMembresia();
                string cod = txtCod.Text;
                string nombre = txtNombre.Text;
                clsTipo.EliminarDatos(cod, nombre);

                cancelarActualizar();
                limpiarCampos();

                dgvTipoMembresia.DataSource = clsTipo.CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el tipo de membresía: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelarActualizar();
            limpiarCampos();
        }

        private void cancelarActualizar()
        {
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void limpiarCampos()
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDias.Text = "";
        }

        private void dgvTipoMembresia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnCancelar.Visible = true;

            txtCod.Text = dgvTipoMembresia.Rows[e.RowIndex].Cells["cod_tipo_membresia"].FormattedValue.ToString();
            txtNombre.Text = dgvTipoMembresia.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
            txtPrecio.Text = dgvTipoMembresia.Rows[e.RowIndex].Cells["precio"].FormattedValue.ToString();
            txtDias.Text = dgvTipoMembresia.Rows[e.RowIndex].Cells["cantidad_dias"].FormattedValue.ToString();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtDias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtPrecio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtDias_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }
    }
}
