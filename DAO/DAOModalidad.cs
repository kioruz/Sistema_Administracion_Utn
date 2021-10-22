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
            NpgsqlCommand com = new NpgsqlCommand("call insertar_MODALIDADES(:p_nombre, :p_fecha, :p_causa )");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = mod.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(mod.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = mod.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_MODALIDADES");

        }

        public int Actualizar(Modalidades mod)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_MODALIDADES(:p_id, :p_nombre, :p_fecha, :p_causa )");
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = mod.Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = mod.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(mod.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = mod.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_MODALIDADES");
        }
    }
}

