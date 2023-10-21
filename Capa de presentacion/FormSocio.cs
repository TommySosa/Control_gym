using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;



namespace Control_Gym.Capa_de_presentacion
{
    public partial class FormSocio : Form
    {
        public FormSocio()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ClsSocio oClsSocio = new ClsSocio();

            int dni = Convert.ToInt32(txtDniSocio.Text);
            string nombre = txtNombreSocio.Text;
            string apellido = txtApellidoSocio.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string telefono = txtTelefonoSocio.Text;
            string domicilio = txtDomicilio.Text;
            string email = txtEmail.Text;

            oClsSocio.GuardarSocio(dni, nombre, apellido, fechaNacimiento, telefono, domicilio, email);
            dgvSocios.DataSource = oClsSocio.CargarDatos();
        }



        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsSocio clsSocio = new ClsSocio();
            string cod = txtCod.Text;
            int dni = Convert.ToInt32(txtDniSocio.Text);
            string nombre = txtNombreSocio.Text;
            string apellido = txtApellidoSocio.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string telefono = txtTelefonoSocio.Text;
            string domicilio = txtDomicilio.Text;
            string email = txtEmail.Text;

            ClsSocio oclsSocio = new ClsSocio();
            oclsSocio.ModificarSocio(cod, dni, nombre, apellido, fechaNacimiento, telefono, domicilio, email);

            dgvSocios.DataSource = clsSocio.CargarDatos();

        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            
            ClsSocio clsSocio = new ClsSocio();
            
            if (txtBuscarSocio.Text != "")
            {
                string cod = txtBuscarSocio.Text ;
                dgvSocios.DataSource = clsSocio.Filtrar(cod);
            }
            else
            {
                clsSocio.CargarDatos();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ClsSocio clsSocio = new ClsSocio();
            string cod = txtCod.Text;
            string nombre = txtNombreSocio.Text ;
            clsSocio.EliminarDatos(cod, nombre);

            txtCod.Text = "";
            txtDniSocio.Text = "";
            txtNombreSocio.Text = "";
            txtApellidoSocio.Text = "";
            txtTelefonoSocio.Text = "";
            dtpFechaNacimiento.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            dgvSocios.DataSource = clsSocio.CargarDatos();
        }


        private void FormSocio_Load(object sender, EventArgs e)
        {
            ClsSocio clsSocio = new ClsSocio();

            dgvSocios.DataSource = clsSocio.CargarDatos();
        }

        private void txtBuscarSocio_TextChanged(object sender, EventArgs e)
        {
            ClsSocio clsSocio = new ClsSocio();

            if (txtBuscarSocio.Text != "")
            {
                string cod = txtBuscarSocio.Text;
                dgvSocios.DataSource = clsSocio.Filtrar(cod);
            }
            else
            {
                dgvSocios.DataSource = clsSocio.CargarDatos();
            }
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = dgvSocios.SelectedCells[0].Value.ToString();
            txtDniSocio.Text= dgvSocios.SelectedCells[0].Value.ToString();
            txtNombreSocio.Text = dgvSocios.SelectedCells[1].Value.ToString();
            txtApellidoSocio.Text = dgvSocios.SelectedCells[2].Value.ToString();
            txtTelefonoSocio.Text = dgvSocios.SelectedCells[3].Value.ToString();
            dtpFechaNacimiento.Text = dgvSocios.SelectedCells[4].Value.ToString();
            txtDomicilio.Text = dgvSocios.SelectedCells[5].Value.ToString();
            txtEmail.Text = dgvSocios.SelectedCells[6].Value.ToString();

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ClsSocio clsSocio = new ClsSocio();

            dgvSocios.DataSource = clsSocio.CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtDniSocio.Text = "";
            txtNombreSocio.Text = "";
            txtApellidoSocio.Text = "";
            txtTelefonoSocio.Text = "";
            dtpFechaNacimiento.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            
        }
    }
}
