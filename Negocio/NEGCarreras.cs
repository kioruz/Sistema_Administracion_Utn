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
    public class NEGCarreras
    {
        public DataTable GetTable()
        {
            DAOCarreras dao = new DAOCarreras();
            return dao.getCarrerasAll();

        }

        public bool ActualizarTabla(string id, string inscripcion_ID, string tipoCarrera_ID, string nombre, string codigoInterno, string fecha, string causa)
        {
            Carreras carreras = new Carreras();
            DAOCarreras dao = new DAOCarreras();
            carreras.Inscripciones_Id = inscripcion_ID;
            carreras.Tipos_Carreras_Id = tipoCarrera_ID;
            carreras.Nombre = nombre;
            carreras.CodigoInterno = codigoInterno;
            carreras.Id = id;
            carreras.FechaBaja = fecha;
            carreras.CausaBaja = causa;

            int op = dao.Actualizar(carreras);
            if (op == 1)
                return true;
            else
                return false;
        }
        public bool AgregarCarrera(string inscripcion_ID,string tipoCarrera_ID, string nombre, string codigoInterno)
        {
            Carreras carreras = new Carreras();
            DAOCarreras dao = new DAOCarreras();
            carreras.Inscripciones_Id = inscripcion_ID;
            carreras.Tipos_Carreras_Id = tipoCarrera_ID;
            carreras.Nombre = nombre;
            carreras.CodigoInterno = codigoInterno;
            int op = dao.Insertar(carreras);
            if (op == 1)
                return true;
            else
                return false;

        }
    }
}
