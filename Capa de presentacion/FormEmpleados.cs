using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Control_Gym.Capa_de_presentacion
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private CEmpleado cEmpleado = new CEmpleado();

        private void CargarGrilla()
        {
            List<CEmpleado> empleados = cEmpleado.TraerEmpleados();

            dtvEmpleado.DataSource = empleados;

            dtvEmpleado.Columns[0].HeaderText = "ID";
            dtvEmpleado.Columns[0].Width = 35;
            dtvEmpleado.Columns[1].HeaderText = "DNI";
            dtvEmpleado.Columns[2].HeaderText = "Nombre";
            dtvEmpleado.Columns[3].HeaderText = "Apellido";
            dtvEmpleado.Columns[4].HeaderText = "Teléfono";
            dtvEmpleado.Columns[8].HeaderText = "Fecha de Nacimiento";
            dtvEmpleado.Columns[8].Width = 75;
            dtvEmpleado.Columns[5].HeaderText = "Domicilio";
            dtvEmpleado.Columns[6].HeaderText = "E-Mail";
            dtvEmpleado.Columns[7].HeaderText = "Contraseña";
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            btnCancelarEmpleado.Visible = false;
            btnActualizarEmpleado.Visible = false;
            btnEliminarEmpleado.Visible = false;

            dtvEmpleado.CellFormatting += dtvEmpleado_CellFormatting;
            CargarGrilla();
        }

        private void dtvEmpleado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnGuardarEmpleado.Visible = false;
            btnActualizarEmpleado.Visible = true;
            btnCancelarEmpleado.Visible = true;
            btnEliminarEmpleado.Visible = true;

            if (dtvEmpleado.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtvEmpleado.SelectedRows[0];

                mtxtDniEmpleado.Text = filaSeleccionada.Cells["dni_empleado"].Value.ToString();
                txtNombreEmpleado.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtApellidoEmpleado.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                txtTelefonoEmpleado.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                dtpFechNacEmpleado.Text = filaSeleccionada.Cells["fecha_nac"].Value.ToString();
                txtDomicilioEmpleado.Text = filaSeleccionada.Cells["domicilio"].Value.ToString();
                txtEmailEmpleado.Text = filaSeleccionada.Cells["email"].Value.ToString();
                txtContraseñaEmpleado.Text = filaSeleccionada.Cells["contraseña"].Value.ToString();
            }
        }

        private void CancelarActualizarEmpleado()
        {
            btnGuardarEmpleado.Visible = true;
            btnActualizarEmpleado.Visible = false;
            btnCancelarEmpleado.Visible = false;
            btnEliminarEmpleado.Visible = false;
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            CancelarActualizarEmpleado();
            limpiarTextBox();
        }

        private void limpiarTextBox()
        {
            mtxtDniEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            txtTelefonoEmpleado.Clear();
            dtpFechNacEmpleado.Value = dtpFechNacEmpleado.Value = DateTime.Now;
            txtDomicilioEmpleado.Clear();
            txtEmailEmpleado.Clear();
            txtContraseñaEmpleado.Clear();
        }

        // CRUD //

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = mtxtDniEmpleado.Text;
                if (dni.Length != 8 || !int.TryParse(dni, out _))
                {
                    MessageBox.Show("El DNI debe contener exactamente 8 dígitos numéricos.");
                    return;
                }

                if (txtNombreEmpleado.Text != "" && txtApellidoEmpleado.Text != "" && txtTelefonoEmpleado.Text != "" && txtDomicilioEmpleado.Text != "" && txtEmailEmpleado.Text != "" && txtContraseñaEmpleado.Text != "")
                {
                    CEmpleado cEmpleado = new CEmpleado(
                        Convert.ToInt32(mtxtDniEmpleado.Text),
                        txtNombreEmpleado.Text,
                        txtApellidoEmpleado.Text,
                        txtTelefonoEmpleado.Text,
                        DateTime.Parse(dtpFechNacEmpleado.Value.ToString("yyyy/MM/dd")),
                        txtDomicilioEmpleado.Text,
                        txtEmailEmpleado.Text,
                        txtContraseñaEmpleado.Text
                        );
                    CEmpleadoD cEmpleadoD = new CEmpleadoD();
                    bool existe = cEmpleadoD.DniExiste(cEmpleado.dni_empleado);

                    if (existe)
                    {
                        MessageBox.Show("El DNI ya está en uso. No se puede crear un empleado con el mismo DNI.");
                    }
                    else
                    {
                        cEmpleadoD.CrearEmpleado(cEmpleado);
                        CargarGrilla();
                        limpiarTextBox();
                        CancelarActualizarEmpleado();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete los campos.");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Error al crear el empleado en la CAPA DE PRESENTACION: " + ex);
            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = mtxtDniEmpleado.Text;
                if (dni.Length != 8 || !int.TryParse(dni, out _))
                {
                    MessageBox.Show("El DNI debe contener exactamente 8 dígitos numéricos.");
                    return;
                }

                if (txtNombreEmpleado.Text != "" && txtApellidoEmpleado.Text != "" && txtTelefonoEmpleado.Text != "" && txtDomicilioEmpleado.Text != "" && txtEmailEmpleado.Text != "" && txtContraseñaEmpleado.Text != "")
                {
                    DataGridViewRow filaSeleccionada = dtvEmpleado.SelectedRows[0];
                    int id = Convert.ToInt32(filaSeleccionada.Cells["cod_empleado"].Value);

                    CEmpleado cEmpleado = new CEmpleado(
                        id,
                        Convert.ToInt32(mtxtDniEmpleado.Text),
                        txtNombreEmpleado.Text,
                        txtApellidoEmpleado.Text,
                        txtTelefonoEmpleado.Text,
                        DateTime.Parse(dtpFechNacEmpleado.Value.ToString("yyyy/MM/dd")),
                        txtDomicilioEmpleado.Text,
                        txtEmailEmpleado.Text,
                        txtContraseñaEmpleado.Text
                    );
                    CEmpleadoD cEmpleadoD = new CEmpleadoD();
                    cEmpleadoD.EditarEmpleado(cEmpleado);
                    CargarGrilla();
                    limpiarTextBox();
                    CancelarActualizarEmpleado();
                }
                else
                {
                    MessageBox.Show("Por favor complete los campos");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Error al actualizar el empleado en la CAPA DE PRESENTACION: " + ex);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvEmpleado.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dtvEmpleado.SelectedRows[0];
                    int id = Convert.ToInt32(filaSeleccionada.Cells["cod_empleado"].Value);
                    cEmpleado.EliminarEmpleado(id);
                    CargarGrilla();
                    limpiarTextBox();
                    CancelarActualizarEmpleado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado en la CAPA DE PRESENTACION: " + ex);
            }
        }

        // FIN CRUD //

        private void dtvEmpleado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void txtTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mtxtDniEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                string currentText = mtxtDniEmpleado.Text;

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
    }
}
