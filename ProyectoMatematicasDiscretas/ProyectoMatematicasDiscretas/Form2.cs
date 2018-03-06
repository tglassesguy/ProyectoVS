using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMatematicasDiscretas
{
    public partial class Form2 : Form
    {

        MundoLista codigo;

        public Form2()
        {
            InitializeComponent();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double temp1 = codigo.convertirPrecio(txtPrecio.Text);
                int temp2 = codigo.convertirCantidad(txtCantidad.Text);

                DulceLista t = new DulceLista(txtNombre.Text, dtpFecha.Value, temp2, temp1, true);

                codigo.guardar(t);
                actualizarRegistros();
                limpiar();

                if (!pnlCargar.Enabled)
                {
                    pnlCargar.Enabled = true;
                    pintarEnPantalla(codigo.subirInformacion(1));
                }

                MessageBox.Show("Se ha guardado el registro");
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);

            }

        }

        private void limpiar 

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btmRuta_Click(object sender, EventArgs e)
        {
            codigo = new MundoLista(txtRutaArchivo.Text);
        }
    }
}
