using Control_Gym.Capa_de_datos;
using Control_Gym.Capa_logica;
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
    public partial class FormCaja : Form
    {
        public FormCaja()
        {
            InitializeComponent();
        }

        private CVenta cVenta = new CVenta();
        private CCuotaD cCuotaD = new CCuotaD();

        private void FormCaja_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = cVenta.traerVentas();
            dgvVentas.Columns[0].HeaderText = "N° Venta";
            dgvVentas.Columns[1].HeaderText = "DNI Cliente";
            dgvVentas.Columns[2].HeaderText = "DNI Empleado";
            dgvVentas.Columns[3].HeaderText = "Fecha";
            dgvVentas.Columns[4].HeaderText = "Total";
            dgvVentas.AutoResizeColumns();
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblVentasResult.Text = cVenta.ObtenerTotal().ToString();
            lblTotalMesResult.Text = cVenta.ObtenerTotalMesActual().ToString();
            lblTotalHoyResult.Text = cVenta.ObtenerTotalHoy().ToString();

            dgvCuotas.DataSource = cCuotaD.TraerCuotas();
            dgvCuotas.Columns[0].HeaderText = "Cod. Cuota";
            dgvCuotas.Columns[1].HeaderText = "Fecha de pago";
            dgvCuotas.Columns[2].HeaderText = "DNI del socio";
            dgvCuotas.Columns[3].HeaderText = "Tipo de membresia";
            dgvCuotas.Columns[4].HeaderText = "Monto";
            dgvCuotas.AutoResizeColumns();
            dgvCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTotalCuotasResult.Text = cCuotaD.ObtenerTotal().ToString();
            lblTotalMesCuotaResult.Text = cCuotaD.ObtenerTotalMesActual().ToString();
            lblTotalHoyCuotasResult.Text = cCuotaD.ObtenerTotalHoy().ToString();

            btnVerDetalle.Visible = false;

        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                int num_venta = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["num_venta"].Value);

                FormVerDetalle formDetalle = new FormVerDetalle(num_venta);

                DialogResult result = formDetalle.ShowDialog();
                //if (result == DialogResult.OK)
                //{
                //    string dniCliente = formDetalle.DniCliente;
                //    string nombre = formDetalle.Nombre;
                //    string apellido = formDetalle.Apellido;
                //    string telefono = agregarClienteForm.Telefono;
                //    string domicilio = agregarClienteForm.Domicilio;
                //    string email = agregarClienteForm.Email;

                //}
            }
        }

        private void dgvVentas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                btnVerDetalle.Visible = true;
            }
        }
    }
}
