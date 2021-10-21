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
    public class DAOModalidad
    {
        AccesoBase ds = new AccesoBase();

        public Modalidades getInscripcionesId(String idModalidades)
        {
            Modalidades mod = new Modalidades();
            DataTable tabla = ds.ObtenerTabla("MODALIDADES", "select * from \"MODALIDADES\" where \"Id\" like " + "'" + idModalidades + "'");
            mod.Id = idModalidades;
            mod.Nombre = tabla.Rows[0][1].ToString();
            mod.FechaBaja = tabla.Rows[0][2].ToString();
            mod.CausaBaja = tabla.Rows[0][3].ToString();

            return mod;
        }

        public DataTable getModalidadesAll()
        {
            List<Modalidades> lista = new List<Modalidades>();
            DataTable tabla = ds.ObtenerTabla("MODALIDADES", "select * from \"MODALIDADES\" ");

            return tabla;
        }
        public int Insertar(Modalidades mod)
        {
            NpgsqlCommand com = new NpgsqlCommand("call pdinsertarmodalidades(:p_nombre, :p_fecha, :p_causa )");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = mod.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(mod.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = mod.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "pdinsertarmodalidades");

        }
       
        /*Create or replace procedure pdinsertarmodalidades (p_nombre character varying ,
											  p_fecha date,
											  p_causa text)
            as 
            $$
	            begin
		            insert into "MODALIDADES" ("Nombre", "Fechabaja",
					            "Causabaja")
		            values(p_nombre,p_fecha,
			               p_causa);
		            end;
            $$
            language plpgsql;*/



        public int Actualizar(Modalidades mod)
        {
            NpgsqlCommand com = new NpgsqlCommand("call PDUpdateModalidades(:p_id, :p_nombre, :p_fecha, :p_causa )");
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = mod.Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = mod.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(mod.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = mod.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "PDUpdateModalidades");
        }

       
        /*create or replace procedure PDUpdateModalidades(p_id integer,
											   p_nombre character varying,
											   p_fecha date,
											   p_causa text)
        as
        $$
	        begin
		        update "MODALIDADES" set "Nombre" = p_nombre,  
					                    "Fechabaja" = p_fecha, "Causabaja" = p_causa 
										where "Id" = p_id;		
            end;
        $$
        language plpgsql;*/
    }
}

