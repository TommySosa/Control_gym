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
                MessageBox.Show("Datos de acceso: " + acceso[0].dni_empleado + "contraseña" + acceso[0].nombre);
                FormContenedor formContenedor = new FormContenedor(acceso[0].dni_empleado, acceso[0].nombre);
                formContenedor.Show();
                Close();
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

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
