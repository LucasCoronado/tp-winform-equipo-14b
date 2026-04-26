using Dominio;

namespace TPWinForm_equipo14B
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            FrmArticulo articulo = new FrmArticulo();
            articulo.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListArticulos_Click(object sender, EventArgs e)
        {
            frmListadoArticulos listadoArticulo = new frmListadoArticulos();
            listadoArticulo.ShowDialog();
        }

        private void btnModifArt_Click(object sender, EventArgs e)
        {
            frmModificarArticulos listadoArticulo = new frmModificarArticulos();
            listadoArticulo.ShowDialog();

        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            frmEliminarArticulos ventana = new frmEliminarArticulos();
            ventana.ShowDialog();
        }

        private void btnDetalleArt_Click(object sender, EventArgs e)
        {
            frmDetallesArticulos detallesArticulos = new frmDetallesArticulos();
            detallesArticulos.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }
    }
}
