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
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mover la ventana: " + ex.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuVertical.Width == 250)
                {
                    MenuVertical.Width = 70;
                }
                else
                    MenuVertical.Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el ancho del menú: " + ex.Message);
            }
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al minimizar la ventana: " + ex.Message);
            }
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Normal;
                iconrestaurar.Visible = false;
                iconmaximizar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la ventana: " + ex.Message);
            }
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                iconrestaurar.Visible = true;
                iconmaximizar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al maximizar la ventana: " + ex.Message);
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la ventana: " + ex.Message);
            }
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario hijo: " + ex.Message);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormVentas(dni_empleado, nombre));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de ventas: " + ex.Message);
            }
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormAdministracion());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de administración: " + ex.Message);
            }
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormSocio());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de socios: " + ex.Message);
            }
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormMembresias());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de membresías: " + ex.Message);
            }
        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FormSocio());
                lblDNI.Text = this.dni_empleado.ToString();
                lblNombre.Text = this.nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario de contenedor: " + ex.Message);
            }
        }
    }
}
