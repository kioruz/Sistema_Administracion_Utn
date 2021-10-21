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
    public class DAOTurnos
    {
    
    AccesoBase ds = new AccesoBase();

    public Turnos getTipoTurnossId(String idTurnos)
    {
        Turnos tn = new Turnos();
        DataTable tabla = ds.ObtenerTabla("TURNOS", "select * from \"TURNOS\" where \"Id\" like " + "'" + idTurnos + "'");
        tn.Id = idTurnos;
        tn.Nombre = tabla.Rows[0][1].ToString();
        tn.FechaBaja = tabla.Rows[0][2].ToString();
        tn.CausaBaja = tabla.Rows[0][3].ToString();

        return tn;
    }

    public DataTable getTipoTurnosAll()
    {
        List<Turnos> lista = new List<Turnos>();
        DataTable tabla = ds.ObtenerTabla("TURNOS", "select * from \"TURNOS\" ");

        return tabla;
    }
    public int Insertar(Turnos tn)
    {
        NpgsqlCommand com = new NpgsqlCommand("call pdinsertarturnos(:p_nombre, :p_fecha, :p_causa )");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tn.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(tn.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = tn.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "pdinsertarturnos");

    }

        /*Create or replace procedure pdinsertarturnos (p_nombre character varying ,
                                              p_fecha date,
                                              p_causa text)
            as 
            $$
                begin
                    insert into "TURNOS" ("Nombre", "Fechabaja",
                                "Causabaja")
                    values(p_nombre,p_fecha,
                           p_causa);
                    end;
            $$
            language plpgsql;*/



        public int Actualizar(Turnos tn)
    {
        NpgsqlCommand com = new NpgsqlCommand("call pdupdateturnos(:p_id, :p_nombre, :p_fecha, :p_causa )");
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = tn.Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tn.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(tn.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = tn.CausaBaja.Trim();
            
        return ds.EjecutarProcedimientoAlmacenado(com, "pdupdateturnos");
    }


        /*create or replace procedure pdupdateturnos(p_id integer,
                                               p_nombre character varying,
                                               p_fecha date,
                                               p_causa text)
        as
        $$
            begin
                update "TURNOS" set "Nombre" = p_nombre,  
                                        "Fechabaja" = p_fecha, "Causabaja" = p_causa 
                                        where "Id" = p_id;		
            end;
        $$
        language plpgsql;*/
    }
}


