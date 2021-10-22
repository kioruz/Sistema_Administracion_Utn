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
            ins.Id = IdInscripciones;
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
            NpgsqlCommand com = new NpgsqlCommand("call insertar_INSCRIPCION(:p_nombre, :tabla)");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;
            com.Parameters.Add("tabla", NpgsqlDbType.Varchar, 255).Value = "\"Inscripciones\"";
            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_INSCRIPCION");
        }

        public int Actualizar(Inscripciones ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_INSCRIPCION(:p_id, :p_nombre, :p_fecha, :p_causa, :tabla)");
            
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = Convert.ToInt32(ins.Id);
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ins.Nombre;
            com.Parameters.Add("tabla", NpgsqlDbType.Varchar, 255).Value = "\"INSCRIPCIONES\"";

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
                com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = ins.CausaBaja.Trim();
            }
            else
            {
                com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = DBNull.Value;
            }

            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_INSCRIPCION");
        }
    }
}

