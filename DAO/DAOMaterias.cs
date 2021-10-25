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
using System.Globalization;

namespace DAO
{
    public class DAOMaterias
    {
        AccesoBase ds = new AccesoBase();

        public DataTable getMateriasAll()
        {
            List<Materias> lista = new List<Materias>();
            DataTable tabla = ds.ObtenerTabla("MATERIAS", "select * from \"MATERIAS\" ");

            return tabla;
        }
        public int Insertar(Materias mat)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_MATERIAS(:p_nombre)");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = mat.Nombre;
            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_MATERIAS");

        }
        public int Actualizar(Materias ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_MATERIAS(:p_id, :p_nombre, :p_fecha, :p_causa )");

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
            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_MATERIAS");
        }
    }
}
