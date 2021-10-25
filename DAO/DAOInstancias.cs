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
    public class DAOInstancias
    {
        AccesoBase ds = new AccesoBase();

        public DataTable getInstanciasAll()
        {
            List<Instancias> lista = new List<Instancias>();
            DataTable tabla = ds.ObtenerTabla("INSTANCIAS", "select * from \"INSTANCIAS\" ");

            return tabla;
        }
        public int Insertar(Instancias ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_INSTANCIAS(:p_incripcion_id, :p_nombre, :p_anio, :p_estado, :p_fechainicio ,:p_fechafin)");
            
            com.Parameters.AddWithValue("p_incripcion_id", NpgsqlDbType.Integer).Value = ins.Inscripciones_Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;
            com.Parameters.AddWithValue("p_anio", NpgsqlDbType.Smallint).Value = Convert.ToInt16(ins.Anio);
            com.Parameters.Add("p_estado", NpgsqlDbType.Varchar, 20).Value = ins.Estado;
            com.Parameters.Add("p_fechainicio", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaInicio).Date;
            com.Parameters.Add("p_fechafin", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaFin).Date;

            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_INSTANCIAS");
        }

        public int Actualizar(Instancias ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_INSTANCIAS(:p_id ,:p_incripcion_id, :p_nombre, :p_anio, :p_estado, :p_fechainicio ,:p_fechafin)");

            com.Parameters.AddWithValue("p_incripcion_id", NpgsqlDbType.Integer).Value = ins.Inscripciones_Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;
            com.Parameters.AddWithValue("p_anio", NpgsqlDbType.Smallint).Value = Convert.ToInt16(ins.Anio);
            com.Parameters.Add("p_estado", NpgsqlDbType.Varchar, 20).Value = ins.Estado;
            com.Parameters.Add("p_fechainicio", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaInicio).Date;
            com.Parameters.Add("p_fechafin", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaFin).Date;
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = ins.Id;

            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_INSTANCIAS");
        }
    }
}

