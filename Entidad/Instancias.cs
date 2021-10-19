using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Instancias
    {
        //Attributes
        private int id;
        private int inscripciones_Id;
        private String nombre;
        private int idInscripcion;
        private int anio;
        private int nroInscripcion;
        private String estado;
        private String fechaInicio;
        private String fechaFin;
        //Constructors
        public Instancias(int id, int inscripciones_Id, string nombre, int idInscripcion, int anio, int nroInscripcion, string estado, string fechaInicio, string fechaFin)
        {
            this.Id = id;
            this.Inscripciones_Id = inscripciones_Id;
            this.Nombre = nombre;
            this.IdInscripcion = idInscripcion;
            this.Anio = anio;
            this.NroInscripcion = nroInscripcion;
            this.Estado = estado;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
        }

        public Instancias() { }

        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public int Inscripciones_Id { get => inscripciones_Id; set => inscripciones_Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdInscripcion { get => idInscripcion; set => idInscripcion = value; }
        public int Anio { get => anio; set => anio = value; }
        public int NroInscripcion { get => nroInscripcion; set => nroInscripcion = value; }
        public string Estado { get => estado; set => estado = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
