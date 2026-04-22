using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
