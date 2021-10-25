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
    public class DAOTurnos
    {
    
    AccesoBase ds = new AccesoBase();

    public DataTable getTipoTurnosAll()
    {
        List<Turnos> lista = new List<Turnos>();
        DataTable tabla = ds.ObtenerTabla("TURNOS", "select * from \"TURNOS\" ");

        return tabla;
    }
    public int Insertar(Turnos tn)
    {
        NpgsqlCommand com = new NpgsqlCommand("call insertar_TURNOS(:p_nombre)");
        com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tn.Nombre;
        return ds.EjecutarProcedimientoAlmacenado(com, "insertar_TURNOS");
    }

        public int Actualizar(Turnos ins)
    {
        NpgsqlCommand com = new NpgsqlCommand("call actualizar_TURNOS(:p_id, :p_nombre, :p_fecha, :p_causa )");

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

            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_TURNOS");
    }
    }
}


