using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docentes
{
    class AccesoDatos
    {

        private MySqlConnection conexion;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public MySqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new MySqlConnection("server=localhost; port=3306;username=root;password=123456789;database=bbdd_profesores");
            comando = new MySqlCommand();

        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()

        {
            comando.Connection = conexion;
            try
            {
                
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }

    


}
