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
    public class NEGMaterias
    {
        public DataTable GetTable()
        {
            DAOMaterias dao = new DAOMaterias(); 
            return dao.getMateriasAll();
        }
        public bool ActualizarTabla(string id, string nombre, string fecha, string causa)
        {
            Materias MatEn = new Materias();
            DAOMaterias dao = new DAOMaterias();
            MatEn.Id = int.Parse(id);
            MatEn.Nombre = nombre;
            MatEn.FechaBaja = fecha;
            MatEn.CausaBaja = causa;
            

            int op = dao.Actualizar(MatEn);
            if (op == 1)
                return true;
            else
                return false;
        }
      
        
        public string AgregarMateria(string nombre)
        {
            Materias MatEn = new Materias();
            DAOMaterias dao = new DAOMaterias();

             MatEn.Nombre = nombre;
                  
            if (dao.Insertar(MatEn) == 1)
            { 
              return "Agregado"; 
            }
            else 
            { 
              return "Error al Agregar"; 
            }
        }
    }
}
