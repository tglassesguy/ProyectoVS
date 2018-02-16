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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmCargarInicio_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btmCargarFinal_Click(object sender, EventArgs e)
        {

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
            MessageBox.Show("Se ha guardado el registro en el inicio del archivo");
        }

        private void btmAgregarAUnPunto_Click(object sender, EventArgs e)
        {

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

        }
    }
}
