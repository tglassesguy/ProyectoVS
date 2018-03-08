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
    public partial class GUIListasDulce : Form
    {

        MundoLista codigo;

        public GUIListasDulce()
        {
            InitializeComponent();
            codigo = new MundoLista();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {

            /*
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
            */

        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btmRuta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tempNombre = txtNombre.Text;
            DateTime tempDate = dtpFecha.Value;
            int tempCantidad = Int32.Parse(txtCantidad.Text);
            double tempPrecio = Convert.ToDouble(txtPrecio.Text);

            DulceLista c = new DulceLista(tempNombre,tempDate,tempCantidad, tempPrecio, true);

            codigo.agregarFinal(c);

            MessageBox.Show("Se registrado al final.");
        }

        private void btmCargarInicio_Click(object sender, EventArgs e)
        {
            DulceLista temp = codigo.darCabeza();

            pintarEnPantalla(temp);

        }

        private void pintarEnPantalla(DulceLista pDulceLista)
        {
                
        }

        private void btmCargarFinal_Click(object sender, EventArgs e)
        {
            DulceLista temp = codigo.cargarNodoFinal();

            pintarEnPantalla(temp);
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            codigo.guardar("D:/lol.txt");
            MessageBox.Show("SOMEBODY TOCHA MY SPAGHET");
        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmAgregarPos_Click(object sender, EventArgs e)
        {
            int pos = Int32.Parse(txtBusqueda.Text);
            String tempNombre = txtNombre.Text;
            DateTime tempDate = dtpFecha.Value;
            int tempCantidad = Int32.Parse(txtCantidad.Text);
            double tempPrecio = Convert.ToDouble(txtPrecio.Text);

            DulceLista c = new DulceLista(tempNombre, tempDate, tempCantidad, tempPrecio, true);

            codigo.agregarPos(c, pos);

            MessageBox.Show("Se registrado en la posición "+ pos);
        }
    }
}
