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
        private String anio;
        private String estado;
        private String fechaInicio;
        private String fechaFin;
        //Constructors
        public Instancias(int id, int inscripciones_Id, string nombre, string anio, string estado, string fechaInicio, string fechaFin)
        {
            this.Id = id;
            this.Inscripciones_Id = inscripciones_Id;
            this.Nombre = nombre;
            this.Anio = anio;
            this.Estado = estado;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
        }

        public Instancias() { }

        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public int Inscripciones_Id { get => inscripciones_Id; set => inscripciones_Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Anio { get => anio; set => anio = value; }
        public string Estado { get => estado; set => estado = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
