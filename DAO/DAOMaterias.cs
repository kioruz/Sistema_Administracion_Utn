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

        public Materias getInscripcionesId(String idMaterias)
        {
            Materias mat = new Materias();
            DataTable tabla = ds.ObtenerTabla("MATERIAS", "select * from \"MATERIAS\" where \"Id\" like " + "'"+idMaterias+"'");
            mat.Id = int.Parse(idMaterias);
            mat.Nombre = tabla.Rows[0][1].ToString();
            mat.FechaBaja = tabla.Rows[0][2].ToString();
            mat.CausaBaja = tabla.Rows[0][3].ToString();

            return mat;
        }

        public DataTable getMateriasAll()
        {
            List<Materias> lista = new List<Materias>();
            DataTable tabla = ds.ObtenerTabla("MATERIAS", "select * from \"MATERIAS\" ");

            return tabla;
        }
        public int Insertar(Materias mat)
        {
            NpgsqlCommand com = new NpgsqlCommand("call insertar_MATERIAS(:p_nombre, :p_fecha, :p_causa )");
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = mat.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(mat.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = mat.CausaBaja.Trim();

            return ds.EjecutarProcedimientoAlmacenado(com, "insertar_MATERIAS");

        }
        public int Actualizar(Materias mat)
        {
            NpgsqlCommand com = new NpgsqlCommand("call actualizar_MATERIAS(:p_id, :p_nombre, :p_fecha, :p_causa )");      
            com.Parameters.AddWithValue("p_id", DbType.Int32).Value = mat.Id;
            com.Parameters.Add("p_nombre", NpgsqlDbType.Varchar, 255).Value = mat.Nombre;
            com.Parameters.Add("p_fecha", NpgsqlDbType.Date).Value = DateTime.Parse(mat.FechaBaja).Date;
            com.Parameters.AddWithValue("p_causa", NpgsqlDbType.Text).Value = mat.CausaBaja.Trim();        
            return ds.EjecutarProcedimientoAlmacenado(com, "actualizar_MATERIAS");
        }
    }
}
