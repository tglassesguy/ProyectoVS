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
            DulceLista c = generarDulce();
            if(c != null)
            {
                codigo.agregarPos(c ,0);
                MessageBox.Show("Se ha agregado al nodo inicial.");
            }
        }

        private DulceLista generarDulce()
        {
            try
            {
                String tempNombre = txtNombre.Text;
                DateTime tempDate = dtpFecha.Value;
                int tempCantidad = codigo.convertirCantidad(txtCantidad.Text);
                double tempPrecio = codigo.convertirPrecio(txtPrecio.Text);

                return new DulceLista(tempNombre, tempDate, tempCantidad, tempPrecio);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btmRuta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {    
            DulceLista c = generarDulce();
            if(c != null)
            {
                codigo.agregarFinal(c);
                MessageBox.Show("Se registrado al final.");
            }   
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

            DulceLista c = generarDulce();

            if(c !=null)
            {
                codigo.agregarPos(c, pos);
                MessageBox.Show("Se registrado en la posición " + pos);
            }
            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        /*
         * To-Do List
         * 
         * TODO - Comprobar la fecha (no permitir ingresar fechas a partir mañana).
         */
    }
}
