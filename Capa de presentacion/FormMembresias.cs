using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FormMembresias_Load(object sender, EventArgs e)
        {
            dtpFechaFin.Value = dtpFechaFin.Value.AddDays(30);
            List<CTipoMembresia> tipos = cTipoMembresia.traerTipos();

            cbTipoMembresia.DataSource = tipos;
        }

        private void btnCrearMembresia_Click(object sender, EventArgs e)
        {

            CMembresia cMembresia = new CMembresia(Convert.ToInt32(cTipoMembresia.cod_tipo_membresia), Convert.ToInt32(txtDniMembresia.Text), dtpFechaInicio.Value, dtpFechaFin.Value);
            CMembresiaD cMembresiaD = new CMembresiaD();
            cMembresiaD.CrearMembresia(cMembresia);
        }

        private void btnEditarMembresia_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarMembresia_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMembresia_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarMembresia_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMembresia.SelectedItem != null)
            {
                CTipoMembresia tipoSeleccionado = (CTipoMembresia)cbTipoMembresia.SelectedItem;
                int cod_tipo_membresia = tipoSeleccionado.cod_tipo_membresia;
                cTipoMembresia.cod_tipo_membresia = cod_tipo_membresia;
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
