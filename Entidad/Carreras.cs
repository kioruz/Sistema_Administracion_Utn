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
        private int id;
        private int inscripciones_Id;
        private int tipos_Carreras_Id;
        private String nombre;
        private String codigoInterno;
        private int idTipoCarrera;
        private int idInscripcion;
        private String fechaBaja;
        private String causaBaja;
        //Constructors
        public Carreras(int id, int inscripciones_Id, int tipos_Carreras_Id, string nombre, string codigoInterno, int idTipoCarrera, int idInscripcion, string fechaBaja, string causaBaja)
        {
            this.Id = id;
            this.Inscripciones_Id = inscripciones_Id;
            this.Tipos_Carreras_Id = tipos_Carreras_Id;
            this.Nombre = nombre;
            this.CodigoInterno = codigoInterno;
            this.IdTipoCarrera = idTipoCarrera;
            this.IdInscripcion = idInscripcion;
            this.FechaBaja = fechaBaja;
            this.CausaBaja = causaBaja;
        }

        public Carreras() { }

        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public int Inscripciones_Id { get => inscripciones_Id; set => inscripciones_Id = value; }
        public int Tipos_Carreras_Id { get => tipos_Carreras_Id; set => tipos_Carreras_Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CodigoInterno { get => codigoInterno; set => codigoInterno = value; }
        public int IdTipoCarrera { get => idTipoCarrera; set => idTipoCarrera = value; }
        public int IdInscripcion { get => idInscripcion; set => idInscripcion = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string CausaBaja { get => causaBaja; set => causaBaja = value; }
    }
}
