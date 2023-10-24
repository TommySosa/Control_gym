﻿using Control_Gym.Capa_de_datos;
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
    public partial class FormChequeo : Form
    {
        public FormChequeo()
        {
            InitializeComponent();
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

        private void FormChequeo_Load(object sender, EventArgs e)
        {
            pbNeutro.Visible = true;
            pbYes.Visible = false;
            pbNo.Visible = false;

            limpiarLabels();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpiarLabels()
        {
            lblInicio.Text = "00/00";
            lblFin.Text = "00/00";
            lblDiasRestantes.Text = "00";
            cmbTipoMembresia.Text = string.Empty;
        }

        private void pbAdministradores_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                int dni = Convert.ToInt32(txtDni.Text);

                CChequeoD cChequeoD = new CChequeoD();
                string[] resultado = cChequeoD.buscarPorDni(dni);

                timer1.Stop();
                timer1.Start();


                if (resultado.Length > 0)
                {
                    if (Convert.ToInt32(resultado[2]) > 0)
                    {
                        lblInicio.Text = resultado[0];
                        lblFin.Text = resultado[1];
                        lblDiasRestantes.Text = resultado[2];

                        pbNeutro.Visible = false;
                        pbYes.Visible = true;
                        pbNo.Visible = false;

                        txtDni.Text = "";
                    }
                    else
                    {
                        lblInicio.Text = resultado[0];
                        lblFin.Text = resultado[1];
                        lblDiasRestantes.Text = resultado[2];

                        pbNeutro.Visible = false;
                        pbYes.Visible = false;
                        pbNo.Visible = true;
                        
                        txtDni.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("el DNI ingresado no existe.");
                    txtDni.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El campo está vacío, ingrese un DNI");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            pbYes.Visible = false;
            pbNo.Visible = false;
            pbNeutro.Visible = true;

            limpiarLabels();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                string currentText = txtDni.Text;

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
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnBuscar_Click(sender, e);//llama al evento click del boton
            }
        }
    }
}