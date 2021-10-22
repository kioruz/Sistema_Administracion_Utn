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
            ca.Id = IdCarrera;
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
            NpgsqlCommand com = new NpgsqlCommand("call insertar_CARRERAS(:p_incripcion_id, :p_tipo_car_id, :p_nombre, :p_codigoint," +
                                                    ":p_id_tipo_car, :p_idinsc, :p_fecha ,:p_causa )");
            com.Parameters.AddWithValue("p_incripcion_id", DbType.Int32).Value = ca.IdInscripcion;
            com.Parameters.AddWithValue("p_tipo_car_id", DbType.Int32).Value = ca.Tipos_Carreras_Id;

            com.Parameters.AddWithValue("p_nombre", NpgsqlDbType.Varchar, 255).Value = ca.Nombre;
            com.Parameters.AddWithValue("p_codigoint", NpgsqlDbType.Varchar, 20).Value = ca.CodigoInterno.Trim();

            com.Parameters.AddWithValue("p_id_tipo_car", DbType.Int32).Value = ca.IdTipoCarrera;
            com.Parameters.AddWithValue("p_idinsc", DbType.Int32).Value = ca.IdInscripcion;

            com.Parameters.AddWithValue("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ca.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = ca.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_CARRERAS");

        }
        public int Actualizar(Carreras ca)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_CARRERAS(:p_incripcion_id, :p_tipo_car_id, :p_nombre, :p_codigoint," +
                                                    ":p_id_tipo_car, :p_idinsc, :p_fecha ,:p_causa )");
            com.Parameters.AddWithValue("p_incripcion_id", DbType.Int32).Value = ca.IdInscripcion;
            com.Parameters.AddWithValue("p_tipo_car_id", DbType.Int32).Value = ca.Tipos_Carreras_Id;

            com.Parameters.AddWithValue("p_nombre", NpgsqlDbType.Varchar, 255).Value = ca.Nombre;
            com.Parameters.AddWithValue("p_codigoint", NpgsqlDbType.Varchar, 20).Value = ca.CodigoInterno.Trim();

            com.Parameters.AddWithValue("p_id_tipo_car", DbType.Int32).Value = ca.IdTipoCarrera;
            com.Parameters.AddWithValue("p_idinsc", DbType.Int32).Value = ca.IdInscripcion;

            com.Parameters.AddWithValue("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(ca.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = ca.CausaBaja.Trim();
            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_CARRERAS");
        }
    }
}
