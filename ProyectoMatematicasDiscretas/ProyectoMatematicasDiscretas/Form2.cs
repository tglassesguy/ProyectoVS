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

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btmRuta_Click(object sender, EventArgs e)
        {
            codigo = new MundoLista(txtRutaArchivo.Text);
        }
    }
}
