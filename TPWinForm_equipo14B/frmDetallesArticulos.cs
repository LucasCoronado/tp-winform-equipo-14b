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
    public partial class frmDetallesArticulos : Form
    {   
        public frmDetallesArticulos()
        {
            InitializeComponent();
        }
            
        private void frmDetallesArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvListado.DataSource = negocio.Listar();

            dgvListado.Columns["IdMarca"].Visible = false;
            dgvListado.Columns["IdCategoria"].Visible = false;
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Articulo seleccionado = (Articulo)dgvListado.CurrentRow.DataBoundItem;
           
                frmDetalle detalle = new frmDetalle(seleccionado);
                detalle.ShowDialog(); 
            }
        }
    }
}