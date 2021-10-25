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

        public DataTable getInscripcionesAll()
        {
            List<Inscripciones> lista = new List<Inscripciones>();
            DataTable tabla = ds.ObtenerTabla("INSCRIPCIONES", "select * from \"INSCRIPCIONES\" ");

            return tabla;
        }
        public int Insertar(Inscripciones ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_INSCRIPCIONES(:p_nombre)");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;
            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_INSCRIPCION");
        }

        public int Actualizar(Inscripciones ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_INSCRIPCIONES(:p_id, :p_nombre, :p_fecha, :p_causa)");
            
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = Convert.ToInt32(ins.Id);
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;

            if (ins.FechaBaja != "")
            {
                com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ins.FechaBaja).Date;
            }
            else
            {
                com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DBNull.Value;
            }

            if (ins.CausaBaja != "")
            {
                com.Parameters.Add("p_causa", NpgsqlDbType.Text).Value = ins.CausaBaja.Trim();
            }
            else
            {
                com.Parameters.Add("p_causa", NpgsqlDbType.Text).Value = DBNull.Value;
            }

            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_INSCRIPCIONES");
        }
    }
}

