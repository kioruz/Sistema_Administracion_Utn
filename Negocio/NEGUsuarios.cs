using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using DAO;
using System.Data;

namespace Negocio
{
    public class NEGUsuarios
    {
        public DataTable GetTable()
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuarios();
        }
        public bool ActualizarUsuario( string nombre, string apellido, string clave, string fecha, string causa)
        {
            Usuarios us = new Usuarios();
            DAOUsuarios dao = new DAOUsuarios();
            us.Nombre = nombre;
            us.Apellido = apellido;
            us.Clave = clave;
            us.FechaBaja = fecha;
            us.CausaBaja = causa;
            int op = dao.Actualizar(us);
            if (op == 1)
                return true;
            else
                return false;

        }
        public bool AgregarUsuario(string nombre, string fecha, string causa)
        {
            Usuarios us = new Usuarios();
            DAOUsuarios dao = new DAOUsuarios();
            us.Nombre = nombre;
            us.FechaBaja = fecha;
            us.CausaBaja = causa;
            int op = dao.Insertar(us);
            if (op == 1)
                return true;
            else
                return false;

        }
        public Usuarios GetUsuarioPass(string usuario)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getusuario(usuario);
        }
        
    }
}