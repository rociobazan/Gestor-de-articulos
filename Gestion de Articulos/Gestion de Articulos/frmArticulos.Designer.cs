﻿namespace Gestion_de_Articulos
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxFiltrar = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.tbxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAñadirMarcasCategorias = new System.Windows.Forms.Button();
            this.lblMarcasCategorias = new System.Windows.Forms.Label();
            this.btnEliminarMarcasCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(33, 76);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(836, 328);
            this.dgvArticulos.TabIndex = 17;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(827, 76);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(391, 328);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(66, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 42);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(201, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 42);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(338, 433);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(466, 433);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(107, 42);
            this.btnVerDetalle.TabIndex = 8;
            this.btnVerDetalle.Text = "Ver detalles";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(28, 23);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(49, 20);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtrar";
            // 
            // tbxFiltrar
            // 
            this.tbxFiltrar.Location = new System.Drawing.Point(83, 20);
            this.tbxFiltrar.Name = "tbxFiltrar";
            this.tbxFiltrar.Size = new System.Drawing.Size(376, 26);
            this.tbxFiltrar.TabIndex = 1;
            this.tbxFiltrar.TextChanged += new System.EventHandler(this.tbxFiltrar_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(17, 518);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 20);
            this.lblCampo.TabIndex = 9;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(342, 515);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(59, 20);
            this.lblCriterio.TabIndex = 11;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(681, 516);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(44, 20);
            this.lblFiltroAvanzado.TabIndex = 13;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // tbxFiltroAvanzado
            // 
            this.tbxFiltroAvanzado.Location = new System.Drawing.Point(731, 515);
            this.tbxFiltroAvanzado.Name = "tbxFiltroAvanzado";
            this.tbxFiltroAvanzado.Size = new System.Drawing.Size(254, 26);
            this.tbxFiltroAvanzado.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1010, 507);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 37);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(83, 513);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(241, 28);
            this.cboCampo.TabIndex = 10;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(419, 513);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(241, 28);
            this.cboCriterio.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1117, 507);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 37);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAñadirMarcasCategorias
            // 
            this.btnAñadirMarcasCategorias.Location = new System.Drawing.Point(1029, 17);
            this.btnAñadirMarcasCategorias.Name = "btnAñadirMarcasCategorias";
            this.btnAñadirMarcasCategorias.Size = new System.Drawing.Size(87, 34);
            this.btnAñadirMarcasCategorias.TabIndex = 3;
            this.btnAñadirMarcasCategorias.Text = "Añadir";
            this.btnAñadirMarcasCategorias.UseVisualStyleBackColor = true;
            this.btnAñadirMarcasCategorias.Click += new System.EventHandler(this.btnMarcasCategorias_Click);
            // 
            // lblMarcasCategorias
            // 
            this.lblMarcasCategorias.AutoSize = true;
            this.lblMarcasCategorias.Location = new System.Drawing.Point(881, 24);
            this.lblMarcasCategorias.Name = "lblMarcasCategorias";
            this.lblMarcasCategorias.Size = new System.Drawing.Size(142, 20);
            this.lblMarcasCategorias.TabIndex = 2;
            this.lblMarcasCategorias.Text = "Marcas/Categorías";
            // 
            // btnEliminarMarcasCategorias
            // 
            this.btnEliminarMarcasCategorias.Location = new System.Drawing.Point(1122, 17);
            this.btnEliminarMarcasCategorias.Name = "btnEliminarMarcasCategorias";
            this.btnEliminarMarcasCategorias.Size = new System.Drawing.Size(87, 34);
            this.btnEliminarMarcasCategorias.TabIndex = 4;
            this.btnEliminarMarcasCategorias.Text = "Eliminar";
            this.btnEliminarMarcasCategorias.UseVisualStyleBackColor = true;
            this.btnEliminarMarcasCategorias.Click += new System.EventHandler(this.btnEliminarMarcasCategorias_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1251, 574);
            this.Controls.Add(this.btnEliminarMarcasCategorias);
            this.Controls.Add(this.lblMarcasCategorias);
            this.Controls.Add(this.btnAñadirMarcasCategorias);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.tbxFiltrar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1273, 630);
            this.MinimumSize = new System.Drawing.Size(1273, 630);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbxFiltrar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox tbxFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAñadirMarcasCategorias;
        private System.Windows.Forms.Label lblMarcasCategorias;
        private System.Windows.Forms.Button btnEliminarMarcasCategorias;
    }
}

