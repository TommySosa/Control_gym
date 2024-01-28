using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_presentacion
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            cancelarActualizar();

            try
            {
                ClsProvedores clsProvedores = new ClsProvedores();
                dgvProveedores.DataSource = clsProvedores.CargarDatos();
                dgvProveedores.Columns[0].HeaderText = "Código";
                dgvProveedores.Columns[1].HeaderText = "Nombre";
                dgvProveedores.Columns[2].HeaderText = "CUIT";
                dgvProveedores.Columns[3].HeaderText = "Teléfono";
                dgvProveedores.Columns[4].HeaderText = "Dirección";
                dgvProveedores.Columns[5].HeaderText = "E-mail";
                dgvProveedores.AutoResizeColumns();
                dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProveedores.Columns[0].Width = 50;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void dgvProveedores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnAgregar.Visible = false;
                btnCancelar.Visible = true;
                btnEliminar.Visible = true;
                btnModificar.Visible = true;

                txtCodigo.Text = dgvProveedores.Rows[e.RowIndex].Cells["cod_proveedor"].FormattedValue.ToString();
                txtNombre.Text = dgvProveedores.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                txtCuit.Text = dgvProveedores.Rows[e.RowIndex].Cells["cuit"].FormattedValue.ToString();
                txtTelefono.Text = dgvProveedores.Rows[e.RowIndex].Cells["telefono"].FormattedValue.ToString();
                txtDireccion.Text = dgvProveedores.Rows[e.RowIndex].Cells["direccion"].FormattedValue.ToString();
                txtEmail.Text = dgvProveedores.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del proveedor: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtCuit.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && txtEmail.Text != "")
                {
                    ClsProvedores clsProvedores = new ClsProvedores();

                    string nombre = txtNombre.Text.Trim();
                    string cuit = txtCuit.Text;
                    string telefono = txtTelefono.Text;
                    string direccion = txtDireccion.Text.Trim();
                    string email = txtEmail.Text.Trim();

                    clsProvedores.AgregarProv(nombre, cuit, telefono, direccion, email);
                    dgvProveedores.DataSource = clsProvedores.CargarDatos();

                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor complete todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar proveedor: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProvedores clsProvedores = new ClsProvedores();

                string cod = txtCodigo.Text;
                string nombre = txtNombre.Text;
                string cuit = txtCuit.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                string email = txtEmail.Text;

                clsProvedores.ModificarProv(cod, nombre, cuit, telefono, direccion, email);
                dgvProveedores.DataSource = clsProvedores.CargarDatos();

                limpiarCampos();
                cancelarActualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar proveedor: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProvedores clsProvedores = new ClsProvedores();
                string cod = txtCodigo.Text;
                string nombre = txtNombre.Text;
                clsProvedores.EliminarDatos(cod, nombre);
                dgvProveedores.DataSource = clsProvedores.CargarDatos();

                limpiarCampos();
                cancelarActualizar();
            }
            catch (Exception ex)
            {
                if (ex is SqlException sqlException && sqlException.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar el tipo de producto porque tiene productos relacionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el tipo de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarCampos();
                cancelarActualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar la operación: " + ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCuit.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
        }

        private void cancelarActualizar()
        {
            btnAgregar.Visible = true;
            btnCancelar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar) || e.KeyChar == '-') || Char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Solo números y guion medio permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtCuit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtCodigo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtNombre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtCuit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtTelefono_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtDireccion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }
    }
}
