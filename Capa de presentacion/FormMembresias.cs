using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;

namespace Control_Gym.Capa_de_presentacion
{
    public partial class FormMembresias : Form
    {
        public FormMembresias()
        {
            InitializeComponent();
        }
        private CTipoMembresia cTipoMembresia = new CTipoMembresia();
        private CMembresia cMembresia = new CMembresia();

        private void CargarGrilla()
        {
            List<CTipoMembresia> tipos = cTipoMembresia.traerTipos();
            List<CMembresia> membresias = cMembresia.TraerMembresias();

            cbTipoMembresia.DataSource = tipos;
            dvgMembresias.DataSource = membresias;
            dvgMembresias.Columns[0].HeaderText = "ID";
            dvgMembresias.Columns[0].Width = 55;
            dvgMembresias.Columns[1].Visible = false;
            dvgMembresias.Columns[2].HeaderText = "Dni del socio";
            dvgMembresias.Columns[3].HeaderText = "Fecha de inicio";
            dvgMembresias.Columns[4].HeaderText = "Fecha de fin";
            dvgMembresias.Columns[5].HeaderText = "Tipo de membresia";
            dvgMembresias.Columns[6].HeaderText = "Precio";
            dvgMembresias.Columns[7].HeaderText = "Dias de duración";
            dvgMembresias.Columns[7].Width = 55;

        }
        private void FormMembresias_Load(object sender, EventArgs e)
        {
            btnCancelarMembresia.Visible = false;
            btnActualizarMembresia.Visible = false;
            btnCancelarMembresia.Visible = false;
            btnEliminarMembresia.Visible = false;
            dtpFechaFin.Value = dtpFechaFin.Value.AddDays(cMembresia.cantidad_dias);
            dvgMembresias.CellFormatting += dvgMembresias_CellFormatting;
            CargarGrilla();
        }

        public void CancelarModificar()
        {
            btnCrearMembresia.Visible = true;
            btnActualizarMembresia.Visible = false;
            btnEliminarMembresia.Visible = false;
            btnCancelarMembresia.Visible = false;
        }
        public void LimpiarCampos()
        {
            txtDniMembresia.Text = "";
            cbTipoMembresia.Text = "";
            dtpFechaInicio.Value = DateTime.Now;          
        }
        private void btnCrearMembresia_Click(object sender, EventArgs e)
        {
            if(txtDniMembresia.Text != "")
            {
                CMembresia cMembresia = new CMembresia(Convert.ToInt32(cTipoMembresia.cod_tipo_membresia), Convert.ToInt32(txtDniMembresia.Text), DateTime.Parse(dtpFechaInicio.Value.ToString("yyyy/MM/dd")), DateTime.Parse(dtpFechaFin.Value.ToString("yyyy/MM/dd")));
                CMembresiaD cMembresiaD = new CMembresiaD();
                bool existe = cMembresiaD.SocioExiste(cMembresia.dni_socio);
                if (existe)
                {
                    cMembresia.CrearMembresia(cMembresia);
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("El socio con el DNI especificado no existe en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese el DNI");
            } 
        }

        private void btnEditarMembresia_Click(object sender, EventArgs e)
        {
            if (dvgMembresias.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dvgMembresias.SelectedRows[0];

                txtCodMembresia.Text = filaSeleccionada.Cells["cod_membresia"].Value.ToString();
                cbTipoMembresia.Text = filaSeleccionada.Cells["cod_tipo_membresia"].Value.ToString();
                txtDniMembresia.Text = filaSeleccionada.Cells["dni_socio"].Value.ToString();
                dtpFechaInicio.Text = filaSeleccionada.Cells["fecha_inicio"].Value.ToString();
                dtpFechaFin.Text = filaSeleccionada.Cells["fecha_fin"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila en la grilla antes de cargar los datos.");
            }
        }

        private void btnGuardarMembresia_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMembresia_Click(object sender, EventArgs e)
        {
            if (dvgMembresias.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dvgMembresias.SelectedRows[0];
                int id = Convert.ToInt32(filaSeleccionada.Cells["cod_membresia"].Value);
                cMembresia.EliminarMembresia(id);
                CargarGrilla();
            }
        }

        private void btnBuscarMembresia_Click(object sender, EventArgs e)
        {
            if(txtBuscarDni.Text != "")
            {
                List<CMembresia> membresias = cMembresia.BuscarPorDNI(Convert.ToInt32(txtBuscarDni.Text));
                dvgMembresias.DataSource = membresias;
            }
            else
            {
                CargarGrilla();
            }
        }

        private void cbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMembresia.SelectedItem != null)
            {
                CTipoMembresia tipoSeleccionado = (CTipoMembresia)cbTipoMembresia.SelectedItem;
                int cod_tipo_membresia = tipoSeleccionado.cod_tipo_membresia;
                cTipoMembresia.cod_tipo_membresia = cod_tipo_membresia;

                int cantidadDias = tipoSeleccionado.cantidad_dias;

                DateTime fechaInicio = dtpFechaInicio.Value;

                DateTime fechaFin = fechaInicio.AddDays(cantidadDias);

                dtpFechaFin.Value = fechaFin;
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaInicio.Value != null)
                {
                    CTipoMembresia tipoSeleccionado = (CTipoMembresia)cbTipoMembresia.SelectedItem;
                    int cantidadDias = tipoSeleccionado.cantidad_dias;
                    DateTime fechaInicio = dtpFechaInicio.Value;
                    DateTime fechaFin = fechaInicio.AddDays(cantidadDias);
                    dtpFechaFin.Value = fechaFin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado"+ ex);
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dvgMembresias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DateTime fechaFin = (DateTime)dvgMembresias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                DateTime hoy = DateTime.Now;

                TimeSpan diferencia = fechaFin - hoy;

                if (diferencia.TotalDays < -1)
                {
                    dvgMembresias.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Salmon;
                }
                else if (diferencia.TotalDays <= 5)
                {
                    dvgMembresias.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
                }
                else
                {
                    dvgMembresias.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                }
            }

        }

        private void btnActualizarMembresia_Click(object sender, EventArgs e)
        {
            if (txtDniMembresia.Text != "")
            {
                CMembresia cMembresiaG = new CMembresia(Convert.ToInt32(txtCodMembresia.Text),cTipoMembresia.cod_tipo_membresia, Convert.ToInt32(txtDniMembresia.Text), DateTime.Parse(dtpFechaInicio.Value.ToString("yyyy/MM/dd")), DateTime.Parse(dtpFechaFin.Value.ToString("yyyy/MM/dd")));
                CMembresiaD cMembresiaD = new CMembresiaD();
                bool existe = cMembresiaD.SocioExiste(cMembresiaG.dni_socio);
                if (existe)
                {
                    cMembresia.EditarMembresia(cMembresiaG);
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("El socio con el DNI especificado no existe en la base de datos. Primero haga el alta al socio.");
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese el DNI");
            }
        }

        private void btnCancelarMembresia_Click(object sender, EventArgs e)
        {
            CancelarModificar();
            LimpiarCampos();
        }

        private void dvgMembresias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dvgMembresias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dvgMembresias.SelectedRows.Count > 0)
            {
                btnCrearMembresia.Visible = false;
                btnCancelarMembresia.Visible = true;
                btnActualizarMembresia.Visible = true;
                btnEliminarMembresia.Visible = true;
                DataGridViewRow filaSeleccionada = dvgMembresias.SelectedRows[0];
                txtCodMembresia.Text = filaSeleccionada.Cells["cod_membresia"].Value.ToString();
                cbTipoMembresia.Text = filaSeleccionada.Cells["cod_tipo_membresia"].Value.ToString();
                txtDniMembresia.Text = filaSeleccionada.Cells["dni_socio"].Value.ToString();
                dtpFechaInicio.Text = filaSeleccionada.Cells["fecha_inicio"].Value.ToString();
                dtpFechaFin.Text = filaSeleccionada.Cells["fecha_fin"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selecciona una fila en la grilla antes de cargar los datos.");
            }
        }

        
    }
}
