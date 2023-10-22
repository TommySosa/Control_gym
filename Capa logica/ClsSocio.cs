using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
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

        public void GuardarSocio(int dni, string nombre, string apellido, DateTime fechaNacimiento, int telefono, string domicilio, string email)
        {
            CSociosD CSociosD = new CSociosD();
            CSociosD.GuardarSocio(dni, nombre, apellido, fechaNacimiento, telefono, domicilio, email);

        }
        public void ModificarSocio(int cod, int dni, string nombre, string apellido, DateTime fechaNacimiento, int telefono, string domicilio, string email)
        {
            CSociosD cSociosD = new CSociosD();
            cSociosD.ModificarSocio(cod, dni, nombre, apellido, fechaNacimiento, telefono, domicilio, email);
        }
        public DataTable CargarDatos()
        {
           
            CSociosD cSociosD = new CSociosD();
            DataTable tabla = new DataTable();
            tabla = cSociosD.CargarDatos();

            return tabla;
        }
        public void EliminarDatos(int cod, string nombre)
        {
            CSociosD cSociosD = new CSociosD();
            cSociosD.EliminarDatos(cod, nombre);
        }
         public DataTable Filtrar(string cod)
        {

            CSociosD cSociosD = new CSociosD();
            DataTable tabla = new DataTable();
            tabla = cSociosD.Filtrar(cod);

            return tabla;
        }
    }
}