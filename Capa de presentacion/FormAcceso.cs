using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        public string dni_empleado
        {
            get { return txtDniEmpleado.Text; }
            set { txtDniEmpleado.Text = value; }
        }

        public string contraseña
        {
            get { return txtContraseñaEmpleado.Text; }
            set { txtContraseñaEmpleado.Text = value; }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtDniEmpleado.Text != "" && txtContraseñaEmpleado.Text != "")
            {
                CAcceso cAcc = new CAcceso(Convert.ToInt32(txtDniEmpleado.Text), txtContraseñaEmpleado.Text);
                List<CAcceso> acceso = cAcceso.Login(cAcc);

                if (acceso[0] != null)
                {
                    MessageBox.Show("Acceso Concedido");
                    FormContenedor formContenedor = new FormContenedor(acceso[0].dni_empleado, acceso[0].nombre);
                    
                    formContenedor.Show();

                    txtDniEmpleado.Text = "";
                    txtContraseñaEmpleado.Text = "";
                }
                else
                {
                    MessageBox.Show("Datos incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Uno de las campos está vacío");
            }
        }

        private void txtDniEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                string currentText = txtDniEmpleado.Text;

                if (currentText.Length + 1 > 8)
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtContraseñaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnIniciarSesion_Click(sender, e);
            }
        }
    }
}
