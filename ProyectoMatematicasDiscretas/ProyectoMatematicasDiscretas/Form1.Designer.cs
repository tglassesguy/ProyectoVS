﻿namespace ProyectoMatematicasDiscretas
{
    partial class GUIArchivoDulce
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.btmFinalizarModifcacion = new System.Windows.Forms.Button();
            this.pnlCargar = new System.Windows.Forms.Panel();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.btmModificar = new System.Windows.Forms.Button();
            this.btmBusqueda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.RITtextos = new System.Windows.Forms.RichTextBox();
            this.labCargar = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btmCargarInicio = new System.Windows.Forms.Button();
            this.btmCargarFinal = new System.Windows.Forms.Button();
            this.btmVolcar = new System.Windows.Forms.Button();
            this.labAgregar = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.labArchivo = new System.Windows.Forms.Label();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btmRuta = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btmVolcarDesorden = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemArchivos = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemListas = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pnlCargar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(35, 11);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(172, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Registrar un producto:";
            this.lblSubtitulo.Click += new System.EventHandler(this.lblSubtitulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad(pqt):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio (pqt):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(209, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(209, 102);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(240, 22);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(209, 138);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(240, 22);
            this.txtPrecio.TabIndex = 9;
            // 
            // btmAgregar
            // 
            this.btmAgregar.BackColor = System.Drawing.Color.White;
            this.btmAgregar.Location = new System.Drawing.Point(543, 55);
            this.btmAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(279, 48);
            this.btmAgregar.TabIndex = 11;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = false;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregarFinal_Click);
            // 
            // btmFinalizarModifcacion
            // 
            this.btmFinalizarModifcacion.BackColor = System.Drawing.Color.White;
            this.btmFinalizarModifcacion.Enabled = false;
            this.btmFinalizarModifcacion.Location = new System.Drawing.Point(543, 106);
            this.btmFinalizarModifcacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmFinalizarModifcacion.Name = "btmFinalizarModifcacion";
            this.btmFinalizarModifcacion.Size = new System.Drawing.Size(279, 48);
            this.btmFinalizarModifcacion.TabIndex = 12;
            this.btmFinalizarModifcacion.Text = "Finalizar modificación";
            this.btmFinalizarModifcacion.UseVisualStyleBackColor = false;
            this.btmFinalizarModifcacion.Click += new System.EventHandler(this.btmAgregarAUnPunto_Click);
            // 
            // pnlCargar
            // 
            this.pnlCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.pnlCargar.Controls.Add(this.btmEliminar);
            this.pnlCargar.Controls.Add(this.btmModificar);
            this.pnlCargar.Controls.Add(this.btmBusqueda);
            this.pnlCargar.Controls.Add(this.panel1);
            this.pnlCargar.Controls.Add(this.labCargar);
            this.pnlCargar.Controls.Add(this.txtBusqueda);
            this.pnlCargar.Controls.Add(this.btmCargarInicio);
            this.pnlCargar.Controls.Add(this.btmCargarFinal);
            this.pnlCargar.Enabled = false;
            this.pnlCargar.Location = new System.Drawing.Point(-11, 433);
            this.pnlCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCargar.Name = "pnlCargar";
            this.pnlCargar.Size = new System.Drawing.Size(856, 348);
            this.pnlCargar.TabIndex = 15;
            this.pnlCargar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanelCargar_Paint);
            // 
            // btmEliminar
            // 
            this.btmEliminar.BackColor = System.Drawing.Color.White;
            this.btmEliminar.Location = new System.Drawing.Point(31, 222);
            this.btmEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(272, 47);
            this.btmEliminar.TabIndex = 18;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = false;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // btmModificar
            // 
            this.btmModificar.BackColor = System.Drawing.Color.White;
            this.btmModificar.Location = new System.Drawing.Point(31, 180);
            this.btmModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmModificar.Name = "btmModificar";
            this.btmModificar.Size = new System.Drawing.Size(272, 47);
            this.btmModificar.TabIndex = 7;
            this.btmModificar.Text = "Modificar";
            this.btmModificar.UseVisualStyleBackColor = false;
            this.btmModificar.Click += new System.EventHandler(this.btmModificar_Click);
            // 
            // btmBusqueda
            // 
            this.btmBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBusqueda.Location = new System.Drawing.Point(253, 288);
            this.btmBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmBusqueda.Name = "btmBusqueda";
            this.btmBusqueda.Size = new System.Drawing.Size(52, 47);
            this.btmBusqueda.TabIndex = 6;
            this.btmBusqueda.Text = "♀";
            this.btmBusqueda.UseVisualStyleBackColor = true;
            this.btmBusqueda.Click += new System.EventHandler(this.btmBusqueda_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.RITtextos);
            this.panel1.Location = new System.Drawing.Point(309, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 322);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "---";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // RITtextos
            // 
            this.RITtextos.Enabled = false;
            this.RITtextos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RITtextos.Location = new System.Drawing.Point(1, 2);
            this.RITtextos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RITtextos.Name = "RITtextos";
            this.RITtextos.Size = new System.Drawing.Size(515, 294);
            this.RITtextos.TabIndex = 0;
            this.RITtextos.Text = "";
            this.RITtextos.TextChanged += new System.EventHandler(this.RITtextos_TextChanged);
            // 
            // labCargar
            // 
            this.labCargar.AutoSize = true;
            this.labCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCargar.Location = new System.Drawing.Point(32, 7);
            this.labCargar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCargar.Name = "labCargar";
            this.labCargar.Size = new System.Drawing.Size(123, 17);
            this.labCargar.TabIndex = 17;
            this.labCargar.Text = "Cargar registro:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(33, 289);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(269, 45);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btmCargarInicio
            // 
            this.btmCargarInicio.BackColor = System.Drawing.Color.White;
            this.btmCargarInicio.Location = new System.Drawing.Point(29, 26);
            this.btmCargarInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmCargarInicio.Name = "btmCargarInicio";
            this.btmCargarInicio.Size = new System.Drawing.Size(275, 71);
            this.btmCargarInicio.TabIndex = 4;
            this.btmCargarInicio.Text = "Inicio";
            this.btmCargarInicio.UseVisualStyleBackColor = false;
            this.btmCargarInicio.Click += new System.EventHandler(this.btmCargarInicio_Click);
            // 
            // btmCargarFinal
            // 
            this.btmCargarFinal.BackColor = System.Drawing.Color.White;
            this.btmCargarFinal.Location = new System.Drawing.Point(29, 95);
            this.btmCargarFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmCargarFinal.Name = "btmCargarFinal";
            this.btmCargarFinal.Size = new System.Drawing.Size(275, 75);
            this.btmCargarFinal.TabIndex = 1;
            this.btmCargarFinal.Text = "Final";
            this.btmCargarFinal.UseVisualStyleBackColor = false;
            this.btmCargarFinal.Click += new System.EventHandler(this.btmCargarFinal_Click);
            // 
            // btmVolcar
            // 
            this.btmVolcar.Enabled = false;
            this.btmVolcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVolcar.Location = new System.Drawing.Point(468, 780);
            this.btmVolcar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmVolcar.Name = "btmVolcar";
            this.btmVolcar.Size = new System.Drawing.Size(76, 38);
            this.btmVolcar.TabIndex = 19;
            this.btmVolcar.Text = "«";
            this.btmVolcar.UseVisualStyleBackColor = true;
            this.btmVolcar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labAgregar
            // 
            this.labAgregar.AutoSize = true;
            this.labAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAgregar.Location = new System.Drawing.Point(501, 11);
            this.labAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAgregar.Name = "labAgregar";
            this.labAgregar.Size = new System.Drawing.Size(162, 17);
            this.labAgregar.TabIndex = 16;
            this.labAgregar.Text = "Guardar información:";
            this.labAgregar.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(209, 70);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 22);
            this.dtpFecha.TabIndex = 18;
            this.dtpFecha.Value = new System.DateTime(2018, 2, 26, 0, 0, 0, 0);
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(237)))));
            this.pnlRegistro.Controls.Add(this.lblSubtitulo);
            this.pnlRegistro.Controls.Add(this.label1);
            this.pnlRegistro.Controls.Add(this.dtpFecha);
            this.pnlRegistro.Controls.Add(this.label2);
            this.pnlRegistro.Controls.Add(this.label3);
            this.pnlRegistro.Controls.Add(this.labAgregar);
            this.pnlRegistro.Controls.Add(this.label4);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.txtCantidad);
            this.pnlRegistro.Controls.Add(this.txtPrecio);
            this.pnlRegistro.Controls.Add(this.btmFinalizarModifcacion);
            this.pnlRegistro.Controls.Add(this.btmAgregar);
            this.pnlRegistro.Enabled = false;
            this.pnlRegistro.Location = new System.Drawing.Point(-11, 236);
            this.pnlRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(856, 181);
            this.pnlRegistro.TabIndex = 20;
            this.pnlRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labArchivo
            // 
            this.labArchivo.AutoSize = true;
            this.labArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labArchivo.Location = new System.Drawing.Point(21, 168);
            this.labArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labArchivo.Name = "labArchivo";
            this.labArchivo.Size = new System.Drawing.Size(67, 17);
            this.labArchivo.TabIndex = 21;
            this.labArchivo.Text = "Archivo:";
            this.labArchivo.Click += new System.EventHandler(this.labArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(24, 191);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(791, 22);
            this.txtRutaArchivo.TabIndex = 22;
            this.txtRutaArchivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btmRuta
            // 
            this.btmRuta.Location = new System.Drawing.Point(741, 190);
            this.btmRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmRuta.Name = "btmRuta";
            this.btmRuta.Size = new System.Drawing.Size(75, 26);
            this.btmRuta.TabIndex = 23;
            this.btmRuta.Text = "•••";
            this.btmRuta.UseVisualStyleBackColor = true;
            this.btmRuta.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 792);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Volcar datos ordenados:";
            this.label5.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 792);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Volcar datos desordenados:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btmVolcarDesorden
            // 
            this.btmVolcarDesorden.Enabled = false;
            this.btmVolcarDesorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVolcarDesorden.Location = new System.Drawing.Point(741, 780);
            this.btmVolcarDesorden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmVolcarDesorden.Name = "btmVolcarDesorden";
            this.btmVolcarDesorden.Size = new System.Drawing.Size(76, 38);
            this.btmVolcarDesorden.TabIndex = 26;
            this.btmVolcarDesorden.Text = "«!";
            this.btmVolcarDesorden.UseVisualStyleBackColor = true;
            this.btmVolcarDesorden.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMenu
            // 
            this.menuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemArchivos,
            this.ItemListas});
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(58, 24);
            this.menuMenu.Text = "Menu";
            // 
            // ItemArchivos
            // 
            this.ItemArchivos.Name = "ItemArchivos";
            this.ItemArchivos.Size = new System.Drawing.Size(192, 26);
            this.ItemArchivos.Text = "Opcion Archivos";
            this.ItemArchivos.Click += new System.EventHandler(this.ItemArchivos_Click);
            // 
            // ItemListas
            // 
            this.ItemListas.Name = "ItemListas";
            this.ItemListas.Size = new System.Drawing.Size(192, 26);
            this.ItemListas.Text = "Opcion Listas";
            this.ItemListas.Click += new System.EventHandler(this.ItemListas_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.panelTitulo.BackgroundImage = global::ProyectoMatematicasDiscretas.Properties.Resources.dulceria;
            this.panelTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitulo.Location = new System.Drawing.Point(-11, 36);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(856, 126);
            this.panelTitulo.TabIndex = 19;
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitulo_Paint);
            // 
            // GUIArchivoDulce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(833, 821);
            this.Controls.Add(this.btmVolcarDesorden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btmVolcar);
            this.Controls.Add(this.btmRuta);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.labArchivo);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.pnlCargar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUIArchivoDulce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dulcería Miau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCargar.ResumeLayout(false);
            this.pnlCargar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmFinalizarModifcacion;
        private System.Windows.Forms.Panel pnlCargar;
        private System.Windows.Forms.Button btmCargarFinal;
        private System.Windows.Forms.Button btmCargarInicio;
        private System.Windows.Forms.Button btmBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RichTextBox RITtextos;
        private System.Windows.Forms.Label labAgregar;
        private System.Windows.Forms.Label labCargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btmModificar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label labArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btmRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button btmVolcar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmVolcarDesorden;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripMenuItem ItemArchivos;
        private System.Windows.Forms.ToolStripMenuItem ItemListas;
    }
}

