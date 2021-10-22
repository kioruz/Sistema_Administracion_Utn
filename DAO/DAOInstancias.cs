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

        public Instancias getInstanciaId(String Idinstancia)
        {
            Instancias ins = new Instancias();
            DataTable tabla = ds.ObtenerTabla("INSTANCIAS", "select * from \"INSTANCIAS\" where \"Id\" like " + "'" + Idinstancia + "'");
            ins.Id = int.Parse(Idinstancia);
            ins.Inscripciones_Id = int.Parse(tabla.Rows[0][1].ToString());       
            ins.Nombre = tabla.Rows[0][2].ToString();
            ins.IdInscripcion = int.Parse(tabla.Rows[0][4].ToString());
            ins.Anio = int.Parse( tabla.Rows[0][5].ToString());
            ins.NroInscripcion = int.Parse(tabla.Rows[0][5].ToString());
            ins.Estado = tabla.Rows[0][6].ToString();
            ins.FechaInicio = tabla.Rows[0][7].ToString();
            ins.FechaFin = tabla.Rows[0][8].ToString();
            return ins;
        }

        public DataTable getInstanciasAll()
        {
            List<Instancias> lista = new List<Instancias>();
            DataTable tabla = ds.ObtenerTabla("INSTANCIAS", "select * from \"INSTANCIAS\" ");

            return tabla;
        }
        public int Insertar(Instancias ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_INSTANCIAS(:p_incripcion_id, :p_nombre, :p_idinscripcion, :p_anio," +
                                                    ":p_nroInscripcion, :p_estado, :p_fechainicio ,:p_fechafin )");
            com.Parameters.AddWithValue("p_incripcion_id", DbType.Int32).Value = ins.Inscripciones_Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;

            com.Parameters.AddWithValue("p_idinscripcion", NpgsqlDbType.Integer).Value = ins.IdInscripcion;
            com.Parameters.AddWithValue("p_anio", NpgsqlDbType.Smallint).Value = ins.Anio;

            com.Parameters.AddWithValue("p_nroInscripcion", DbType.Int32).Value = ins.NroInscripcion;
            com.Parameters.Add("p_estado", NpgsqlDbType.Varchar, 20).Value = ins.Estado;

            com.Parameters.AddWithValue("p_fechainicio", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaInicio).Date;
            com.Parameters.AddWithValue("p_fechafin", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaFin).Date;
            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_INSTANCIAS");

        }

        public int Actualizar(Instancias ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_INSTANCIAS(:p_id ,:p_incripcion_id, :p_nombre, :p_idinscripcion, :p_anio," +
                                                    ":p_nroInscripcion, :p_estado, :p_fechainicio ,:p_fechafin )");
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = ins.Id;
            com.Parameters.AddWithValue("p_incripcion_id", DbType.Int32).Value = ins.Inscripciones_Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;

            com.Parameters.AddWithValue("p_idinscripcion", NpgsqlDbType.Integer).Value = ins.IdInscripcion;
            com.Parameters.Add("p_anio", NpgsqlDbType.Smallint).Value = ins.Anio;

            com.Parameters.AddWithValue("p_nroInscripcion", DbType.Int32).Value = ins.NroInscripcion;
            com.Parameters.Add("p_estado", NpgsqlDbType.Varchar, 20).Value = ins.Estado;

            com.Parameters.Add("p_fechainicio", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaInicio).Date;
            com.Parameters.Add("p_fechafin", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaFin).Date;
            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_INSTANCIAS");
        }
    }
}

