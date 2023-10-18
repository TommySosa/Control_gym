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
    public partial class FormAcceso : Form
    {
        private CAcceso cAcceso = new CAcceso();
        private CAccesoD cAccesoD = new CAccesoD();
        public FormAcceso()
        {
            InitializeComponent();
        }
        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void FormAcceso_Load(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            CAcceso cAcc = new CAcceso(Convert.ToInt32(txtDniEmpleado.Text), txtContraseñaEmpleado.Text);
            List<CAcceso> acceso = cAcceso.Login(cAcc);

            if (acceso[0] != null)
            {
                MessageBox.Show("Datos de acceso: " + acceso[0].dni_empleado + "contraseña" + acceso[0].contraseña);
            }
            else
            {
                MessageBox.Show("Datos incorrectos.");
            }
        }

        private void txtDniEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
