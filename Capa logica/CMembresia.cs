using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Gym.Capa_de_datos;

namespace Control_Gym.Capa_logica
{
    internal class CMembresia
    {
        public int cod_membresia { get; set; }
        public int cod_tipo_membresia { get; set; }
        public int dni_socio { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }

        public CMembresia() { 
        
        }
        public CMembresia(int cod_tipo_membresia, int dni_socio, DateTime fecha_inicio, DateTime fecha_fin)
        {
            this.cod_tipo_membresia = cod_tipo_membresia;
            this.dni_socio = dni_socio;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
        }
        public CMembresia(int cod_tipo_membresia)
        {
            this.cod_tipo_membresia = cod_tipo_membresia;
        }

        public void CrearMembresia(CMembresia cMembresia)
        {
            CMembresiaD cMembresiaD = new CMembresiaD();
            cMembresiaD.CrearMembresia(cMembresia);
        }

    }
}
