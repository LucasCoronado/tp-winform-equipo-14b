using Dominio;
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
    public partial class frmGestionImagenes : Form
    {

        private List<Imagen> listaGestion;

        public frmGestionImagenes(List<Imagen> listaArticulo)
        {
            InitializeComponent();

            listaGestion = new List<Imagen>(listaArticulo);
        }

        private void frmGestionImagenes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            lbImagenes.DataSource = null;
            lbImagenes.DataSource = listaGestion;
            lbImagenes.DisplayMember = "ImagenUrl";
        }


        public List<Imagen> ListaFinal => listaGestion;


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                listaGestion.Add(new Imagen { ImagenUrl = txtUrl.Text });
                txtUrl.Clear();
                actualizarLista();
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbImagenes.SelectedItem == null)
            {
                return;
            }

            Imagen seleccionada = (Imagen)lbImagenes.SelectedItem;
            try
            {
                pbxImagenes.Load(seleccionada.ImagenUrl);
            }
            catch (Exception)
            {
                pbxImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw3k1c6JaNUexk2h38jFUHu4j3O73P8mgVkw&s");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbImagenes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccioná la imagen que querés borrar.");
                return;
            }

            Imagen seleccionado = (Imagen)lbImagenes.SelectedItem;

            DialogResult respuesta = MessageBox.Show("¿Estás seguro de quitar esta imagen?", "Quitar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                listaGestion.Remove(seleccionado);
                actualizarLista();
                pbxImagenes.Image = null;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
