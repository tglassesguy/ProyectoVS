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
    public partial class GUIMenu : Form
    {
        public GUIMenu()
        {
            InitializeComponent();
        }

        private void sistemaListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListasDulce temp = new GUIListasDulce();
            temp.Show();
        }

        private void sistemaArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIArchivoDulce temp = new GUIArchivoDulce();
            temp.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema fue desarollado por:" + "\n" +"\n" +
                            "Juan Felipe García Ruiz - 2220161015" + "\n" + 
                            "Javier Andrés Collazos Gómez - 2220161011" );
        }
    }
}
