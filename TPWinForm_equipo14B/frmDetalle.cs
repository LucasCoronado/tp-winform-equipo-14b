using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo14B
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo;
        private List<Imagen> imagenesActuales = new List<Imagen>();
        private int indiceActual = 0;
        private ImagenNegocio imagenNegocio = new ImagenNegocio();

        public frmDetalle(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articulo = articuloSeleccionado;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Producto: " + articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = "Precio: $" + articulo.Precio.ToString("N2");
            lblMarca.Text = "Marca: " + articulo.Marca.Descripcion;
            lblCategoria.Text = "Categoría: " + articulo.Categoria.Descripcion;

            imagenesActuales = imagenNegocio.ListarPorId(articulo.Id);
            indiceActual = 0;
            CargarImagenEnPBX();
        }

        private void CargarImagenEnPBX()
        {
            if (imagenesActuales.Count == 0)
            {
                pbxImagenes.Image = null;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                lblContador.Text = "Sin imágenes";
                return;
            }

            lblContador.Text = $"{indiceActual + 1} / {imagenesActuales.Count}";
            btnAnterior.Enabled = indiceActual > 0;
            btnSiguiente.Enabled = indiceActual < imagenesActuales.Count - 1;

            try
            {
                pbxImagenes.Load(imagenesActuales[indiceActual].ImagenUrl);
            }
            catch (Exception)
            {
                pbxImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw3k1c6JaNUexk2h38jFUHu4j3O73P8mgVkw&s");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < imagenesActuales.Count - 1)
            {
                indiceActual++;
                CargarImagenEnPBX();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                CargarImagenEnPBX();
            }
        }
    }
}
