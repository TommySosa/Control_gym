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
    public partial class FormTipoProductos : Form
    {
        public FormTipoProductos()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CTipoProducto cTipoProducto = new CTipoProducto();
            int cod = Convert.ToInt32(txtCod.Text);
            string nombre= txtNombre.Text;
            cTipoProducto.EliminarProducto(cod, nombre);
            dgvTipoProducto.DataSource = cTipoProducto.MostrarTipoProducto();

            limpiarCampos();
            cancelarActualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text != ""))
            {
                CTipoProducto cTipoProducto = new CTipoProducto();
                String nombre = txtNombre.Text;
                cTipoProducto.AgregarTipoProducto(nombre);
                dgvTipoProducto.DataSource = cTipoProducto.MostrarTipoProducto();
                limpiarCampos();
                cancelarActualizar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CTipoProducto cTipoProducto = new CTipoProducto();
            int cod = Convert.ToInt32(txtCod.Text);
            String nombre = txtNombre.Text;
            cTipoProducto.ActualizarProducto(cod, nombre);
            dgvTipoProducto.DataSource = cTipoProducto.MostrarTipoProducto();
            limpiarCampos();
            cancelarActualizar();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FormTipoProductos_Load(object sender, EventArgs e)
        {
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;
            btnModificar.Visible = false;

            CTipoProducto cTipoProducto = new CTipoProducto();
            dgvTipoProducto.DataSource = cTipoProducto.MostrarTipoProducto();
        }

        private void cancelarActualizar()
        {
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnAgregar.Visible = true;
            btnCancelar.Visible = false;
        }

        private void limpiarCampos()
        {
            txtCod.Text = "";
            txtNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelarActualizar();
            limpiarCampos();
        }

        private void dgvTipoProducto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTipoProducto.SelectedRows.Count > 0)
            {
                txtCod.Text = dgvTipoProducto.Rows[e.RowIndex].Cells["cod_tipo_producto"].FormattedValue.ToString();

                txtNombre.Text = dgvTipoProducto.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                btnAgregar.Visible = false;
                btnCancelar.Visible = true;
            }
        }
    }
}
