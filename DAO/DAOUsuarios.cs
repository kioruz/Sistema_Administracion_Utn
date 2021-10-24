using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Entidad;
using System.Data;
using System.Data.SqlClient;
using NpgsqlTypes;

namespace DAO
{
    public class DAOUsuarios
    {
        AccesoBase ds = new AccesoBase();

        public Usuarios getusuario(String usuario, String contraseña)
        {
            Usuarios user = new Usuarios();
            String nombreTabla = "\"USUARIOS\"";
            String consulta = $"select * from {nombreTabla} where \"Usuario\" like '{usuario}' and \"Clave\" like '{contraseña}'";
            try
            {
                DataRow tblUsuarios = ds.ObtenerTabla(nombreTabla, consulta).Rows[0];
                user.Usuario = tblUsuarios["Usuario"].ToString();
                user.Apellido = tblUsuarios["Apellido"].ToString();
                user.Nombre = tblUsuarios["Nombre"].ToString();
                user.Clave = tblUsuarios["Clave"].ToString();
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public DataTable getTablaUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            DataTable tabla = ds.ObtenerTabla("\"USUARIOS\"", "select * from \"USUARIOS\"");
            return tabla;
        }
        public int Insertar(Usuarios user)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_USUARIOS(:p_us, :p_apellido, :p_nombre, :p_clave)");
            com.Parameters.Add("p_us", NpgsqlDbType.Varchar, 255).Value = user.Usuario;
            com.Parameters.Add("p_apellido", NpgsqlDbType.Varchar, 255).Value = user.Apellido;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = user.Nombre;
            com.Parameters.Add("p_clave", NpgsqlDbType.Varchar, 255).Value = user.Clave;

            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_USUARIOS");
        }
        public int Actualizar(Usuarios us)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_USUARIOS(:p_us, :p_apellido, :p_nombre, :p_clave, :p_fecha, :p_causa )");
           
            com.Parameters.Add("p_us", NpgsqlDbType.Varchar, 255).Value = us.Usuario;
            com.Parameters.Add("p_apellido", NpgsqlDbType.Varchar, 255).Value = us.Apellido;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = us.Nombre;
            com.Parameters.Add("p_clave", NpgsqlDbType.Varchar, 255).Value = us.Clave;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = us.Nombre;

            if (us.FechaBaja != "")
            {
                com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(us.FechaBaja).Date;
            }
            else
            {
                com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DBNull.Value;
            }

            if (us.CausaBaja != "")
            {
                com.Parameters.Add("p_causa", NpgsqlDbType.Text).Value = us.CausaBaja.Trim();
            }
            else
            {
                com.Parameters.Add("p_causa", NpgsqlDbType.Text).Value = DBNull.Value;
            }
            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_USUARIOS");
        }
    }
}