using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docentes
{
    class CatedrasDatos
    {
        public List<Catedras> Listar()
        {
            List<Catedras> listaCatedras = new List<Catedras>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select id_catedra,nombre from catedras;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Catedras aux = new Catedras();

                    aux.id = (int)datos.Lector["id_catedra"];
                    aux.nombre = (string)datos.Lector["nombre"];
                    listaCatedras.Add(aux);
                }

                

                return listaCatedras;


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
