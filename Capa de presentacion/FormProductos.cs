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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CProducto CProductoD = new CProducto();
            dgvProductos.DataSource = CProductoD.MostrarDatos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CProducto CProductoD = new CProducto();
            string nombre = txtNombre.Text;
            int fecha_venc = Convert.ToInt32(txtFechaVencimiento.Text);
            double precioventa = Convert.ToDouble(txtPrecioVenta.Text);
            double preciocosto = Convert.ToDouble(txtCosto.Text);
            double ganancia = Convert.ToDouble(txtGanancia.Text);
            int stock = Convert.ToInt32(txtStock.Text);
           

            CProductoD.GuardarProducto(nombre, fecha_venc, precioventa, preciocosto, ganancia, stock);
            dgvProductos.DataSource = CProductoD.MostrarDatos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            CProducto CProductoD = new CProducto();
            int cod = Convert.ToInt32(txtCod.Text);
            string nombre = txtNombre.Text;
            int fecha_venc = Convert.ToInt32(txtFechaVencimiento.Text);
            double precioventa = Convert.ToDouble(txtPrecioVenta.Text);
            double preciocosto = Convert.ToDouble(txtCosto.Text);
            double ganancia = Convert.ToDouble(txtGanancia.Text);
            int stock = Convert.ToInt32(txtStock.Text);

            CProducto CproductoD = new CProducto();
            CProductoD.ModificarProducto(cod, nombre, fecha_venc, precioventa, preciocosto, ganancia, stock);
            dgvProductos.DataSource = CProductoD.MostrarDatos();
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvProductos.SelectedCells[0].Value.ToString();
            txtFechaVencimiento.Text = dgvProductos.SelectedCells[1].Value.ToString();
            txtPrecioVenta.Text = dgvProductos.SelectedCells[2].Value.ToString();
            txtCosto.Text = dgvProductos.SelectedCells[3].Value.ToString();
            txtGanancia.Text = dgvProductos.SelectedCells[5].Value.ToString();
            txtStock.Text = dgvProductos.SelectedCells[6].Value.ToString();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CProducto CProductoD = new CProducto();
            int cod = Convert.ToInt32(txtCod.Text);
            string nombre = txtNombre.Text;
            CProducto.EliminarProducto(cod, nombre);

            txtCod.Text = "";
            txtNombre.Text = "";
            txtFechaVencimiento.Text = "";
            txtPrecioVenta.Text = "";
            txtCosto.Text = "";
            txtGanancia.Text = "";
            txtStock.Text = "";
            dgvProductos.DataSource = CProductoD.MostrarDatos();
        }
    }
}
