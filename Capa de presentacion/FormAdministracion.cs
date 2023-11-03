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
    }
}
