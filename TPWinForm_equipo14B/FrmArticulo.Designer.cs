namespace TPWinForm_equipo14B
{
    partial class FrmArticulo
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
            txtboxCodArt = new TextBox();
            txtboxPrecio = new TextBox();
            txtboxDescripcion = new TextBox();
            txtboxNombre = new TextBox();
            lbCodArt = new Label();
            lbPrecio = new Label();
            lbMarca = new Label();
            lbDescripcion = new Label();
            lbNombre = new Label();
            cboMarca = new ComboBox();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            lblImagen = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnsalir = new Button();
            btnExaminar = new Button();
            SuspendLayout();
            // 
            // txtboxCodArt
            // 
            txtboxCodArt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtboxCodArt.Location = new Point(424, 80);
            txtboxCodArt.Name = "txtboxCodArt";
            txtboxCodArt.Size = new Size(100, 23);
            txtboxCodArt.TabIndex = 0;
            // 
            // txtboxPrecio
            // 
            txtboxPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtboxPrecio.Location = new Point(424, 254);
            txtboxPrecio.Name = "txtboxPrecio";
            txtboxPrecio.Size = new Size(100, 23);
            txtboxPrecio.TabIndex = 6;
            // 
            // txtboxDescripcion
            // 
            txtboxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtboxDescripcion.Location = new Point(424, 138);
            txtboxDescripcion.Name = "txtboxDescripcion";
            txtboxDescripcion.Size = new Size(100, 23);
            txtboxDescripcion.TabIndex = 2;
            // 
            // txtboxNombre
            // 
            txtboxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtboxNombre.Location = new Point(424, 109);
            txtboxNombre.Name = "txtboxNombre";
            txtboxNombre.Size = new Size(100, 23);
            txtboxNombre.TabIndex = 1;
            // 
            // lbCodArt
            // 
            lbCodArt.AutoSize = true;
            lbCodArt.Location = new Point(258, 83);
            lbCodArt.Name = "lbCodArt";
            lbCodArt.Size = new Size(105, 15);
            lbCodArt.TabIndex = 7;
            lbCodArt.Text = "Código de articulo";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(258, 257);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(40, 15);
            lbPrecio.TabIndex = 10;
            lbPrecio.Text = "Precio";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Location = new Point(258, 170);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(40, 15);
            lbMarca.TabIndex = 11;
            lbMarca.Text = "Marca";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(258, 141);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(69, 15);
            lbDescripcion.TabIndex = 12;
            lbDescripcion.Text = "Descripción";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(258, 112);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 13;
            lbNombre.Text = "Nombre";
            // 
            // cboMarca
            // 
            cboMarca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(423, 167);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(101, 23);
            cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            cboCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(424, 196);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(100, 23);
            cboCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(257, 199);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "Categoria";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(257, 228);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(47, 15);
            lblImagen.TabIndex = 17;
            lblImagen.Text = "Imagen";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(258, 340);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(390, 340);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(524, 340);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 9;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnExaminar
            // 
            btnExaminar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnExaminar.Location = new Point(423, 225);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(101, 23);
            btnExaminar.TabIndex = 5;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // FrmArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExaminar);
            Controls.Add(btnsalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(lblImagen);
            Controls.Add(lblCategoria);
            Controls.Add(cboCategoria);
            Controls.Add(cboMarca);
            Controls.Add(lbNombre);
            Controls.Add(lbDescripcion);
            Controls.Add(lbMarca);
            Controls.Add(lbPrecio);
            Controls.Add(lbCodArt);
            Controls.Add(txtboxNombre);
            Controls.Add(txtboxDescripcion);
            Controls.Add(txtboxPrecio);
            Controls.Add(txtboxCodArt);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmArticulo";
            Text = "FrmArticulo";
            Load += FrmArticulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxCodArt;
        private TextBox txtboxPrecio;
        private TextBox textBox4;
        private TextBox txtboxDescripcion;
        private TextBox txtboxNombre;
        private Label lbCodArt;
        private Label label1;
        private Label label2;
        private Label lbPrecio;
        private Label lbMarca;
        private Label lbDescripcion;
        private Label lbNombre;
        private ComboBox cboMarca;
        private ComboBox cboCategoria;
        private Label lblCategoria;
        private Label lblImagen;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnsalir;
        private Button btnExaminar;
    }
}