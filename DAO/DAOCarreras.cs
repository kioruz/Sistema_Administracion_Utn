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

        public DataTable getCarrerasAll()
        {
            List<Carreras> lista = new List<Carreras>();
            DataTable tabla = ds.ObtenerTabla("CARRERAS", "select * from \"CARRERAS\" ");
            
            return tabla;
        }
        public int Insertar(Carreras ca)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_CARRERAS(:p_inscripcion_id, :p_tipo_car_id, :p_nombre, :p_codigoint)");
            
            com.Parameters.AddWithValue("p_inscripcion_id", DbType.Int32).Value = Convert.ToInt32(ca.Inscripciones_Id);
            com.Parameters.AddWithValue("p_tipo_car_id", DbType.Int32).Value = Convert.ToInt32(ca.Tipos_Carreras_Id);
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ca.Nombre;
            com.Parameters.Add("p_codigoint", NpgsqlDbType.Varchar, 20).Value = ca.CodigoInterno.Trim();

            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_CARRERAS");
        }
        public int Actualizar(Carreras ca)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_CARRERAS(:p_inscripcion_id, :p_tipo_car_id, :p_nombre, :p_codigoint, :p_fecha ,:p_causa, :p_id)");

            com.Parameters.AddWithValue("p_inscripcion_id", DbType.Int32).Value = Convert.ToInt32(ca.Inscripciones_Id);
            com.Parameters.AddWithValue("p_tipo_car_id", DbType.Int32).Value = Convert.ToInt32(ca.Tipos_Carreras_Id);
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = ca.Nombre;
            com.Parameters.Add("p_codigoint", NpgsqlDbType.Varchar, 20).Value = ca.CodigoInterno.Trim();
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = Convert.ToInt32(ca.Id);
            
            if (ca.FechaBaja != "")
            {
                com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ca.FechaBaja).Date;
            }
            else
            {
                com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DBNull.Value;
            }

            if (ca.CausaBaja != "")
            {
                com.Parameters.Add("p_causa", NpgsqlDbType.Text).Value = ca.CausaBaja.Trim();
            }
            else
            {
                com.Parameters.Add("p_causa", NpgsqlDbType.Text).Value = DBNull.Value;
            }
            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_CARRERAS");
        }
    }
}
