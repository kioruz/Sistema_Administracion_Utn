using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Modalidades
    {
        //Attributes
        private String id;
        private String nombre;
        private String fechaBaja;
        private String causaBaja;
        //Constructors
        public Modalidades(string id, string nombre, string fechaBaja, string causaBaja)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.FechaBaja = fechaBaja;
            this.CausaBaja = causaBaja;
        }

        public Modalidades() { }
        //Getters and Setters
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string CausaBaja { get => causaBaja; set => causaBaja = value; }
    }
}
