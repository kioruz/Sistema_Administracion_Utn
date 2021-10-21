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
    public class NEGAnexos
    {
        public DataTable GetTable()
        {
            DAOAnexos dao = new DAOAnexos();
            return dao.getAnexosAll();

        }
        public bool ActualizarTabla(string id , string nombre, string fecha , string causa)
        {
            Anexos an = new Anexos(id,nombre,fecha,causa);
            DAOAnexos dao = new DAOAnexos();
            int op = dao.Actualizar(an);
            if (op == 1)
                return true;
            else
                return false;
                
        }
        public bool AgregarAnexo(string id, string nombre, string fecha, string causa)
        {
            Anexos an = new Anexos();
            DAOAnexos dao = new DAOAnexos();
            an.Id = id;
            an.Nombre = nombre;
            an.FechaBaja = fecha;
            an.CausaBaja = causa;
           int op = dao.Insertar(an);
            if (op == 1)
                return true;
            else
                return false;

        }
    }
}
