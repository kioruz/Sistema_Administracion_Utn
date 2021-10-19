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
           // DataTable tabla = dao.getMateriasAll();
            //DateTime fecha = new DateTime();

           // String f = "";
          /*  foreach(DataRow row in tabla.Rows)
            {   
                //Elimina fecha de Date pero la agrega en el array.
               if(!string.IsNullOrEmpty( row[2].ToString()))
                {
                    fecha = DateTime.Parse(row[2].ToString());
                    f = fecha.ToString("dd/MM/yyyy");
                    row[2] = f;
                }
            }
            return tabla;*/
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
      
        
        public string AgregarMateria(string id, string nomb, string fecha, string causa)
        {
            Materias MatEn = new Materias();
            DAOMaterias dao = new DAOMaterias();
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nomb) || string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(causa))
            { return "No se permiten espacios vacios"; }
            else
            {
                MatEn.Nombre = nomb;
                MatEn.FechaBaja = fecha;
                MatEn.CausaBaja = causa;
                  
                    if (dao.Insertar(MatEn) == 1)
                    { return "Agregado"; }
                    else { return "Error al Agregar"; }

            }
        }
       
    }
}
