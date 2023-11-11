using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Gym.Capa_de_datos;

namespace Control_Gym.Capa_logica
{
    internal class ClsProvedores
    {
        public int Cod { get; set; }
        public string Filtro { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public ClsProvedores(string Filtro, string Nombre, string Cuit, string Telefono, string Direccion, string Email) 
        {
            this.Filtro = Filtro;
            this.Nombre = Nombre;
            this.Cuit = Cuit;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Email = Email;
        }
        public ClsProvedores() { }
        public ClsProvedores(int cod, string nombre)
        {
            this.Cod=cod;
            this.Nombre=nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
        public void AgregarProv(string nombre, string cuit, string telefono, string direccion, string email)
        {
            CProveedoresD cProveedoresD = new CProveedoresD();
            cProveedoresD.AgregarProv(nombre, cuit,  telefono, direccion, email);

        }
        public void ModificarProv(string Filtro, string nombre, string cuit, string telefono, string direccion, string email)
        {
            CProveedoresD cProveedoresD = new CProveedoresD();
            cProveedoresD.ModificarProv(Filtro, nombre, cuit, telefono, direccion, email);
        }
        public void EliminarDatos(string Filtro, string nombre)
        {
            CProveedoresD cProveedoresD = new CProveedoresD();
            cProveedoresD.EliminarDatos(Filtro, nombre);
        }
        public DataTable CargarDatos()
        {

            CProveedoresD cProveedoresD = new CProveedoresD();
            DataTable tabla = new DataTable();
            tabla = cProveedoresD.CargarDatos();

            return tabla;
        }
        public DataTable Filtrar(string Filtro)
        {

            CProveedoresD cProveedoresD = new CProveedoresD();
            DataTable tabla = new DataTable();
            tabla = cProveedoresD.Filtrar(Filtro);

            return tabla;
        }
        public List<ClsProvedores> traerTiposProveedores()
        {
            CProveedoresD tiposD = new CProveedoresD();
            return tiposD.traerTiposProveedores();
        }
    }
}
