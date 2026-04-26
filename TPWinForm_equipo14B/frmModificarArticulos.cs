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
    public partial class frmModificarArticulos : Form
    {
        public frmModificarArticulos()
        {
            InitializeComponent();
        }

        private void frmModificarArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificable = (Articulo)dgv.CurrentRow.DataBoundItem;
            FrmArticulo articulo = new FrmArticulo(modificable);
            articulo.ShowDialog();

            if (articulo.DialogResult == DialogResult.OK)
            {
                cargar();
            }
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            dgv.DataSource = negocio.Listar();
            dgv.Columns["IdMarca"].Visible = false;
            dgv.Columns["IdCategoria"].Visible = false;
        }
    }
}
