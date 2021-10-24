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
    public class NEGModalidades
    {
        public DataTable GetTable()
        {
            DAOModalidad dao = new DAOModalidad();
            return dao.getModalidadesAll();

        }
        public bool ActualizarTabla(string id, string nombre, string fecha, string causa)
        {
            Modalidades mod = new Modalidades(id, nombre, fecha, causa);
            DAOModalidad dao = new DAOModalidad();
            int op = dao.Actualizar(mod);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool AgregarModalidad(string nombre)
        {
            Modalidades mod = new Modalidades();
            DAOModalidad dao = new DAOModalidad();
            mod.Nombre = nombre;
            int op = dao.Insertar(mod);
            if (op == 1)
                return true;
            else
                return false;

        }
    }
}
