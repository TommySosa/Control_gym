using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_presentacion
{
    public partial class FormChequeo : Form
    {
        public int dni_global;
        public FormChequeo()
        {
            InitializeComponent();
        }

        private CTipoMembresia cTipoMembresia = new CTipoMembresia();
        private CMembresiaD cMembresiaD = new CMembresiaD();
        private CChequeoD cChequeoD = new CChequeoD();


        private void FormChequeo_Load(object sender, EventArgs e)
        {
            pbNeutro.Visible = true;
            pbYes.Visible = false;
            pbNo.Visible = false;
            pbWarning.Visible = false;
            cmbTipoMembresia.Visible = false;
            lblTipoMembresia.Visible = false;

            limpiarLabels();
        }

        private void limpiarLabels()
        {
            txtDni.Text = "";
            lblNombreCompleto.Text = "";
            lblInicio.Text = "00/00";
            lblFin.Text = "00/00";
            lblDiasRestantes.Text = "00";
            cmbTipoMembresia.Visible = false;
            lblTipoMembresia.Visible = false;
        }

        private void cmbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CTipoMembresia tipoSeleccionado = (CTipoMembresia)cmbTipoMembresia.SelectedItem;
                int cod_tipo_membresia = tipoSeleccionado.cod_tipo_membresia;
                cTipoMembresia.cod_tipo_membresia = cod_tipo_membresia;

                if (dni_global != 0)
                {
                    timer1.Stop();
                    timer1.Start();

                    if (cMembresiaD.TieneTipoMembresia(dni_global, cTipoMembresia.cod_tipo_membresia))
                    {
                        CChequeoD cChequeoD = new CChequeoD();
                        string[] resultado = cChequeoD.buscarPorDni(dni_global, cTipoMembresia.cod_tipo_membresia);

                        if (resultado.Length > 0)
                        {
                            if (Convert.ToInt32(resultado[2]) <= 5 && Convert.ToInt32(resultado[2]) >= 1)
                            {
                                lblInicio.Text = resultado[0];
                                lblFin.Text = resultado[1];
                                lblDiasRestantes.Text = resultado[2];

                                pbNeutro.Visible = false;
                                pbYes.Visible = false;
                                pbNo.Visible = false;
                                pbWarning.Visible = true;
                            }
                            else if (Convert.ToInt32(resultado[2]) > 5)
                            {
                                lblInicio.Text = resultado[0];
                                lblFin.Text = resultado[1];
                                lblDiasRestantes.Text = resultado[2];

                                pbNeutro.Visible = false;
                                pbYes.Visible = true;
                                pbNo.Visible = false;
                                pbWarning.Visible = false;
                            }
                            else
                            {
                                lblInicio.Text = resultado[0];
                                lblFin.Text = resultado[1];
                                lblDiasRestantes.Text = resultado[2];

                                pbNeutro.Visible = false;
                                pbYes.Visible = false;
                                pbWarning.Visible = false;
                                pbNo.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El socio no tiene esta membresía");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar un tipo de membresía: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDni.Text != "")
                {

                    int dni = Convert.ToInt32(txtDni.Text);

                    dni_global = dni;

                    

                    txtDni.Text = "";

                    string[] resultado = cChequeoD.buscarPorDni(dni);
                    int cant_tipo_membresia = cChequeoD.ContarTiposMembresia(dni);

                    cmbTipoMembresia.Visible = false;
                    lblTipoMembresia.Visible = false;

                    if (cant_tipo_membresia > 1)
                    {
                        cmbTipoMembresia.Visible = true;
                        lblTipoMembresia.Visible = true;
                    }

                    timer1.Stop();
                    timer1.Start();

                    if (resultado.Length > 0)
                    {
                        try
                        {
                            List<CTipoMembresia> tipos = cTipoMembresia.traerTiposDelSocio(dni);
                            cmbTipoMembresia.DataSource = tipos;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar los tipos de membresía: " + ex.Message);
                        }

                        try
                        {
                            ClsSocio[] socio = cChequeoD.traerDatosDeSocioPorDni(dni);
                            lblNombreCompleto.Text = socio[0].Nombre + " " + socio[0].Apellido;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar los tipos de membresía: " + ex.Message);
                        }

                        if (Convert.ToInt32(resultado[2]) <= 5 && Convert.ToInt32(resultado[2]) >= 1)
                        {
                            lblInicio.Text = resultado[0];
                            lblFin.Text = resultado[1];
                            lblDiasRestantes.Text = resultado[2];

                            pbNeutro.Visible = false;
                            pbYes.Visible = false;
                            pbNo.Visible = false;
                            pbWarning.Visible = true;
                        }
                        else if (Convert.ToInt32(resultado[2]) > 5)
                        {
                            lblInicio.Text = resultado[0];
                            lblFin.Text = resultado[1];
                            lblDiasRestantes.Text = resultado[2];

                            pbNeutro.Visible = false;
                            pbYes.Visible = true;
                            pbNo.Visible = false;
                            pbWarning.Visible = false;
                        }
                        else
                        {
                            lblInicio.Text = resultado[0];
                            lblFin.Text = resultado[1];
                            lblDiasRestantes.Text = resultado[2];

                            pbNeutro.Visible = false;
                            pbYes.Visible = false;
                            pbWarning.Visible = false;
                            pbNo.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("el DNI ingresado no existe.");
                        limpiarLabels();
                        pbNeutro.Visible = true;
                        pbYes.Visible = false;
                        pbNo.Visible = false;
                        pbWarning.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo está vacío, ingrese un DNI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el DNI del socio: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            pbYes.Visible = false;
            pbNo.Visible = false;
            pbWarning.Visible = false;
            pbNeutro.Visible = true;

            limpiarLabels();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
                    e.Handled = true;
                    btnBuscar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el manejo de entrada: " + ex.Message);
            }
        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtDni_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }
    }
}
