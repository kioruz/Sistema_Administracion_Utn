using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidad;
using DAO;

namespace Negocio
{
    public class NEGInstancias
    {
        public DataTable GetTable()
        {
             DAOInstancias dao = new DAOInstancias();
            return dao.getInstanciasAll();

        }
        public bool ActualizarTabla(string id,string inscripciones_Id, string nombre, string anio, string estado, string  fechaInicio, string fechaFin)
        {
            Instancias ins = new Instancias();

            ins.Id = int.Parse(id);
            ins.Inscripciones_Id = int.Parse(inscripciones_Id);
            ins.Nombre = nombre;
            ins.Anio = anio;
            ins.Estado = estado;
            ins.FechaInicio = fechaInicio;
            ins.FechaFin = fechaFin;

            DAOInstancias dao = new DAOInstancias();
            int op = dao.Actualizar(ins);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool AgregarInstancia(string inscripciones_Id, string nombre, string anio, string estado, string fechaInicio, string fechaFin)
        {
            Instancias ins = new Instancias();
            DAOInstancias dao = new DAOInstancias();
            ins.Inscripciones_Id = int.Parse(inscripciones_Id);
            ins.Nombre = nombre;
            ins.Anio = anio;
            ins.Estado = estado;
            ins.FechaInicio = fechaInicio;
            ins.FechaFin = fechaFin;

            int op = dao.Insertar(ins);
            if (op == 1)
                return true;
            else
                return false;

        }
    }
}
