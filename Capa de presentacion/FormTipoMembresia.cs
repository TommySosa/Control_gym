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
            ClsTipoMembresia clsTipoMembresia = new ClsTipoMembresia();


            string nombre = txtNombre.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int dias = Convert.ToInt32(txtDias.Text);
    

            clsTipoMembresia.AgregarTipo(nombre, precio, dias );
            dgvTipoMembresia.DataSource = clsTipoMembresia.CargarDatos();

            cancelarActualizar();
            limpiarCampos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsTipoMembresia clsTipoMembresia = new ClsTipoMembresia();

            string cod = txtCod.Text;
            string nombre = txtNombre.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int dias = Convert.ToInt32(txtDias.Text);

            clsTipoMembresia.ModificarTipo(cod,nombre, precio, dias);
            dgvTipoMembresia.DataSource = clsTipoMembresia.CargarDatos();

            cancelarActualizar();
            limpiarCampos();
        }


        private void FormTipoMembresia_Load(object sender, EventArgs e)
        {
            cancelarActualizar();

            ClsTipoMembresia clsTipoMembresia = new ClsTipoMembresia();
            dgvTipoMembresia.DataSource = clsTipoMembresia.CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsTipoMembresia clsTipo = new ClsTipoMembresia();
            string cod = txtCod.Text;
            string nombre = txtNombre.Text;
            clsTipo.EliminarDatos(cod, nombre);


            cancelarActualizar();
            limpiarCampos();

            dgvTipoMembresia.DataSource = clsTipo.CargarDatos();
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
            txtBuscar.Text = "";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ClsTipoMembresia clsTipo = new ClsTipoMembresia();
            if (txtBuscar.Text != "")
            {
                string cod = txtBuscar.Text;
                dgvTipoMembresia.DataSource = clsTipo.Filtrar(cod);
            }
            else
            {
                dgvTipoMembresia.DataSource = clsTipo.CargarDatos();
            }
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
    }
}
