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
    public partial class FormVerDetalle : Form
    {
        private CVenta cVenta = new CVenta();
        public FormVerDetalle(int num_venta)
        {
            InitializeComponent();
            lblNumVenta.Text = num_venta.ToString();
            dgvDetalle.DataSource= cVenta.traerDetalles(num_venta);

            dgvDetalle.Columns[0].HeaderText = "N° Venta";
            dgvDetalle.Columns[1].HeaderText = "Cod. Producto";
            dgvDetalle.Columns[2].HeaderText = "Producto";
            dgvDetalle.Columns[3].HeaderText = "Cantidad";
            dgvDetalle.Columns[4].HeaderText = "Precio";
            dgvDetalle.Columns[5].HeaderText = "Descuento %";
            dgvDetalle.Columns[6].HeaderText = "Subtotal";
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormVerDetalle_Load(object sender, EventArgs e)
        {
        }
    }
}
