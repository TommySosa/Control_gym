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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }


        private void FormProveedores_Load(object sender, EventArgs e)
        {
            cancelarActualizar();

            ClsProvedores clsProvedores = new ClsProvedores();
            dgvProveedores.DataSource = clsProvedores.CargarDatos();
        }

        private void dgvProveedores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsProvedores clsProvedores = new ClsProvedores();

            string nombre = txtNombre.Text;
            string cuit = txtCuit.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;

            clsProvedores.AgregarProv(nombre, cuit, telefono, direccion, email);
            dgvProveedores.DataSource = clsProvedores.CargarDatos();

            limpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsProvedores clsProvedores = new ClsProvedores();

            string cod = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string cuit = txtCuit.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;

            clsProvedores.ModificarProv(cod,nombre, cuit, telefono, direccion, email);
            dgvProveedores.DataSource = clsProvedores.CargarDatos();

            limpiarCampos();
            cancelarActualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsProvedores clsProvedores = new ClsProvedores();
            string cod = txtCodigo.Text;
            string nombre = txtNombre.Text;
            clsProvedores.EliminarDatos(cod, nombre);
            dgvProveedores.DataSource = clsProvedores.CargarDatos();

            limpiarCampos();
            cancelarActualizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cancelarActualizar();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            ClsProvedores clsProvedores = new ClsProvedores();
            if (txtBuscar.Text != "")
            {
                string cod = txtBuscar.Text;
                dgvProveedores.DataSource = clsProvedores.Filtrar(cod);
            }
            else
            {
                dgvProveedores.DataSource = clsProvedores.CargarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClsProvedores clsProvedores = new ClsProvedores();


            if (txtBuscar.Text != "")
            {
                string cod = txtBuscar.Text;
                dgvProveedores.DataSource = clsProvedores.Filtrar(cod);
            }
            else
            {
                clsProvedores.CargarDatos();
            }
        }
    }
}
