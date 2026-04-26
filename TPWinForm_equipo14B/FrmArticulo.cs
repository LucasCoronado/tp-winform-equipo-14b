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
    public partial class FrmArticulo : Form
    {
        private Articulo articulo = null;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        public FrmArticulo(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            if (articulo != null)
            {
                txtboxCodArt.Text = articulo.Codigo;
                txtboxNombre.Text = articulo.Nombre;
                txtboxDescripcion.Text = articulo.Descripcion;

                cboMarca.SelectedValue = articulo.IdMarca;
                cboCategoria.SelectedValue = articulo.IdCategoria;

                txtboxPrecio.Text = articulo.Precio.ToString();
            }

            cboMarca.DataSource = marcaNegocio.Listar();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            cboCategoria.DataSource = categoriaNegocio.Listar();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtboxCodArt.Clear();
            txtboxDescripcion.Clear();
            txtboxNombre.Clear();
            txtboxPrecio.Clear();
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imgNegocio = new ImagenNegocio();
            
            Articulo nuevo = new Articulo();
            try
            {
            if (!validarCampos())
            {
                MessageBox.Show("Por favor, complete los campos marcados en rojo.");
                return;
            }

            nuevo.Codigo = txtboxCodArt.Text;
            nuevo.Nombre = txtboxNombre.Text;
            nuevo.Descripcion = txtboxDescripcion.Text;
            nuevo.Precio = decimal.Parse(txtboxPrecio.Text);

            nuevo.IdMarca = ((Marca)cboMarca.SelectedItem).Id;
            nuevo.IdCategoria = ((Categoria)cboCategoria.SelectedItem).Id;

            nuevo.Imagenes = articulo?.Imagenes ?? new List<Imagen>();

            if (articulo == null)
            {
                int idGenerado = negocio.Agregar(nuevo);
                imgNegocio.GuardarImagenes(idGenerado, nuevo.Imagenes);
                MessageBox.Show("Agregado correctamente");

            }
            else
            {
                nuevo.Id = articulo.Id;

                negocio.Modificar(articulo, nuevo);
                imgNegocio.GuardarImagenes(nuevo.Id, nuevo.Imagenes);
                MessageBox.Show("Modificado correctamente");
            }
            this.DialogResult = DialogResult.OK;
            Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtboxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtboxPrecio.Text.Contains(",") || txtboxPrecio.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtboxPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(txtboxPrecio.Text, out _) && !string.IsNullOrEmpty(txtboxPrecio.Text))
            {
                MessageBox.Show("Debe ingresar un número decimal válido.");
                txtboxPrecio.Text = "";
            }
            else
            {
                txtboxPrecio.Text = "";
            }
        }

        private bool validarCampos()
        {
            bool todoOk = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        control.BackColor = Color.LightSalmon;
                        todoOk = false;
                    }
                    else
                    {
                        control.BackColor = SystemColors.Window;
                    }
                }
                if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex < 0)
                    {
                        control.BackColor = Color.LightSalmon;
                        todoOk = false;
                    }
                    else
                    {
                        control.BackColor = SystemColors.Window;
                    }
                }
            }

            return todoOk;
        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {

            ImagenNegocio imgNegocio = new ImagenNegocio();

            if (articulo == null) 
            {
                articulo = new Articulo();
                articulo.Imagenes = new List<Imagen>();
            }
            else
            {
                articulo.Imagenes = imgNegocio.ListarPorId(articulo.Id);
            }

            frmGestionImagenes ventana = new frmGestionImagenes(articulo.Imagenes);
            ventana.ShowDialog();

            if (ventana.DialogResult == DialogResult.OK)
            {
                articulo.Imagenes = ventana.ListaFinal;
            }
        }
    }
}
