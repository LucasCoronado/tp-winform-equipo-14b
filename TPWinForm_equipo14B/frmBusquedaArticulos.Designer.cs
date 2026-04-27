namespace TPWinForm_equipo14B
{
    partial class frmBusquedaArticulos
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
            lbBusqueda = new Label();
            txbBuscar = new TextBox();
            btnBuscar = new Button();
            dgvBusqueda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            SuspendLayout();
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBusqueda.Location = new Point(313, 27);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(162, 21);
            lbBusqueda.TabIndex = 0;
            lbBusqueda.Text = "Busqueda de artículos";
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(235, 80);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(325, 23);
            txbBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(363, 125);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusqueda.Location = new Point(12, 173);
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.Size = new Size(776, 161);
            dgvBusqueda.TabIndex = 3;
            // 
            // frmBusquedaArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(txbBuscar);
            Controls.Add(lbBusqueda);
            Name = "frmBusquedaArticulos";
            Text = "Busqueda de artículos";
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBusqueda;
        private TextBox txbBuscar;
        private Button btnBuscar;
        private DataGridView dgvBusqueda;
    }
}