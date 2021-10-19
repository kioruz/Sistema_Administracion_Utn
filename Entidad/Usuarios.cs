using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuarios
    {
        //Attributes
        private String usuario;
        private String apellido;
        private String nombre;
        private String clave;
        private String fechaBaja;
        private String causaBaja;
        //Constructors
        public Usuarios(string usuario, string apellido, string nombre, string clave, string fechaBaja, string causaBaja)
        {
            this.Usuario = usuario;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Clave = clave;
            this.FechaBaja = fechaBaja;
            this.CausaBaja = causaBaja;
        }
        public Usuarios() { }

        //Getters and Setters
        public string Usuario { get => usuario; set => usuario = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string CausaBaja { get => causaBaja; set => causaBaja = value; }

    }
}
