﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ProyectoMatematicasDiscretas
{
    public partial class GUIArchivoDulce : Form
    {
        mundo codigo;

        public GUIArchivoDulce()
        {
            InitializeComponent();
            codigo = new mundo();
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmCargarInicio_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "1";
            String mensaje = darFormato(0);
            pintarEnPantalla(mensaje);
            MessageBox.Show("Se ha cargado el primer registro.");
        }

        public void pintarEnPantalla(String mensaje)
        {
            RITtextos.Clear();
            RITtextos.Text = mensaje;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           /* 
            */
        }

        public void actualizarRegistros()
        {
            if (codigo.darNumRegistros() == 0)
            {
                lblTotal.Text = "No se encuentran registros en la base de datos.";
            }
            else
            {
                lblTotal.Text = "Número de registros: " + codigo.darNumRegistros() + ".";
            }
        }

        private void btmAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btmCargarFinal_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = codigo.darNumRegistros().ToString();
            String mensaje = darFormato(codigo.darNumRegistros());
            pintarEnPantalla(mensaje);
            MessageBox.Show("Se ha cargado el ultimo registro.");
        }

        private void pnlPanelCargar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btmAgregarInicio_Click(object sender, EventArgs e)
        {
            //Crea el objeto dulce.
            double temp1 = Convert.ToDouble(txtPrecio.Text);
            int temp2 = Convert.ToInt32(txtCantidad.Text);

            Dulce t = new Dulce(txtNombre.Text, dtpFecha.Value, temp2 , temp1 ,true);

            codigo.guardar(t, 1);
            actualizarRegistros();
            limpiar();
            
            MessageBox.Show("Se ha guardado el registro en el inicio del archivo");
        }

        public void limpiar()
        {
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btmAgregarAUnPunto_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtBusqueda.Text);
            codigo.Modificar(txtNombre.Text, dtpFecha.Value, txtCantidad.Text, txtPrecio.Text, pos);
            String mensaje = darFormato(pos);
            pintarEnPantalla(mensaje);
            btmFinalizarModifcacion.Enabled = false;
            btmCargarInicio.Enabled = true;
            btmCargarFinal.Enabled = true;
            btmAgregarInicio.Enabled = true;
            btmAgregarFinal.Enabled = true;
            txtBusqueda.Enabled = true;
            limpiar();
            MessageBox.Show("Se ha modificado el registro exitosamente.");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtPosicionAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmAgregarFinal_Click(object sender, EventArgs e)
        {
            double temp1 = Convert.ToDouble(txtPrecio.Text);
            int temp2 = Convert.ToInt32(txtCantidad.Text);

            Dulce t = new Dulce(txtNombre.Text, dtpFecha.Value, temp2, temp1, true);

            codigo.guardar(t, codigo.darNumRegistros()+1);
            actualizarRegistros();
            limpiar();
            

            MessageBox.Show("Se ha guardado el registro al final del archivo.");
        }

        private void RITtextos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmBusqueda_Click(object sender, EventArgs e)
        {
            
            if(txtBusqueda.Text == "" | txtBusqueda.Text == null)
            {
                MessageBox.Show("Por favor, indicar la posición del registro. Recuerde que hay " + 5 /* cambiar esto*/ + " registros en la base de datos.");
            }
            else
            {
                String mensaje = darFormato(Int32.Parse(txtBusqueda.Text));
                pintarEnPantalla(mensaje);
                //pintarEnPantalla(codigo.cargarRegistro(Int32.Parse(txtBusqueda.Text)));
            }
        }

        public String darFormato(int pos)
        {
            /*   String[] partes = codigo.subirInformacion(pos);
               String mensaje = "Nombre: " + partes[0] + "\n" + "Fecha: " + partes[1] + "\n" + "Cantidad: " + partes[2] + " paquetes." + "\n" + "Precio:$" + partes[3];
               return mensaje;
               */
            return "ñaña";
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            
            int pos = int.Parse(txtBusqueda.Text);
            txtBusqueda.Enabled = false;
            Dulce datos = codigo.subirInformacion(pos);

            txtNombre.Text = datos.getNombre();
            dtpFecha.Value = datos.getFecha();
            txtCantidad.Text = datos.getCantidad().ToString();
            txtPrecio.Text = datos.getPrecio().ToString();

            MessageBox.Show("Se ha cargado el registro: " + pos + " para su modificación.");

            btmFinalizarModifcacion.Enabled = true;
            btmCargarInicio.Enabled = false;
            btmCargarFinal.Enabled = false;
            btmAgregarInicio.Enabled = false;
            btmAgregarFinal.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtRutaArchivo.Text = openFileDialog1.FileName;
                codigo.setRuta(openFileDialog1.FileName);
                actualizarRegistros();
            }

        }

        private void labArchivo_Click(object sender, EventArgs e)
        {

        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtBusqueda.Text);

            codigo.Modificar(txtNombre.Text, dtpFecha.Value, txtCantidad.Text, txtPrecio.Text, pos);
            
            String mensaje = darFormato(pos).ToString();
            mensaje.Remove(0, mundo.TAM_DATA);
            pintarEnPantalla(mensaje);
            actualizarRegistros();
            MessageBox.Show("Se ha eliminado el registro" + " " + pos + " " + "de la base de datos");
        }
    }
}
