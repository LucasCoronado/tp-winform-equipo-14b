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
    public partial class frmCategoria : Form
    {
        private Categoria categoria = null;
        public frmCategoria()
        {
            InitializeComponent();
        }

        public frmCategoria(Categoria categoriaSeleccionada)
        {
            InitializeComponent();
            this.categoria = categoriaSeleccionada;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtDescripcion.Text = categoria.Descripcion;
                this.Text = "Modificar Categoría"; 
            }
            else
            {
                this.Text = "Nueva Categoría";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                    categoria = new Categoria();

                categoria.Descripcion = txtDescripcion.Text;

                if (categoria.Id != 0)
                {
                    negocio.Modificar(categoria);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    negocio.Agregar(categoria);
                    MessageBox.Show("Agregado exitosamente.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
