using Control_Gym.Capa_de_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gym.Capa_logica
{
    internal class CTipoMembresia
    {
        public int cod_tipo_membresia { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int cantidad_dias { get; set; }

        public CTipoMembresia() { 
        
        }
        public CTipoMembresia(int cod_tipo_membresia, string nombre)
        {
            this.cod_tipo_membresia = cod_tipo_membresia;
            this.nombre = nombre;
        }
        public CTipoMembresia(int cod_tipo_membresia, string nombre, decimal precio, int cantidad_dias)
        {
            this.cod_tipo_membresia = cod_tipo_membresia;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad_dias = cantidad_dias;
        }
        public override string ToString()
        {
            return nombre;
        }

        public List<CTipoMembresia> traerTipos()
        {
            CTipoMembresiaD tiposD = new CTipoMembresiaD();
            return tiposD.traerTipos();
        }
    }
}
