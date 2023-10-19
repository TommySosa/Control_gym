using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            guardarDatosSocios();
        }

        private void guardarDatosSocios()
        {
            ClsSocio  oClsSocio = new ClsSocio();
            CSociosD ocSociosD   = new CSociosD();
            DateTime FechaNacimiento = DateTime.Now;
            int Dni = 0; int.TryParse(txtDniSocio.Text, out Dni);
            int Telefono = 0; int.TryParse(txtTelefonoSocio.Text, out Telefono);
            
           

            oClsSocio.Dni = Dni;

            oClsSocio.Nombre = txtNombreSocio.Text;

            oClsSocio.Apellido = txtApellidoSocio.Text;

            oClsSocio.Telefono = Telefono;

            oClsSocio.FechaDeNacimiento = FechaNacimiento;

            oClsSocio.Domicilio = txtDomicilio.Text;

            oClsSocio.Email = txtEmail.Text; 


            //MessageBox.Show("DNI: " + oClsSocio.Dni.ToString());
           //MessageBox.Show(oClsSocio.FechaDeNacimiento.ToString());
            ocSociosD.GuardarSocio(oClsSocio);

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
