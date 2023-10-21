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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           ClsProvedores clsProvedores = new ClsProvedores();

            
            string nombre = txtNombre.Text;
            string cuit = txtCuit.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;

            clsProvedores.AgregarProv( nombre, cuit, telefono, direccion, email);
            dgvProveedores.DataSource = clsProvedores.CargarDatos();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ClsProvedores clsProvedores = new ClsProvedores();

            dgvProveedores.DataSource = clsProvedores.CargarDatos();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProveedores.Rows[e.RowIndex].Cells["cod_proveedor"].FormattedValue.ToString();
            txtNombre.Text = dgvProveedores.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
            txtCuit.Text = dgvProveedores.Rows[e.RowIndex].Cells["cuit"].FormattedValue.ToString();
            txtTelefono.Text = dgvProveedores.Rows[e.RowIndex].Cells["telefono"].FormattedValue.ToString();
            txtDireccion.Text = dgvProveedores.Rows[e.RowIndex].Cells["direccion"].FormattedValue.ToString();
            txtEmail.Text = dgvProveedores.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsProvedores clsProvedores = new ClsProvedores();
            string cod = txtCodigo.Text;
            string nombre = txtNombre.Text;
            clsProvedores.EliminarDatos(cod, nombre);


            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCuit.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            dgvProveedores.DataSource = clsProvedores.CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCuit.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
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
