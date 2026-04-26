namespace TPWinForm_equipo14B
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbGestionArt = new Label();
            btnListArticulos = new Button();
            btnBusqArt = new Button();
            btnAgregarArt = new Button();
            btnModifArt = new Button();
            btnEliminarArt = new Button();
            btnDetalleArt = new Button();
            lbDetaArt = new Label();
            lbModArti = new Label();
            lbBusqArt = new Label();
            lbAgregarArt = new Label();
            lbElimArt = new Label();
            lbListArt = new Label();
            btnCerrar = new Button();
            lbCategorias = new Label();
            lbMarcas = new Label();
            btnMarcas = new Button();
            btnCategorias = new Button();
            SuspendLayout();
            // 
            // lbGestionArt
            // 
            lbGestionArt.AutoSize = true;
            lbGestionArt.BackColor = SystemColors.GrayText;
            lbGestionArt.BorderStyle = BorderStyle.FixedSingle;
            lbGestionArt.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGestionArt.ForeColor = SystemColors.ButtonHighlight;
            lbGestionArt.Location = new Point(290, 20);
            lbGestionArt.Name = "lbGestionArt";
            lbGestionArt.Size = new Size(248, 31);
            lbGestionArt.TabIndex = 0;
            lbGestionArt.Text = "Gestión de artículos";
            // 
            // btnListArticulos
            // 
            btnListArticulos.BackgroundImage = Properties.Resources.lista_de_articulos;
            btnListArticulos.BackgroundImageLayout = ImageLayout.Zoom;
            btnListArticulos.Location = new Point(113, 104);
            btnListArticulos.Name = "btnListArticulos";
            btnListArticulos.Size = new Size(130, 90);
            btnListArticulos.TabIndex = 1;
            btnListArticulos.UseVisualStyleBackColor = true;
            btnListArticulos.Click += btnListArticulos_Click;
            // 
            // btnBusqArt
            // 
            btnBusqArt.BackgroundImage = Properties.Resources.busqueda_articulos;
            btnBusqArt.BackgroundImageLayout = ImageLayout.Zoom;
            btnBusqArt.Location = new Point(426, 104);
            btnBusqArt.Name = "btnBusqArt";
            btnBusqArt.Size = new Size(130, 90);
            btnBusqArt.TabIndex = 2;
            btnBusqArt.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArt
            // 
            btnAgregarArt.BackgroundImage = Properties.Resources.agregar_producto;
            btnAgregarArt.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregarArt.Location = new Point(113, 252);
            btnAgregarArt.Name = "btnAgregarArt";
            btnAgregarArt.Size = new Size(130, 90);
            btnAgregarArt.TabIndex = 3;
            btnAgregarArt.UseVisualStyleBackColor = true;
            btnAgregarArt.Click += btnAgregarArt_Click;
            // 
            // btnModifArt
            // 
            btnModifArt.BackgroundImage = Properties.Resources.modificar_articulos;
            btnModifArt.BackgroundImageLayout = ImageLayout.Zoom;
            btnModifArt.Location = new Point(268, 104);
            btnModifArt.Name = "btnModifArt";
            btnModifArt.Size = new Size(130, 90);
            btnModifArt.TabIndex = 4;
            btnModifArt.UseVisualStyleBackColor = true;
            btnModifArt.Click += btnModifArt_Click;
            // 
            // btnEliminarArt
            // 
            btnEliminarArt.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarArt.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarArt.Location = new Point(268, 252);
            btnEliminarArt.Name = "btnEliminarArt";
            btnEliminarArt.Size = new Size(130, 90);
            btnEliminarArt.TabIndex = 5;
            btnEliminarArt.UseVisualStyleBackColor = true;
            btnEliminarArt.Click += btnEliminarArt_Click;
            // 
            // btnDetalleArt
            // 
            btnDetalleArt.BackgroundImage = Properties.Resources.detalle_articulos;
            btnDetalleArt.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetalleArt.Location = new Point(426, 252);
            btnDetalleArt.Name = "btnDetalleArt";
            btnDetalleArt.Size = new Size(130, 90);
            btnDetalleArt.TabIndex = 6;
            btnDetalleArt.UseVisualStyleBackColor = true;
            btnDetalleArt.Click += btnDetalleArt_Click;
            // 
            // lbDetaArt
            // 
            lbDetaArt.BackColor = SystemColors.GrayText;
            lbDetaArt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDetaArt.ForeColor = SystemColors.ButtonHighlight;
            lbDetaArt.Location = new Point(426, 234);
            lbDetaArt.Name = "lbDetaArt";
            lbDetaArt.Size = new Size(130, 20);
            lbDetaArt.TabIndex = 7;
            lbDetaArt.Text = "Detalle de artículos";
            lbDetaArt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbModArti
            // 
            lbModArti.BackColor = SystemColors.GrayText;
            lbModArti.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbModArti.ForeColor = SystemColors.ButtonHighlight;
            lbModArti.Location = new Point(268, 85);
            lbModArti.Name = "lbModArti";
            lbModArti.Size = new Size(130, 20);
            lbModArti.TabIndex = 8;
            lbModArti.Text = "Modificar artículo";
            lbModArti.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbBusqArt
            // 
            lbBusqArt.BackColor = SystemColors.GrayText;
            lbBusqArt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBusqArt.ForeColor = SystemColors.ButtonHighlight;
            lbBusqArt.Location = new Point(426, 85);
            lbBusqArt.Name = "lbBusqArt";
            lbBusqArt.Size = new Size(130, 20);
            lbBusqArt.TabIndex = 9;
            lbBusqArt.Text = "Busqueda de artículo";
            lbBusqArt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbAgregarArt
            // 
            lbAgregarArt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbAgregarArt.BackColor = SystemColors.GrayText;
            lbAgregarArt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarArt.ForeColor = SystemColors.ButtonHighlight;
            lbAgregarArt.Location = new Point(113, 233);
            lbAgregarArt.Name = "lbAgregarArt";
            lbAgregarArt.Size = new Size(130, 20);
            lbAgregarArt.TabIndex = 10;
            lbAgregarArt.Text = "Agregar artículo";
            lbAgregarArt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbElimArt
            // 
            lbElimArt.BackColor = SystemColors.GrayText;
            lbElimArt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbElimArt.ForeColor = SystemColors.ButtonHighlight;
            lbElimArt.Location = new Point(268, 233);
            lbElimArt.Name = "lbElimArt";
            lbElimArt.Size = new Size(130, 20);
            lbElimArt.TabIndex = 11;
            lbElimArt.Text = "Eliminar artículo";
            lbElimArt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbListArt
            // 
            lbListArt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbListArt.BackColor = SystemColors.GrayText;
            lbListArt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbListArt.ForeColor = SystemColors.ButtonHighlight;
            lbListArt.Location = new Point(113, 85);
            lbListArt.Name = "lbListArt";
            lbListArt.Size = new Size(130, 20);
            lbListArt.TabIndex = 12;
            lbListArt.Text = "Listado de Artículos";
            lbListArt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(703, 404);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 34);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lbCategorias
            // 
            lbCategorias.BackColor = SystemColors.GrayText;
            lbCategorias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategorias.ForeColor = SystemColors.ButtonHighlight;
            lbCategorias.Location = new Point(585, 85);
            lbCategorias.Name = "lbCategorias";
            lbCategorias.Size = new Size(130, 20);
            lbCategorias.TabIndex = 17;
            lbCategorias.Text = "Categorias";
            lbCategorias.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMarcas
            // 
            lbMarcas.BackColor = SystemColors.GrayText;
            lbMarcas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMarcas.ForeColor = SystemColors.ButtonHighlight;
            lbMarcas.Location = new Point(585, 234);
            lbMarcas.Name = "lbMarcas";
            lbMarcas.Size = new Size(130, 20);
            lbMarcas.TabIndex = 16;
            lbMarcas.Text = "Marcas";
            lbMarcas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMarcas
            // 
            btnMarcas.BackgroundImage = Properties.Resources.detalle_articulos;
            btnMarcas.BackgroundImageLayout = ImageLayout.Zoom;
            btnMarcas.Location = new Point(585, 252);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(130, 90);
            btnMarcas.TabIndex = 15;
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackgroundImage = Properties.Resources.busqueda_articulos;
            btnCategorias.BackgroundImageLayout = ImageLayout.Zoom;
            btnCategorias.Location = new Point(585, 104);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(130, 90);
            btnCategorias.TabIndex = 14;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCategorias);
            Controls.Add(lbMarcas);
            Controls.Add(btnMarcas);
            Controls.Add(btnCategorias);
            Controls.Add(btnCerrar);
            Controls.Add(lbListArt);
            Controls.Add(lbElimArt);
            Controls.Add(lbAgregarArt);
            Controls.Add(lbBusqArt);
            Controls.Add(lbModArti);
            Controls.Add(lbDetaArt);
            Controls.Add(btnDetalleArt);
            Controls.Add(btnEliminarArt);
            Controls.Add(btnModifArt);
            Controls.Add(btnAgregarArt);
            Controls.Add(btnBusqArt);
            Controls.Add(btnListArticulos);
            Controls.Add(lbGestionArt);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmMenu";
            Text = "Gestión de Artículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGestionArt;
        private Button btnListArticulos;
        private Button btnBusqArt;
        private Button btnAgregarArt;
        private Button btnModifArt;
        private Button btnEliminarArt;
        private Button btnDetalleArt;
        private Label lbDetaArt;
        private Label lbModArti;
        private Label lbBusqArt;
        private Label lbAgregarArt;
        private Label lbElimArt;
        private Label lbListArt;
        private Button btnCerrar;
        private Label lbCategorias;
        private Label lbMarcas;
        private Button btnMarcas;
        private Button btnCategorias;
    }
}
