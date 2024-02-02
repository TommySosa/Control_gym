using Control_Gym.Capa_de_presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym
{
    public partial class FormAdministracion : Form
    {

        public FormAdministracion()
        {
            InitializeComponent();
        }

        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                try
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el formulario: " + ex.Message);
                }
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormEmpleados());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de empleados: " + ex.Message);
            }
        }

        private void btnTiposMembresia_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormTipoMembresia());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de tipos de membresía: " + ex.Message);
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormProveedores());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de proveedores: " + ex.Message);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de productos: " + ex.Message);
            }
        }

        private void btnTiposProducto_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormTipoProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de tipos de productos: " + ex.Message);
            }
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormEmpleados());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario de empleados: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
