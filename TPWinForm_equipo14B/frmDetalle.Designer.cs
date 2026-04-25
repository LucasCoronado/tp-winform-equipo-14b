namespace TPWinForm_equipo14B
{
    partial class frmDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbxImagenes = new PictureBox();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblMarca = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            lblContador = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxImagenes).BeginInit();
            SuspendLayout();
            // 
            // pbxImagenes
            // 
            pbxImagenes.Location = new Point(185, 12);
            pbxImagenes.Name = "pbxImagenes";
            pbxImagenes.Size = new Size(416, 217);
            pbxImagenes.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxImagenes.TabIndex = 0;
            pbxImagenes.TabStop = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(621, 111);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(89, 111);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(185, 267);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "label1";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(185, 292);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(38, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "label1";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(185, 316);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(38, 15);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "label1";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(185, 341);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(38, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "label1";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(185, 365);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(38, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "label1";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(379, 232);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(38, 15);
            lblContador.TabIndex = 8;
            lblContador.Text = "label1";
            // 
            // frmDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblContador);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(pbxImagenes);
            Name = "frmDetalle";
            Text = "frmDetalle";
            Load += frmDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxImagenes;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblMarca;
        private Label lblCategoria;
        private Label lblPrecio;
        private Label lblContador;
    }
}