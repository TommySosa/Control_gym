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
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEmpleados());
        }

        private void btnTiposMembresia_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new FormTiposMembresias());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new FormProveedores());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new FormProductos());
        }

        private void btnTiposMembresias_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new FormTiposMembresias());
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {

        }
    }
}
