namespace ProyectoMatematicasDiscretas
{
    partial class GUIPrincipal
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
            this.btmAgregarFinal = new System.Windows.Forms.Button();
            this.btmFinalizarModifcacion = new System.Windows.Forms.Button();
            this.btmAgregarInicio = new System.Windows.Forms.Button();
            this.pnlPanelCargar = new System.Windows.Forms.Panel();
            this.btmModificar = new System.Windows.Forms.Button();
            this.btmBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btmCargarInicio = new System.Windows.Forms.Button();
            this.btmSiguiente = new System.Windows.Forms.Button();
            this.btmAnterior = new System.Windows.Forms.Button();
            this.btmCargarFinal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.RITtextos = new System.Windows.Forms.RichTextBox();
            this.labAgregar = new System.Windows.Forms.Label();
            this.labCargar = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPanelCargar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 9);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(109, 13);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Registrar un producto";
            this.lblSubtitulo.Click += new System.EventHandler(this.lblSubtitulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad(pqt) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio (pqt) :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 83);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(181, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(133, 112);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(181, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // btmAgregarFinal
            // 
            this.btmAgregarFinal.Location = new System.Drawing.Point(383, 69);
            this.btmAgregarFinal.Margin = new System.Windows.Forms.Padding(2);
            this.btmAgregarFinal.Name = "btmAgregarFinal";
            this.btmAgregarFinal.Size = new System.Drawing.Size(209, 27);
            this.btmAgregarFinal.TabIndex = 11;
            this.btmAgregarFinal.Text = "Agregar al final";
            this.btmAgregarFinal.UseVisualStyleBackColor = true;
            this.btmAgregarFinal.Click += new System.EventHandler(this.btmAgregarFinal_Click);
            // 
            // btmFinalizarModifcacion
            // 
            this.btmFinalizarModifcacion.Enabled = false;
            this.btmFinalizarModifcacion.Location = new System.Drawing.Point(383, 101);
            this.btmFinalizarModifcacion.Margin = new System.Windows.Forms.Padding(2);
            this.btmFinalizarModifcacion.Name = "btmFinalizarModifcacion";
            this.btmFinalizarModifcacion.Size = new System.Drawing.Size(209, 27);
            this.btmFinalizarModifcacion.TabIndex = 12;
            this.btmFinalizarModifcacion.Text = "Finalizar modificación";
            this.btmFinalizarModifcacion.UseVisualStyleBackColor = true;
            this.btmFinalizarModifcacion.Click += new System.EventHandler(this.btmAgregarAUnPunto_Click);
            // 
            // btmAgregarInicio
            // 
            this.btmAgregarInicio.Location = new System.Drawing.Point(383, 38);
            this.btmAgregarInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btmAgregarInicio.Name = "btmAgregarInicio";
            this.btmAgregarInicio.Size = new System.Drawing.Size(209, 27);
            this.btmAgregarInicio.TabIndex = 14;
            this.btmAgregarInicio.Text = "Agregar al inicio";
            this.btmAgregarInicio.UseVisualStyleBackColor = true;
            this.btmAgregarInicio.Click += new System.EventHandler(this.btmAgregarInicio_Click);
            // 
            // pnlPanelCargar
            // 
            this.pnlPanelCargar.BackColor = System.Drawing.Color.White;
            this.pnlPanelCargar.Controls.Add(this.btmModificar);
            this.pnlPanelCargar.Controls.Add(this.btmBusqueda);
            this.pnlPanelCargar.Controls.Add(this.labCargar);
            this.pnlPanelCargar.Controls.Add(this.txtBusqueda);
            this.pnlPanelCargar.Controls.Add(this.btmCargarInicio);
            this.pnlPanelCargar.Controls.Add(this.btmSiguiente);
            this.pnlPanelCargar.Controls.Add(this.btmAnterior);
            this.pnlPanelCargar.Controls.Add(this.btmCargarFinal);
            this.pnlPanelCargar.Location = new System.Drawing.Point(10, 258);
            this.pnlPanelCargar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPanelCargar.Name = "pnlPanelCargar";
            this.pnlPanelCargar.Size = new System.Drawing.Size(607, 242);
            this.pnlPanelCargar.TabIndex = 15;
            this.pnlPanelCargar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanelCargar_Paint);
            // 
            // btmModificar
            // 
            this.btmModificar.Location = new System.Drawing.Point(3, 137);
            this.btmModificar.Name = "btmModificar";
            this.btmModificar.Size = new System.Drawing.Size(204, 38);
            this.btmModificar.TabIndex = 7;
            this.btmModificar.Text = "Modificar";
            this.btmModificar.UseVisualStyleBackColor = true;
            this.btmModificar.Click += new System.EventHandler(this.btmModificar_Click);
            // 
            // btmBusqueda
            // 
            this.btmBusqueda.Location = new System.Drawing.Point(176, 206);
            this.btmBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.btmBusqueda.Name = "btmBusqueda";
            this.btmBusqueda.Size = new System.Drawing.Size(31, 22);
            this.btmBusqueda.TabIndex = 6;
            this.btmBusqueda.Text = "♀";
            this.btmBusqueda.UseVisualStyleBackColor = true;
            this.btmBusqueda.Click += new System.EventHandler(this.btmBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(2, 207);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
            this.txtBusqueda.TabIndex = 5;
            // 
            // btmCargarInicio
            // 
            this.btmCargarInicio.Location = new System.Drawing.Point(2, 19);
            this.btmCargarInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btmCargarInicio.Name = "btmCargarInicio";
            this.btmCargarInicio.Size = new System.Drawing.Size(206, 58);
            this.btmCargarInicio.TabIndex = 4;
            this.btmCargarInicio.Text = "Inicio";
            this.btmCargarInicio.UseVisualStyleBackColor = true;
            this.btmCargarInicio.Click += new System.EventHandler(this.btmCargarInicio_Click);
            // 
            // btmSiguiente
            // 
            this.btmSiguiente.Enabled = false;
            this.btmSiguiente.Location = new System.Drawing.Point(103, 180);
            this.btmSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btmSiguiente.Name = "btmSiguiente";
            this.btmSiguiente.Size = new System.Drawing.Size(105, 26);
            this.btmSiguiente.TabIndex = 3;
            this.btmSiguiente.Text = "--->";
            this.btmSiguiente.UseVisualStyleBackColor = true;
            this.btmSiguiente.Click += new System.EventHandler(this.btmSiguiente_Click);
            // 
            // btmAnterior
            // 
            this.btmAnterior.Enabled = false;
            this.btmAnterior.Location = new System.Drawing.Point(2, 180);
            this.btmAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btmAnterior.Name = "btmAnterior";
            this.btmAnterior.Size = new System.Drawing.Size(105, 26);
            this.btmAnterior.TabIndex = 2;
            this.btmAnterior.Text = "<---";
            this.btmAnterior.UseVisualStyleBackColor = true;
            this.btmAnterior.Click += new System.EventHandler(this.btmAnterior_Click);
            // 
            // btmCargarFinal
            // 
            this.btmCargarFinal.Location = new System.Drawing.Point(2, 75);
            this.btmCargarFinal.Margin = new System.Windows.Forms.Padding(2);
            this.btmCargarFinal.Name = "btmCargarFinal";
            this.btmCargarFinal.Size = new System.Drawing.Size(206, 61);
            this.btmCargarFinal.TabIndex = 1;
            this.btmCargarFinal.Text = "Final";
            this.btmCargarFinal.UseVisualStyleBackColor = true;
            this.btmCargarFinal.Click += new System.EventHandler(this.btmCargarFinal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.RITtextos);
            this.panel1.Location = new System.Drawing.Point(221, 273);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 216);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 199);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "---";
            // 
            // RITtextos
            // 
            this.RITtextos.Enabled = false;
            this.RITtextos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RITtextos.Location = new System.Drawing.Point(2, 2);
            this.RITtextos.Margin = new System.Windows.Forms.Padding(2);
            this.RITtextos.Name = "RITtextos";
            this.RITtextos.Size = new System.Drawing.Size(387, 197);
            this.RITtextos.TabIndex = 0;
            this.RITtextos.Text = "";
            this.RITtextos.TextChanged += new System.EventHandler(this.RITtextos_TextChanged);
            // 
            // labAgregar
            // 
            this.labAgregar.AutoSize = true;
            this.labAgregar.Location = new System.Drawing.Point(350, 15);
            this.labAgregar.Name = "labAgregar";
            this.labAgregar.Size = new System.Drawing.Size(105, 13);
            this.labAgregar.TabIndex = 16;
            this.labAgregar.Text = "Guardar información:";
            this.labAgregar.Click += new System.EventHandler(this.label5_Click);
            // 
            // labCargar
            // 
            this.labCargar.AutoSize = true;
            this.labCargar.Location = new System.Drawing.Point(4, 4);
            this.labCargar.Name = "labCargar";
            this.labCargar.Size = new System.Drawing.Size(78, 13);
            this.labCargar.TabIndex = 17;
            this.labCargar.Text = "Cargar registro:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(133, 57);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(181, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.panelTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitulo.Controls.Add(this.label5);
            this.panelTitulo.Location = new System.Drawing.Point(-8, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(642, 102);
            this.panelTitulo.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblSubtitulo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labAgregar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.btmAgregarInicio);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.btmFinalizarModifcacion);
            this.panel2.Controls.Add(this.btmAgregarFinal);
            this.panel2.Location = new System.Drawing.Point(10, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 147);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(163, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 58);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dulceria Miau";
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPanelCargar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUIPrincipal";
            this.Text = "Heladería Miau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPanelCargar.ResumeLayout(false);
            this.pnlPanelCargar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btmAgregarFinal;
        private System.Windows.Forms.Button btmFinalizarModifcacion;
        private System.Windows.Forms.Button btmAgregarInicio;
        private System.Windows.Forms.Panel pnlPanelCargar;
        private System.Windows.Forms.Button btmSiguiente;
        private System.Windows.Forms.Button btmAnterior;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}

