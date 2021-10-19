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
        public bool ActualizarTabla(string id,string inscripciones_Id, string nombre, string  idInscripcion, int anio, string nroInscripcion, 
                                    string estado, string  fechaInicio, string fechaFin)
        {
            Instancias ins = new Instancias(int.Parse(id),int.Parse(inscripciones_Id),nombre,int.Parse(idInscripcion),anio,int.Parse(nroInscripcion),estado,fechaInicio,fechaFin);
            DAOInstancias dao = new DAOInstancias();
            int op = dao.Actualizar(ins);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool ActualizarxEntidad(Instancias ins)
        {
            DAOInstancias dao = new DAOInstancias();
            int op = dao.Actualizar(ins);
            if (op == 1)
                return true;
            else
                return false;
        }
        public bool AgregarInstancia(string inscripciones_Id, string nombre, string idInscripcion, string anio, string nroInscripcion,
                                    string estado, string fechaInicio, string fechaFin)
        {
            Instancias ins = new Instancias();
            DAOInstancias dao = new DAOInstancias();
            ins.Inscripciones_Id = int.Parse(inscripciones_Id);
            ins.Nombre = nombre;
            ins.IdInscripcion = int.Parse(idInscripcion);
            ins.Anio = int.Parse(anio);
            ins.NroInscripcion = int.Parse(nroInscripcion);
            ins.Estado = estado;
            ins.FechaInicio = fechaInicio;
            ins.FechaFin = fechaFin;

            int op = dao.Insertar(ins);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool AgregarInstancia(Instancias ins)
        {
            
            DAOInstancias dao = new DAOInstancias();
            int op = dao.Insertar(ins);
            if (op == 1)
                return true;
            else
                return false;

        }

    }
}
