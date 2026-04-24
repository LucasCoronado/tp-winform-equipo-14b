namespace TPWinForm_equipo14B
{
    partial class frmListadoArticulos
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
            dgvListado = new DataGridView();
            pbxImagenes = new PictureBox();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblContador = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagenes).BeginInit();
            SuspendLayout();
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(1, -1);
            dgvListado.Name = "dgvListado";
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.Size = new Size(729, 195);
            dgvListado.TabIndex = 0;
            dgvListado.SelectionChanged += dgvListado_SelectionChanged;
            // 
            // pbxImagenes
            // 
            pbxImagenes.Location = new Point(221, 200);
            pbxImagenes.Name = "pbxImagenes";
            pbxImagenes.Size = new Size(240, 240);
            pbxImagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImagenes.TabIndex = 1;
            pbxImagenes.TabStop = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(502, 313);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(103, 313);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(329, 443);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(0, 15);
            lblContador.TabIndex = 4;
            // 
            // frmListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 488);
            Controls.Add(lblContador);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(pbxImagenes);
            Controls.Add(dgvListado);
            Name = "frmListadoArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListadoArticulos";
            Load += frmListadoArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListado;
        private PictureBox pbxImagenes;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblContador;
    }
}