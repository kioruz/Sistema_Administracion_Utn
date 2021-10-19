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

        public Usuarios getusuario(string usuario)
        {
            Usuarios us = new Usuarios();
            DataTable tabla = ds.ObtenerTabla("USUARIOS", "select \"Usuario\", \"Clave\" from \"USUARIOS\" where \"Usuario\" like " + usuario);
            us.Usuario = tabla.Rows[0][0].ToString();
            us.Clave = tabla.Rows[0][1].ToString();
            return us;
        }
        public DataTable getTablaUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            DataTable tabla = ds.ObtenerTabla("USUARIOS", "select * from USUARIOS");
            return tabla;
        }
        public int Insertar(Usuarios us)
        {
            NpgsqlCommand com = new NpgsqlCommand("call pdinsertarusuarios(:p_us, :p_apellido, :p_nombre, :p_clave, :p_fecha, :p_causa )");
            com.Parameters.Add("p_us", NpgsqlDbType.Varchar, 255).Value = us.Usuario;
            com.Parameters.Add("p_apellido", NpgsqlDbType.Varchar, 255).Value = us.Apellido;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = us.Nombre;
            com.Parameters.Add("p_clave", NpgsqlDbType.Varchar, 255).Value = us.Clave;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(us.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = us.CausaBaja.Trim();

            return ds.EjecutarProcedimientoAlmacenado(com, "pdinsertarmaterias");
        }
        /* Create or replace procedure pdinsertarusuarios(p_us character varying,
                                               p_apellido character varying,
                                                p_nombre character varying,
                                               p_clave character varying,
                                                p_fecha date,
                                                p_causa text)
             as 
             $$
                 begin
                     insert into "USUARIOS" ("Usuario","Apellido","Nombre","Clave", "Fechabaja",
                                 "Causabaja")
                     values(p_us, p_apellido, p_nombre, p_clave, p_fecha,
                            p_causa);
         end;
             $$
             language plpgsql;*/
        public int Actualizar(Usuarios us)
        {
            NpgsqlCommand com = new NpgsqlCommand("call pdupdateusuarios(:p_us, :p_apellido, :p_nombre, :p_clave, :p_fecha, :p_causa )");
            com.Parameters.Add("p_us", NpgsqlDbType.Varchar, 255).Value = us.Usuario;
            com.Parameters.Add("p_apellido", NpgsqlDbType.Varchar, 255).Value = us.Apellido;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = us.Nombre;
            com.Parameters.Add("p_clave", NpgsqlDbType.Varchar, 255).Value = us.Clave;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(us.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = us.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "pdupdateusuarios");
        }

        /*create or replace procedure pdupdateusuarios( p_us character varying,
											  p_apellido character varying,
                                               p_nombre character varying,
											  p_clave character varying,
                                               p_fecha date,
                                               p_causa text)
        as
        $$
            begin
                update "USUARIOS" set 
										"Apellido" = p_apellido,"Nombre"=p_nombre,
										"Clave" = p_clave,
                                        "Fechabaja" = p_fecha, "Causabaja" = p_causa 
                                        where "Usuario" = p_us;		
            end;
        $$
        language plpgsql;
        */
    }
}