using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = @"
                    SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, 
                           A.IdMarca, M.Descripcion AS MarcaDescripcion, 
                           A.IdCategoria, C.Descripcion AS CategoriaDescripcion
                    FROM ARTICULOS A
                    INNER JOIN MARCAS M ON A.IdMarca = M.Id
                    INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                datos.SetearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = aux.IdMarca;
                    aux.Marca.Descripcion = (string)datos.Lector["MarcaDescripcion"];

                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = aux.IdCategoria;
                    aux.Categoria.Descripcion = (string)datos.Lector["CategoriaDescripcion"];

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

    }
}
