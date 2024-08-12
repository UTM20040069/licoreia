namespace licoreria
{
    partial class frmLicores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicores));
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtTipoDeLicor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pbBusqueda = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbCrud = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(213, 177);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(313, 26);
            this.txtIdProducto.TabIndex = 1;
            // 
            // txtTipoDeLicor
            // 
            this.txtTipoDeLicor.Location = new System.Drawing.Point(213, 226);
            this.txtTipoDeLicor.Name = "txtTipoDeLicor";
            this.txtTipoDeLicor.Size = new System.Drawing.Size(313, 26);
            this.txtTipoDeLicor.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 268);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(213, 313);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(313, 26);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(561, 177);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(217, 209);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Location = new System.Drawing.Point(213, 360);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(313, 26);
            this.txtRutaImagen.TabIndex = 3;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(561, 392);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(217, 34);
            this.btnExaminar.TabIndex = 4;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(623, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 52);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(60, 434);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(718, 336);
            this.dgvDatos.TabIndex = 8;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Controls.Add(this.pnlBusqueda);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.dgvDatos);
            this.pnlBackground.Controls.Add(this.btnExaminar);
            this.pnlBackground.Controls.Add(this.pbImagen);
            this.pnlBackground.Controls.Add(this.lblFolio);
            this.pnlBackground.Controls.Add(this.txtRutaImagen);
            this.pnlBackground.Controls.Add(this.txtPrecio);
            this.pnlBackground.Controls.Add(this.lblCantidad);
            this.pnlBackground.Controls.Add(this.lblPrecio);
            this.pnlBackground.Controls.Add(this.txtNombre);
            this.pnlBackground.Controls.Add(this.txtTipoDeLicor);
            this.pnlBackground.Controls.Add(this.lblNombre);
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Controls.Add(this.txtIdProducto);
            this.pnlBackground.Location = new System.Drawing.Point(-41, -78);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(821, 908);
            this.pnlBackground.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 82);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(229, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventario de Licores";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlBusqueda.Controls.Add(this.btnEliminar);
            this.pnlBusqueda.Controls.Add(this.btnActualizar);
            this.pnlBusqueda.Controls.Add(this.pbBusqueda);
            this.pnlBusqueda.Controls.Add(this.btnAgregar);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Location = new System.Drawing.Point(38, 785);
            this.pnlBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(769, 79);
            this.pnlBusqueda.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(443, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 52);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar  ";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(230, 12);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 52);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Modificar  ";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // pbBusqueda
            // 
            this.pbBusqueda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbBusqueda.Image = global::licoreria.Properties.Resources.busqueda;
            this.pbBusqueda.Location = new System.Drawing.Point(718, 27);
            this.pbBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbBusqueda.Name = "pbBusqueda";
            this.pbBusqueda.Size = new System.Drawing.Size(26, 37);
            this.pbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusqueda.TabIndex = 14;
            this.pbBusqueda.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(22, 12);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 52);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Imagen:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFolio.Location = new System.Drawing.Point(51, 177);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(154, 28);
            this.lblFolio.TabIndex = 10;
            this.lblFolio.Text = "Id Productos:";
            this.lblFolio.Click += new System.EventHandler(this.lblFolio_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(90, 311);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(84, 28);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Precio:";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecio.Location = new System.Drawing.Point(55, 226);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(149, 28);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Tipo de licor:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(82, 268);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 28);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pbCrud);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 79);
            this.panel2.TabIndex = 0;
            // 
            // pbCrud
            // 
            this.pbCrud.Location = new System.Drawing.Point(364, 15);
            this.pbCrud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCrud.Name = "pbCrud";
            this.pbCrud.Size = new System.Drawing.Size(46, 46);
            this.pbCrud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrud.TabIndex = 1;
            this.pbCrud.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(54, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(295, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CRUD de productos";
            // 
            // frmLicores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 786);
            this.Controls.Add(this.pnlBackground);
            this.Name = "frmLicores";
            this.Text = "Licores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtTipoDeLicor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbCrud;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBusqueda;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

