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
    public class DAOTipos_Carreras
    {
    
    AccesoBase ds = new AccesoBase();

        public DataTable getTipoCarrerasAll()
        {
        List<Modalidades> lista = new List<Modalidades>();
        DataTable tabla = ds.ObtenerTabla("TIPOS_CARRERAS", "select * from \"TIPOS_CARRERAS\" ");

        return tabla;
        }
        public int Insertar(Tipos_Carreras tc)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_TIPOS_CARRERAS(:p_nombre)");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tc.Nombre;
            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_TIPOS_CARRERAS");
        }

        public int Actualizar(Tipos_Carreras ins)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_TIPOS_CARRERAS(:p_id, :p_nombre, :p_fecha, :p_causa )");

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

            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_TIPOS_CARRERAS");
        }

    }
}

