using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Gym.Capa_de_datos;

namespace Control_Gym.Capa_logica
{
    internal class ClsSocio
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }

        public ClsSocio(int Dni, string Nombre, string Apellido, int Telefono, DateTime FechaDeNacimiento, string Domicilio, string Email)
        {
            this.Dni = Dni; 
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.FechaDeNacimiento = FechaDeNacimiento;
            this.Domicilio = Domicilio;
            this.Email = Email; 
        }

        public ClsSocio()
        {
        }

        public void GuardarSocio(ClsSocio clsSocio)
        {
            CSociosD CSociosD = new CSociosD();
            CSociosD.GuardarSocio(clsSocio);

        }
    }
}