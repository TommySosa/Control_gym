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
            try
            {
                List<CEmpleado> empleados = cEmpleado.TraerEmpleados();

                dtvEmpleado.DataSource = empleados;

                dtvEmpleado.Columns[0].HeaderText = "DNI";
                dtvEmpleado.Columns[1].HeaderText = "Nombre";
                dtvEmpleado.Columns[2].HeaderText = "Apellido";
                dtvEmpleado.Columns[3].HeaderText = "Teléfono";
                dtvEmpleado.Columns[7].HeaderText = "Fecha de Nacimiento";
                dtvEmpleado.Columns[7].Width = 75;
                dtvEmpleado.Columns[4].HeaderText = "Domicilio";
                dtvEmpleado.Columns[5].HeaderText = "E-Mail";
                dtvEmpleado.Columns[6].HeaderText = "Contraseña";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de empleados: " + ex.Message);
            }
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                btnCancelarEmpleado.Visible = false;
                btnActualizarEmpleado.Visible = false;
                btnEliminarEmpleado.Visible = false;

                dtvEmpleado.CellFormatting += dtvEmpleado_CellFormatting;
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario de empleados: " + ex.Message);
            }
        }

        private void dtvEmpleado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnGuardarEmpleado.Visible = false;
                btnActualizarEmpleado.Visible = true;
                btnCancelarEmpleado.Visible = true;
                btnEliminarEmpleado.Visible = true;
                mtxtDniEmpleado.ReadOnly = true;

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
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar un empleado: " + ex.Message);
            }
        }

        private void CancelarActualizarEmpleado()
        {
            btnGuardarEmpleado.Visible = true;
            btnActualizarEmpleado.Visible = false;
            btnCancelarEmpleado.Visible = false;
            btnEliminarEmpleado.Visible = false;
            mtxtDniEmpleado.ReadOnly = false;
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                CancelarActualizarEmpleado();
                limpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar la edición: " + ex.Message);
            }
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);
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
                    int dniEmpleado = Convert.ToInt32(filaSeleccionada.Cells["dni_empleado"].Value);

                    CEmpleado cEmpleado = new CEmpleado(
                        dniEmpleado,
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
                    MessageBox.Show("Por favor complete los campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvEmpleado.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dtvEmpleado.SelectedRows[0];
                    int dniEmpleado = Convert.ToInt32(filaSeleccionada.Cells["dni_empleado"].Value);
                    cEmpleado.EliminarEmpleado(dniEmpleado);
                    CargarGrilla();
                    limpiarTextBox();
                    CancelarActualizarEmpleado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
            }
        }

        // FIN CRUD //

        private void txtTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
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

        private void dtvEmpleado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void mtxtDniEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombreEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtApellidoEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtTelefonoEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtDomicilioEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmailEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void txtContraseñaEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void mtxtDniEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((System.Windows.Forms.MaskedTextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtNombreEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((System.Windows.Forms.TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtApellidoEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((System.Windows.Forms.TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtTelefonoEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((System.Windows.Forms.TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtDomicilioEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((System.Windows.Forms.TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtEmailEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((System.Windows.Forms.TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }
        private void txtContraseñaEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((System.Windows.Forms.TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
            }
        }
    }
}