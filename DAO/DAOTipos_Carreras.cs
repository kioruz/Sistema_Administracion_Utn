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

        public Tipos_Carreras getTipoCarrerasId(String idTipo_Carreras)
        {
        Tipos_Carreras tc = new Tipos_Carreras();
        DataTable tabla = ds.ObtenerTabla("TIPOS_CARRERAS", "select * from \"TIPOS_CARRERAS\" where \"Id\" like " + "'" + idTipo_Carreras + "'");
        tc.Id = idTipo_Carreras;
        tc.Nombre = tabla.Rows[0][1].ToString();
        tc.FechaBaja = tabla.Rows[0][2].ToString();
        tc.CausaBaja = tabla.Rows[0][3].ToString();

        return tc;
        }

        public DataTable getTipoCarrerasAll()
        {
        List<Modalidades> lista = new List<Modalidades>();
        DataTable tabla = ds.ObtenerTabla("TIPOS_CARRERAS", "select * from \"TIPOS_CARRERAS\" ");

        return tabla;
        }
        public int Insertar(Tipos_Carreras tc)
        {
        NpgsqlCommand com = new NpgsqlCommand("call insertar_TIPOS_CARRERAS(:p_nombre, :p_fecha, :p_causa )");
        com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tc.Nombre;
        com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(tc.FechaBaja).Date;
        com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = tc.CausaBaja.Trim();
        return ds.EjecutarProcedimientoAlmacenado(com, "insertar_TIPOS_CARRERAs");

        }

        public int Actualizar(Tipos_Carreras tc)
        {
        NpgsqlCommand com = new NpgsqlCommand("call actualizar_TIPOS_CARRERAS(:p_id :p_nombre, :p_fecha, :p_causa )");
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = tc.Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = tc.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(tc.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = tc.CausaBaja.Trim();
           
        return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_TIPOS_CARRERAS");
        }

    }
}

