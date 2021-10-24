using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Carreras
    {
        //Attributes
        private String id;
        private String inscripciones_Id;
        private String tipos_Carreras_Id;
        private String nombre;
        private String codigoInterno;
        private String fechaBaja;
        private String causaBaja;
        //Constructors
        public Carreras(string id, string inscripciones_Id, string tipos_Carreras_Id, string nombre, string codigoInterno, string fechaBaja, string causaBaja)
        {
            this.Id = id;
            this.Inscripciones_Id = inscripciones_Id;
            this.Tipos_Carreras_Id = tipos_Carreras_Id;
            this.Nombre = nombre;
            this.CodigoInterno = codigoInterno;
            this.FechaBaja = fechaBaja;
            this.CausaBaja = causaBaja;
        }

        public Carreras() { }

        //Getters and Setters
        public string Id { get => id; set => id = value; }
        public string Inscripciones_Id { get => inscripciones_Id; set => inscripciones_Id = value; }
        public string Tipos_Carreras_Id { get => tipos_Carreras_Id; set => tipos_Carreras_Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CodigoInterno { get => codigoInterno; set => codigoInterno = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string CausaBaja { get => causaBaja; set => causaBaja = value; }
    }
}
