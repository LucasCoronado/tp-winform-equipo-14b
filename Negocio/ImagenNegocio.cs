using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {

        public List<Imagen> ListarPorId(int IdArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT Id, IdArticulo, ImagenUrl from IMAGENES WHERE IdArticulo = @IdArticulo;";
                datos.SetearConsulta(consulta);
                datos.SetearParametro("@IdArticulo", IdArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.ImagenUrl= (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void GuardarImagenes(int idArticulo, List<Imagen> listaNueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.SetearParametro("@IdArticulo", idArticulo);
                datos.ejecutarAccion();

                foreach (var img in listaNueva)
                {
                    datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @Url)");
                    datos.SetearParametro("@IdArticulo", idArticulo);
                    datos.SetearParametro("@Url", img.ImagenUrl);

                    datos.ejecutarAccion();
                    
                }
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
