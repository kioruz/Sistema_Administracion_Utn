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


    }
}
