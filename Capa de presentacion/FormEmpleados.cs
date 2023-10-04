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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            btnCancelarEmpleado.Visible = false;
            btnActualizarEmpleado.Visible = false;
        }

        private void CancelarActualizarEmpleado()
        {
            btnGuardarEmpleado.Visible = true;
            btnActualizarEmpleado.Visible = false;
            btnCancelarEmpleado.Visible = false;
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            CancelarActualizarEmpleado();
            limpiarTextBox();
        }

        private void limpiarTextBox()
        {
            txtDniEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            txtTelefonoEmpleado.Clear();
            dtpFechNacEmpleado.Value = dtpFechNacEmpleado.Value = DateTime.Now;
            txtDomicilioEmpleado.Clear();
            txtEmailEmpleado.Clear();
            txtContraseñaEmpleado.Clear();
        }

        private void dtvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardarEmpleado.Visible = false;
            btnActualizarEmpleado.Visible = true;
            btnCancelarEmpleado.Visible = true;
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
