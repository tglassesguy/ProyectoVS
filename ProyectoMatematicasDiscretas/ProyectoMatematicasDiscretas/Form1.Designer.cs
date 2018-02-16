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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btmAgregarFinal = new System.Windows.Forms.Button();
            this.btmAgregarAUnPunto = new System.Windows.Forms.Button();
            this.txtPosicionAgregar = new System.Windows.Forms.TextBox();
            this.btmAgregarInicio = new System.Windows.Forms.Button();
            this.pnlPanelCargar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.RITtextos = new System.Windows.Forms.RichTextBox();
            this.btmBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btmCargarInicio = new System.Windows.Forms.Button();
            this.btmSiguiente = new System.Windows.Forms.Button();
            this.btmAnterior = new System.Windows.Forms.Button();
            this.btmCargarFinal = new System.Windows.Forms.Button();
            this.labAgregar = new System.Windows.Forms.Label();
            this.labCargar = new System.Windows.Forms.Label();
            this.pnlPanelCargar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(125, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DULCERIA MIAU";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(11, 67);
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
            this.label1.Location = new System.Drawing.Point(41, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad(pqt) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio (pqt) :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 116);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 141);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 170);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 20);
            this.textBox4.TabIndex = 9;
            // 
            // btmAgregarFinal
            // 
            this.btmAgregarFinal.Location = new System.Drawing.Point(318, 121);
            this.btmAgregarFinal.Margin = new System.Windows.Forms.Padding(2);
            this.btmAgregarFinal.Name = "btmAgregarFinal";
            this.btmAgregarFinal.Size = new System.Drawing.Size(209, 27);
            this.btmAgregarFinal.TabIndex = 11;
            this.btmAgregarFinal.Text = "Agregar al final";
            this.btmAgregarFinal.UseVisualStyleBackColor = true;
            this.btmAgregarFinal.Click += new System.EventHandler(this.btmAgregarFinal_Click);
            // 
            // btmAgregarAUnPunto
            // 
            this.btmAgregarAUnPunto.Location = new System.Drawing.Point(318, 153);
            this.btmAgregarAUnPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btmAgregarAUnPunto.Name = "btmAgregarAUnPunto";
            this.btmAgregarAUnPunto.Size = new System.Drawing.Size(126, 27);
            this.btmAgregarAUnPunto.TabIndex = 12;
            this.btmAgregarAUnPunto.Text = "Agregar a un punto";
            this.btmAgregarAUnPunto.UseVisualStyleBackColor = true;
            this.btmAgregarAUnPunto.Click += new System.EventHandler(this.btmAgregarAUnPunto_Click);
            // 
            // txtPosicionAgregar
            // 
            this.txtPosicionAgregar.Location = new System.Drawing.Point(448, 157);
            this.txtPosicionAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosicionAgregar.Name = "txtPosicionAgregar";
            this.txtPosicionAgregar.Size = new System.Drawing.Size(79, 20);
            this.txtPosicionAgregar.TabIndex = 13;
            this.txtPosicionAgregar.TextChanged += new System.EventHandler(this.txtPosicionAgregar_TextChanged);
            // 
            // btmAgregarInicio
            // 
            this.btmAgregarInicio.Location = new System.Drawing.Point(318, 90);
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
            this.pnlPanelCargar.BackColor = System.Drawing.Color.LightGray;
            this.pnlPanelCargar.Controls.Add(this.btmBusqueda);
            this.pnlPanelCargar.Controls.Add(this.txtBusqueda);
            this.pnlPanelCargar.Controls.Add(this.btmCargarInicio);
            this.pnlPanelCargar.Controls.Add(this.btmSiguiente);
            this.pnlPanelCargar.Controls.Add(this.btmAnterior);
            this.pnlPanelCargar.Controls.Add(this.btmCargarFinal);
            this.pnlPanelCargar.Location = new System.Drawing.Point(10, 225);
            this.pnlPanelCargar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPanelCargar.Name = "pnlPanelCargar";
            this.pnlPanelCargar.Size = new System.Drawing.Size(545, 216);
            this.pnlPanelCargar.TabIndex = 15;
            this.pnlPanelCargar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanelCargar_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.RITtextos);
            this.panel1.Location = new System.Drawing.Point(221, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 216);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(310, 197);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "---";
            // 
            // RITtextos
            // 
            this.RITtextos.Location = new System.Drawing.Point(0, 0);
            this.RITtextos.Margin = new System.Windows.Forms.Padding(2);
            this.RITtextos.Name = "RITtextos";
            this.RITtextos.Size = new System.Drawing.Size(334, 197);
            this.RITtextos.TabIndex = 0;
            this.RITtextos.Text = "";
            // 
            // btmBusqueda
            // 
            this.btmBusqueda.Location = new System.Drawing.Point(176, 191);
            this.btmBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.btmBusqueda.Name = "btmBusqueda";
            this.btmBusqueda.Size = new System.Drawing.Size(31, 22);
            this.btmBusqueda.TabIndex = 6;
            this.btmBusqueda.Text = "♀";
            this.btmBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(2, 192);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
            this.txtBusqueda.TabIndex = 5;
            // 
            // btmCargarInicio
            // 
            this.btmCargarInicio.Location = new System.Drawing.Point(2, 4);
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
            this.btmSiguiente.Location = new System.Drawing.Point(103, 125);
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
            this.btmAnterior.Location = new System.Drawing.Point(2, 125);
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
            this.btmCargarFinal.Location = new System.Drawing.Point(2, 60);
            this.btmCargarFinal.Margin = new System.Windows.Forms.Padding(2);
            this.btmCargarFinal.Name = "btmCargarFinal";
            this.btmCargarFinal.Size = new System.Drawing.Size(206, 61);
            this.btmCargarFinal.TabIndex = 1;
            this.btmCargarFinal.Text = "Final";
            this.btmCargarFinal.UseVisualStyleBackColor = true;
            this.btmCargarFinal.Click += new System.EventHandler(this.btmCargarFinal_Click);
            // 
            // labAgregar
            // 
            this.labAgregar.AutoSize = true;
            this.labAgregar.Location = new System.Drawing.Point(285, 67);
            this.labAgregar.Name = "labAgregar";
            this.labAgregar.Size = new System.Drawing.Size(105, 13);
            this.labAgregar.TabIndex = 16;
            this.labAgregar.Text = "Guardar información:";
            this.labAgregar.Click += new System.EventHandler(this.label5_Click);
            // 
            // labCargar
            // 
            this.labCargar.AutoSize = true;
            this.labCargar.Location = new System.Drawing.Point(9, 210);
            this.labCargar.Name = "labCargar";
            this.labCargar.Size = new System.Drawing.Size(78, 13);
            this.labCargar.TabIndex = 17;
            this.labCargar.Text = "Cargar registro:";
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 467);
            this.Controls.Add(this.labCargar);
            this.Controls.Add(this.labAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPanelCargar);
            this.Controls.Add(this.btmAgregarInicio);
            this.Controls.Add(this.txtPosicionAgregar);
            this.Controls.Add(this.btmAgregarAUnPunto);
            this.Controls.Add(this.btmAgregarFinal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUIPrincipal";
            this.Text = "Heladería Miau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPanelCargar.ResumeLayout(false);
            this.pnlPanelCargar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btmAgregarFinal;
        private System.Windows.Forms.Button btmAgregarAUnPunto;
        private System.Windows.Forms.TextBox txtPosicionAgregar;
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
    }
}

