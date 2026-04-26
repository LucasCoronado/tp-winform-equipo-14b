using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader? lector;

        public SqlDataReader? Lector
        {
            get { return lector; } 
        }

        public AccesoDatos()
        {
            string cadenaConexion = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true; TrustServerCertificate=True;";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        }
        //agrego para setear los parametros
        public void SetearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
            
            //agrego un clear para limpiarle los parametros 
            comando.Parameters.Clear();

        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
