using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Gym.Capa_de_datos;

namespace Control_Gym.Capa_logica
{
    internal class ClsTipoMembresia
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Dias { get; set; }
        public ClsTipoMembresia(int Cod, string Nombre, double Precio,int Dias)
        {
            this.Cod = Cod;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Dias = Dias;
   
        }
        public ClsTipoMembresia() { }
        public void AgregarTipo(string nombre, decimal precio, int dias)
        {
            CFTipoMembresiaD cFTipoMembresiaD = new CFTipoMembresiaD();
            cFTipoMembresiaD.AgregarTipo(nombre,precio,dias);

        }
        public void ModificarTipo(string cod, string nombre, decimal precio, int dias)
        {
            CFTipoMembresiaD cFTipoMembresiaD = new CFTipoMembresiaD();
            cFTipoMembresiaD.ModificarTipo(cod,nombre,precio,dias);
        }
        public void EliminarDatos(string cod, string name)
        {
            CFTipoMembresiaD cFTipoMembresiaD = new CFTipoMembresiaD();
            cFTipoMembresiaD.EliminarDatos(cod,name);
        }
        public DataTable CargarDatos()
        {

            CFTipoMembresiaD cFTipoMembresiaD = new CFTipoMembresiaD();
            DataTable tabla = new DataTable();
            tabla = cFTipoMembresiaD.CargarDatos();

            return tabla;
        }
        public DataTable Filtrar(string cod)
        {

            CFTipoMembresiaD cFTipoMembresiaD= new CFTipoMembresiaD();
            DataTable tabla = new DataTable();
            tabla = cFTipoMembresiaD.Filtrar(cod);

            return tabla;
        }

    }
}
