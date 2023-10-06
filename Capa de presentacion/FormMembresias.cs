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
    public partial class FormMembresias : Form
    {
        public FormMembresias()
        {
            InitializeComponent();
        }

        private void FormMembresias_Load(object sender, EventArgs e)
        {
            dtpFechaFin.Value = dtpFechaFin.Value.AddDays(30);
        }
    }
}
