using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo14B
{
    public partial class frmListadoArticulos : Form
    {
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            dgvListado.DataSource = negocio.Listar();
            dgvListado.Columns["IdMarca"].Visible = false;
            dgvListado.Columns["IdCategoria"].Visible = false;
        }

        private List<Imagen> imagenesActuales = new List<Imagen>();
        private int indiceActual = 0;

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            if (dgvListado.CurrentRow == null) return;

            var articulo = (Articulo)dgvListado.CurrentRow.DataBoundItem;

            imagenesActuales = negocio.ListarPorId(articulo.Id);
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
                lblContador.Text = "0 / 0";
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
