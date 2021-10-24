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
    public class NEGTurnos
    {
        public DataTable GetTable()
        {
            DAOTurnos dao = new DAOTurnos();
            return dao.getTipoTurnosAll();

        }
        public bool ActualizarTabla(string id, string nombre, string fecha, string causa)
        {
            Turnos tn = new Turnos(id, nombre, fecha, causa);
            DAOTurnos dao = new DAOTurnos();
            int op = dao.Actualizar(tn);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool AgregarTurno(string nombre)
        {
            Turnos tn = new Turnos();
            DAOTurnos dao = new DAOTurnos();
            tn.Nombre = nombre;
            int op = dao.Insertar(tn);
            if (op == 1)
                return true;
            else
                return false;

        }
    }
}