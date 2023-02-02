using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Datos
    {
        private SqlConnection cnx;
        public Datos(){
            cnx = new SqlConnection();
            cnx.ConnectionString = "Server=localhost;database=ProyectoDucaFinalSolucion;trusted_connection=true;";
        }
        public int EjecutarConsultaSinResultado(string consulta, SqlParameter[] parametros)
        {
            int filasAfectadas = 0;
            using(var comando = new SqlCommand(consulta, cnx)){
                if(parametros != null && parametros.Length >0)
                    comando.Parameters.AddRange(parametros);
                cnx.Open();
                    filasAfectadas = comando.ExecuteNonQuery();
                cnx.Close();
            }
            return filasAfectadas;
        }
        public DataTable MostrarDatos(string consulta, SqlParameter parametro)
        {
            var dt = new DataTable();
            using(var comando = new SqlCommand(consulta, cnx)){
                if(parametro != null)
                    comando.Parameters.Add(parametro);
                var da = new SqlDataAdapter();
                da.SelectCommand = comando;
                cnx.Open();
                    da.Fill(dt);
                cnx.Close();
            }
            return dt;
        }
    }
}