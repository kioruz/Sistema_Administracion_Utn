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
    public class NEGInscripciones
    {
        public DataTable GetTable()
        {
            DAOInscripciones dao = new DAOInscripciones();
            return dao.getInscripcionesAll();

        }
        public bool ActualizarTabla(string id, string nombre, string fecha, string causa)
        {
            Inscripciones ins = new Inscripciones(id, nombre, fecha, causa);
            DAOInscripciones dao = new DAOInscripciones();
            int op = dao.Actualizar(ins);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool AgregarInscripcion(string nombre)
        {
            Inscripciones ins = new Inscripciones();
            DAOInscripciones dao = new DAOInscripciones();
            ins.Nombre = nombre;
            int op = dao.Insertar(ins);
            if (op == 1)
                return true;
            else
                return false;

        }
    }
}

