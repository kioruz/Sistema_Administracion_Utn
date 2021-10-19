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
    public class DAOInscripciones
    {
        AccesoBase ds = new AccesoBase();

        public Inscripciones getInscripcionesId(String IdInscripciones)
        {
            Inscripciones ins = new Inscripciones();
            DataTable tabla = ds.ObtenerTabla("INSCRIPCIONES", "select * from \"INSCRIPCIONES\" where \"Id\" like " + "'"+IdInscripciones+"'");
            ins.Id = int.Parse(IdInscripciones);
            ins.Nombre = tabla.Rows[0][1].ToString();
            ins.FechaBaja = tabla.Rows[0][2].ToString();
            ins.CausaBaja = tabla.Rows[0][3].ToString();
           
            return ins;
        }

        public DataTable getInscripcionesAll()
        {
            List<Inscripciones> lista = new List<Inscripciones>();
            DataTable tabla = ds.ObtenerTabla("INSCRIPCIONES", "select * from \"INSCRIPCIONES\" ");

            return tabla;
        }
        public int Insertar(Inscripciones ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call pdinsertarinscripcion(:p_nombre, :p_fecha, :p_causa )");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = ins.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "pdinsertarinscripcion");

        }
        
        /*Create or replace procedure pdinsertarinscripcion (p_nombre character varying ,
											  p_fecha date,
											  p_causa text)
            as 
            $$
	            begin
		            insert into "INSCRIPCIONES" ("Nombre", "Fechabaja",
					            "Causabaja")
		            values(p_nombre,p_fecha,
			               p_causa);
		            end;
            $$
            language plpgsql;*/



        public int Actualizar(Inscripciones ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call pdupdateinscripciones(:p_id, :p_nombre, :p_fecha, :p_causa )");
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = ins.Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = ins.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "PDUpdateInscripciones");
        }
        /*create or replace procedure PDUpdateCarreras(p_id integer,
											   p_nombre character varying,
											   p_fecha date,
											   p_causa text)
        as
        $$
	        begin
		        update "INSCRIPCIONES" set "Nombre" = p_nombre,  
					                    "Fechabaja" = p_fecha, "Causabaja" = p_causa 
										where "Id" = p_id;		
            end;
        $$
        language plpgsql;*/
    }
}

