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
            long cod_producto = long.Parse(txtCodigoProducto.Text);
            int cod_proveedor = Convert.ToInt32(txtCodProveedor.Text);
            int cod_tipo_producto = Convert.ToInt32(txtTipoP.Text);
            string nombre = txtNombre.Text;
            DateTime fecha_venc = dtpFechaVenc.Value;
            decimal precioventa = Convert.ToDecimal(txtPrecioVenta.Text);
            decimal preciocosto = Convert.ToDecimal(txtCosto.Text);
            decimal ganancia = Convert.ToDecimal(txtGanancia.Text);
            int stock = Convert.ToInt32(txtStock.Text);
           

            CProductoD.GuardarProducto(cod_producto, cod_proveedor, cod_tipo_producto, nombre, fecha_venc, precioventa, preciocosto, ganancia, stock);
            dgvProductos.DataSource = CProductoD.MostrarDatos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            CProducto CProductoD = new CProducto();
            Int64 cod_producto = Convert.ToInt64(txtCodigoProducto.Text);
            int cod_proveedor = Convert.ToInt32(txtCodProveedor.Text);
            int cod_tipo_producto = Convert.ToInt32(cmbCodTipoProducto.Text);
            string cod = txtCod.Text;
            string nombre = txtNombre.Text;
            DateTime fecha_venc = dtpFechaVenc.Value;
            decimal precioventa = Convert.ToDecimal(txtPrecioVenta.Text);
            decimal preciocosto = Convert.ToDecimal(txtCosto.Text);
            decimal ganancia = Convert.ToDecimal(txtGanancia.Text);
            int stock = Convert.ToInt32(txtStock.Text);

            CProducto CproductoD = new CProducto();
            CProductoD.ModificarProducto(cod, cod_producto, cod_proveedor, cod_tipo_producto, nombre, fecha_venc, precioventa, preciocosto, ganancia, stock);
            dgvProductos.DataSource = CProductoD.MostrarDatos();
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  txtCodigoProducto.Text = dgvProductos.SelectedCells[0].Value.ToString();
          //  txtCodProveedor.Text = dgvProductos.SelectedCells[1].Value.ToString();
          //  cmbCodTipoProducto.Text = dgvProductos.SelectedCells[2].Value.ToString();
          //  txtNombre.Text = dgvProductos.SelectedCells[3].Value.ToString();
          //  txtPrecioVenta.Text = dgvProductos.SelectedCells[5].Value.ToString();
          //  txtCosto.Text = dgvProductos.SelectedCells[6].Value.ToString();
          //  txtGanancia.Text = dgvProductos.SelectedCells[7].Value.ToString();
          //  txtStock.Text = dgvProductos.SelectedCells[8].Value.ToString();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CProducto CProductoD = new CProducto();
            string cod = txtCod.Text;
            string nombre = txtNombre.Text;
            CProductoD.EliminarProducto(cod, nombre);


            txtCodProducto.Text = "";
            cmbCodTipoProducto.Text = "";
            txtCodProveedor.Text = "";
            txtCod.Text = "";
            txtNombre.Text = "";
            dtpFechaVenc.Text ="";
            txtPrecioVenta.Text = "";
            txtCosto.Text = "";
            txtGanancia.Text = "";
            txtStock.Text = "";
            dgvProductos.DataSource = CProductoD.MostrarDatos();
        }
    }
}
