using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Control_Gym.Capa_de_presentacion;

namespace Control_Gym
{
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }
        private int dni_empleado;
        private string nombre;
        public FormContenedor(int dni_empleado, string nombre)
        {
            InitializeComponent();
            this.dni_empleado = dni_empleado;
            this.nombre = nombre;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AbrirFormEnPanel(object Formhijo)
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

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new FormPrincipal());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
           AbrirFormEnPanel(new FormVentas(dni_empleado,nombre));
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormAdministracion());
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormSocio());
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMembresias());
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormAcceso());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new FormPrincipal());
        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null, e);
            AbrirFormEnPanel(new FormSocio());
            lblDNI.Text = this.dni_empleado.ToString();
            lblNombre.Text = this.nombre;

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
