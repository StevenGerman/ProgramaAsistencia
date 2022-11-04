using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docentes
{
    class ProfesorDatos
    {

        public List<Profesor> ListarConCatedras()
        {
            List<Profesor> listaProfesorCatedras = new List<Profesor>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select PC.id_catedra, P.nombre NombreProfe,P.apellido, C.nombre Materia from prof_catedras as PC inner join profesores as P inner join catedras as C where PC.id_prof = P.id_prof and PC.id_catedra = C.id_catedra;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Profesor aux = new Profesor();

                    
                    aux.nombre = (string)datos.Lector["NombreProfe"];
                    aux.catedra = new Catedras();
                    aux.catedra.nombre = (string)datos.Lector["Materia"];
                    
                    
                    listaProfesorCatedras.Add(aux);
                }



                return listaProfesorCatedras;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public List<Profesor> Listar()
        {
            List<Profesor> lista = new List<Profesor>();
            MySqlConnection conexion = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector;
            
            


            try
            {
                conexion.ConnectionString = "server=localhost; port=3306;username=root;password=123456789;database=bbdd_profesores";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id_prof,nombre,apellido,dni,email,telefono from profesores;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Profesor aux = new Profesor();
                    
                    aux.nombre = (string)lector["nombre"];
                    aux.apellido = (string)lector["apellido"];
                    aux.email = (string)lector["email"];
                    aux.dni = (string)lector["dni"];
                    aux.id = (int)lector["id_prof"];
                    if (!(lector["telefono"] is DBNull))
                        aux.telefono = (string)lector["telefono"];
                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void agregar(Profesor nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("insert into profesores(nombre,apellido,email) values('"+nuevo.nombre+"','"+nuevo.apellido+"','"+nuevo.email+"');");
                //datos.setearConsulta("insert into profesores(nombre,apellido,dni,email) values('"+ nuevo.nombre+"','"+nuevo.apellido+"','"+nuevo.dni+"','"+nuevo.email+"');");
                datos.setearConsulta("insert into profesores(nombre,apellido,dni,email,telefono) values('" + nuevo.nombre + "','" + nuevo.apellido + "','" + nuevo.dni + "','" + nuevo.email + "','" + nuevo.telefono + "');");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }





        }


        public void Modificar(Profesor seleccionado)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("insert into profesores(nombre,apellido,email) values('"+nuevo.nombre+"','"+nuevo.apellido+"','"+nuevo.email+"');");
                //datos.setearConsulta("insert into profesores(nombre,apellido,dni,email) values('"+ nuevo.nombre+"','"+nuevo.apellido+"','"+nuevo.dni+"','"+nuevo.email+"');");
                datos.setearConsulta("update profesores set nombre = '"+seleccionado.nombre+"', apellido = '"+seleccionado.apellido+"', dni = '"+seleccionado.dni+"', email = '"+seleccionado.email+"', telefono = '"+seleccionado.telefono+ "' where id_prof = "+seleccionado.id+";");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void eliminar(Profesor seleccionado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from profesores where id_prof = "+seleccionado.id+"");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
