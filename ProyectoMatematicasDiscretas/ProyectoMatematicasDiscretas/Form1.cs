using System;
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
    public partial class GUIPrincipal : Form
    {
        mundo codigo;

        public GUIPrincipal()
        {
            InitializeComponent();
            codigo = new mundo();

            if(!File.Exists(codigo.darRuta()))
            {
                File.Create(codigo.darRuta());
            }
            else
            {
                codigo.darNumRegistros();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmCargarInicio_Click(object sender, EventArgs e)
        {
                pintarEnPantalla(codigo.cargarRegistro(0));
                MessageBox.Show("Se ha cargado el primer registro.");
        }

        public void pintarEnPantalla(String mensaje)
        {
            RITtextos.Text = "";
            RITtextos.Text = mensaje;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(codigo.darNumRegistros() == 0)
            {
                lblTotal.Text = "No se encuentran registros en la base de datos.";
            }
            else
            {
                actualizarRegistros();
            }
        }

        public void actualizarRegistros()
        {
            lblTotal.Text = "Número de registros: " + codigo.darNumRegistros() + ".";
        }

        private void btmAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btmCargarFinal_Click(object sender, EventArgs e)
        {
            pintarEnPantalla(codigo.cargarRegistro(codigo.darNumRegistros()));
            MessageBox.Show("Se ha cargado el ultimo registros");
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
            codigo.agregarAlInicio(txtNombre.Text,dtpFecha.Value,txtCantidad.Text,txtPrecio.Text);
            actualizarRegistros();
            
            MessageBox.Show("Se ha guardado el registro en el inicio del archivo");
        }

        private void btmAgregarAUnPunto_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtBusqueda.Text);
            codigo.Modificar(txtNombre.Text, dtpFecha.Value, txtCantidad.Text, txtPrecio.Text, pos);
            pintarEnPantalla(codigo.cargarRegistro(Int32.Parse(txtBusqueda.Text)));
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
            codigo.agregarAlFinal(txtNombre.Text, dtpFecha.Value, txtCantidad.Text, txtPrecio.Text);
            actualizarRegistros();

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
                pintarEnPantalla(codigo.cargarRegistro(Int32.Parse(txtBusqueda.Text)));
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtBusqueda.Text);
            String[] datos = codigo.subirInformacion(pos);
            txtNombre.Text = datos[0];
            dtpFecha.Value = Convert.ToDateTime(datos[1]);
            txtCantidad.Text = datos[2];
            txtPrecio.Text = datos[3];

            MessageBox.Show("Se ha cargado el registro: " + pos + " para su modificación.");

            btmFinalizarModifcacion.Enabled = true;
            btmCargarInicio.Enabled = false;
            btmCargarFinal.Enabled = false;
            btmAgregarInicio.Enabled = false;
            btmAgregarFinal.Enabled = false;
        }
    }
}
