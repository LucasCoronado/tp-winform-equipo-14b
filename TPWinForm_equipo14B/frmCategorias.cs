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
    public partial class frmCategorias : Form
    {
        private CategoriaNegocio negocio = new CategoriaNegocio();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                dgvCategorias.DataSource = negocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCategoria alta = new frmCategoria();
            alta.ShowDialog();

            CargarGrilla(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                frmCategoria modificar = new frmCategoria(seleccionada);
                modificar.ShowDialog();

                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná una categoría de la grilla para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar esta categoría?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                        negocio.Eliminar(seleccionada.Id); 
                        CargarGrilla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná una categoría para eliminar.");
            }
        }

    }
}
