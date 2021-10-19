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
    public class DAOCarreras
    {
        AccesoBase ds = new AccesoBase();

        public Carreras getCarrerasId(String IdCarrera)
        {
            Carreras ca = new Carreras();
            DataTable tabla = ds.ObtenerTabla("CARRERAS", "select * from \"CARRERAS\" where \"Id\" like " + "'"+IdCarrera+"'");
            ca.Id = int.Parse(IdCarrera);
            ca.IdInscripcion = int.Parse( tabla.Rows[0][1].ToString());
            ca.Tipos_Carreras_Id = int.Parse(tabla.Rows[0][2].ToString());
            ca.Nombre = tabla.Rows[0][3].ToString();
            ca.CodigoInterno = tabla.Rows[0][4].ToString();
            ca.IdTipoCarrera = int.Parse(tabla.Rows[0][5].ToString());
            ca.IdInscripcion = int.Parse(tabla.Rows[0][6].ToString());
            ca.FechaBaja = tabla.Rows[0][7].ToString();
            ca.CausaBaja = tabla.Rows[0][8].ToString();
            return ca;
        }

        public DataTable getCarrerasAll()
        {
            List<Carreras> lista = new List<Carreras>();
            DataTable tabla = ds.ObtenerTabla("CARRERAS", "select * from \"CARRERAS\" ");
            
            return tabla;
        }
        public int Insertar(Carreras ca)
        {
            NpgsqlCommand com = new NpgsqlCommand("call pdinsertarcarrera(:p_incripcion_id, :p_tipo_car_id, :p_nombre, :p_codigoint," +
                                                    ":p_id_tipo_car, :p_idinsc, :p_fecha ,:p_causa )");
            com.Parameters.AddWithValue("p_incripcion_id", DbType.Int32).Value = ca.IdInscripcion;
            com.Parameters.AddWithValue("p_tipo_car_id", DbType.Int32).Value = ca.Tipos_Carreras_Id;

            com.Parameters.AddWithValue("p_nombre", NpgsqlDbType.Varchar, 255).Value = ca.Nombre;
            com.Parameters.AddWithValue("p_codigoint", NpgsqlDbType.Varchar, 20).Value = ca.CodigoInterno.Trim();

            com.Parameters.AddWithValue("p_id_tipo_car", DbType.Int32).Value = ca.IdTipoCarrera;
            com.Parameters.AddWithValue("p_idinsc", DbType.Int32).Value = ca.IdInscripcion;

            com.Parameters.AddWithValue("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ca.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = ca.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "PDInsertarCarrera");

        }

        /*Create or replace procedure pdinsertarcarrera (p_incripcion_id integer,
											   p_tipo_car_id integer,
											   p_nombre character varying,
											   p_codigoint integer,
											   p_id_tipo_car integer,
											   p_idinsc integer,
											   p_fecha date,
											   p_causa text)
            as 
            $$
	            begin
		            insert into "CARRERAS" ("INCRIPCIONES_Id", "TIPO_CARRERAS_Id",
					            "Nombre", "Codigointerno", "Idtipocarrera", "Idinscripcion",
					            "Fechabaja", "Causabaja")
		            values(p_incripcion_id,p_tipo_car_id,
			               p_nombre,p_codigoint,
			               p_id_tipo_car,p_idinsc,
			               p_fecha,p_causa);
		            end;
            $$
            language plpgsql;*/



        public int Actualizar(Carreras ca)
        {
            NpgsqlCommand com = new NpgsqlCommand("call pdupdatecarreras(:p_incripcion_id, :p_tipo_car_id, :p_nombre, :p_codigoint," +
                                                    ":p_id_tipo_car, :p_idinsc, :p_fecha ,:p_causa )");
            com.Parameters.AddWithValue("p_incripcion_id", DbType.Int32).Value = ca.IdInscripcion;
            com.Parameters.AddWithValue("p_tipo_car_id", DbType.Int32).Value = ca.Tipos_Carreras_Id;

            com.Parameters.AddWithValue("p_nombre", NpgsqlDbType.Varchar, 255).Value = ca.Nombre;
            com.Parameters.AddWithValue("p_codigoint", NpgsqlDbType.Varchar, 20).Value = ca.CodigoInterno.Trim();

            com.Parameters.AddWithValue("p_id_tipo_car", DbType.Int32).Value = ca.IdTipoCarrera;
            com.Parameters.AddWithValue("p_idinsc", DbType.Int32).Value = ca.IdInscripcion;

            com.Parameters.AddWithValue("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ca.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = ca.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "PDUpdateCarreras");
        }

       
        /*create or replace procedure PDUpdateCarreras(p_incripcion_id integer,
											   p_tipo_car_id integer,
											   p_nombre character varying,
											   p_codigoint integer,
											   p_id_tipo_car integer,
											   p_idinsc integer,
											   p_fecha date,
											   p_causa text,
                                               p_id integer)
        as
        $$
	        begin
		        update "CARRERAS" set "INCRIPCIONES_Id" = p_incripcion_id, "TIPO_CARRERAS_Id" = p_tipo_car_id,
					                    "Nombre" = p_nombre, "Codigointerno" = p_codigoint, "Idtipocarrera" = p_id_tipo_car, "Idinscripcion" = p_idinsc,
					                    "Fechabaja" = p_fecha, "Causabaja" = p_causa where "Id" = p_id;
            end;
        $$
        language plpgsql;*/
    }
}
