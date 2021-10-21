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
    public class DAOTipos_Carreras
    {
    
    AccesoBase ds = new AccesoBase();

    public Tipos_Carreras getTipoCarrerasId(String idTipo_Carreras)
    {
        Tipos_Carreras tc = new Tipos_Carreras();
        DataTable tabla = ds.ObtenerTabla("TIPOS_CARRERAS", "select * from \"TIPOS_CARRERAS\" where \"Id\" like " + "'" + idTipo_Carreras + "'");
        tc.Id = idTipo_Carreras;
        tc.Nombre = tabla.Rows[0][1].ToString();
        tc.FechaBaja = tabla.Rows[0][2].ToString();
        tc.CausaBaja = tabla.Rows[0][3].ToString();

        return tc;
    }

    public DataTable getTipoCarrerasAll()
    {
        List<Modalidades> lista = new List<Modalidades>();
        DataTable tabla = ds.ObtenerTabla("TIPOS_CARRERAS", "select * from \"TIPOS_CARRERAS\" ");

        return tabla;
    }
    public int Insertar(Tipos_Carreras tc)
    {
        NpgsqlCommand com = new NpgsqlCommand("call pdinsertartipocarreras(:p_nombre, :p_fecha, :p_causa )");
        com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tc.Nombre;
        com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(tc.FechaBaja).Date;
        com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = tc.CausaBaja.Trim();
        return ds.EjecutarProcedimientoAlmacenado(com, "pdinsertartipocarreras");

    }

        /*Create or replace procedure pdinsertartipocarreras (p_nombre character varying ,
                                              p_fecha date,
                                              p_causa text)
            as 
            $$
                begin
                    insert into "TIPOS_CARRERAS" ("Nombre", "Fechabaja",
                                "Causabaja")
                    values(p_nombre,p_fecha,
                           p_causa);
                    end;
            $$
            language plpgsql;*/



        public int Actualizar(Tipos_Carreras tc)
    {
        NpgsqlCommand com = new NpgsqlCommand("call pdupdatetipocarreras(:p_id :p_nombre, :p_fecha, :p_causa )");
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = tc.Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tc.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(tc.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = tc.CausaBaja.Trim();
           
        return ds.EjecutarProcedimientoAlmacenado(com, "pdupdatetipocarreras");
    }


        /*create or replace procedure pdupdatetipocarreras(p_id integer,
                                               p_nombre character varying,
                                               p_fecha date,
                                               p_causa text)
        as
        $$
            begin
                update "TIPOS_CARRERAS" set "Nombre" = p_nombre,  
                                        "Fechabaja" = p_fecha, "Causabaja" = p_causa 
                                        where "Id" = p_id;		
            end;
        $$
        language plpgsql;*/
    }
}

