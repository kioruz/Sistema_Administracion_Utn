using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using DAO;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Negocio
{
    public class NEGUsuarios
    {
        DAOUsuarios dao = new DAOUsuarios();
        public string GetMD5(string str)
         {
             MD5 md5 = MD5CryptoServiceProvider.Create();
             ASCIIEncoding encoding = new ASCIIEncoding();
             byte[] stream = null;
             StringBuilder sb = new StringBuilder();
             stream = md5.ComputeHash(encoding.GetBytes(str));
             for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
             return sb.ToString();
         }
        
        public bool ActualizarUsuario(string usuario, string nombre, string apellido, string clave, string fecha, string causa)
        {
            Usuarios us = new Usuarios();
            DAOUsuarios dao = new DAOUsuarios();
            us.Usuario = usuario;
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
        public void AgregarUsuario(Usuarios user)
        {
           dao.Insertar(user);
        }
        public DataTable TablaUsuarios()
        {
            return dao.getTablaUsuarios();
        }
        public Usuarios login(String userName, String password)
        {
            return dao.getusuario(userName,password);
        }
    }
}