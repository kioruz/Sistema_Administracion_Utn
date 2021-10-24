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
    public class NEGTipos_Carreras
    {
        public DataTable GetTable()
        {
            DAOTipos_Carreras dao = new DAOTipos_Carreras();
            return dao.getTipoCarrerasAll();

        }
        public bool ActualizarTabla(string id, string nombre, string fecha, string causa)
        {
            Tipos_Carreras car = new Tipos_Carreras(id, nombre, fecha, causa);
            DAOTipos_Carreras dao = new DAOTipos_Carreras();
            int op = dao.Actualizar(car);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool AgregarTipoCarrera(string nombre)
        {
            Tipos_Carreras car = new Tipos_Carreras();
            DAOTipos_Carreras dao = new DAOTipos_Carreras();
            car.Nombre = nombre;
            int op = dao.Insertar(car);
            if (op == 1)
                return true;
            else
                return false;

        }
    }
}
