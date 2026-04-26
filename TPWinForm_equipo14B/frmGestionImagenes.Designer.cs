namespace TPWinForm_equipo14B
{
    partial class frmGestionImagenes
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
            lbImagenes = new ListBox();
            txtUrl = new TextBox();
            btnAgregar = new Button();
            btnBorrar = new Button();
            pbxImagenes = new PictureBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxImagenes).BeginInit();
            SuspendLayout();
            // 
            // lbImagenes
            // 
            lbImagenes.FormattingEnabled = true;
            lbImagenes.ItemHeight = 15;
            lbImagenes.Location = new Point(32, 96);
            lbImagenes.Name = "lbImagenes";
            lbImagenes.Size = new Size(233, 124);
            lbImagenes.TabIndex = 0;
            lbImagenes.SelectedIndexChanged += lbImagenes_SelectedIndexChanged;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(32, 44);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(122, 23);
            txtUrl.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(175, 44);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(32, 235);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(233, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pbxImagenes
            // 
            pbxImagenes.Location = new Point(325, 44);
            pbxImagenes.Name = "pbxImagenes";
            pbxImagenes.Size = new Size(214, 214);
            pbxImagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImagenes.TabIndex = 6;
            pbxImagenes.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(82, 293);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(316, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmGestionImagenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 328);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(pbxImagenes);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtUrl);
            Controls.Add(lbImagenes);
            Name = "frmGestionImagenes";
            Text = "frmGestionImagenes";
            Load += frmGestionImagenes_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbImagenes;
        private TextBox txtUrl;
        private Button btnAgregar;
        private Button btnBorrar;
        private PictureBox pbxImagenes;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}