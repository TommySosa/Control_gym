using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_de_presentacion
{
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            InitializeComponent();
        }
        private ConexionBD conexionBD = ConexionBD.Instancia;

        public string DniCliente
        {
            get { return txtDniCliente.Text; }
            set { txtDniCliente.Text = value; }
        }

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        public string Apellido
        {
            get { return txtApellido.Text; }
            set { txtApellido.Text = value; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public string Domicilio
        {
            get { return txtDomicilio.Text; }
            set { txtDomicilio.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clientes(dni_cliente, nombre, apellido, telefono,domicilio, email) VALUES (@dni_cliente, @nombre, @apellido, @telefono, @domicilio, @email)";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexionBD.AbrirConexion());

                comando.Parameters.Add(new SqlParameter("@dni_cliente", DniCliente));
                comando.Parameters.Add(new SqlParameter("@nombre", Nombre));
                comando.Parameters.Add(new SqlParameter("@apellido", Apellido));
                comando.Parameters.Add(new SqlParameter("@telefono", Telefono));
                comando.Parameters.Add(new SqlParameter("@domicilio", Domicilio));
                comando.Parameters.Add(new SqlParameter("@email", Email));

                comando.ExecuteNonQuery();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente." + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
