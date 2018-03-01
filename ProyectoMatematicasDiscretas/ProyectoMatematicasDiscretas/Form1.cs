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
    public partial class GUIArchivoDulce : Form
    {
        mundo codigo;
        

        public GUIArchivoDulce()
        {
            InitializeComponent();
            codigo = new mundo();
 
        }


        private void btmCargarInicio_Click(object sender, EventArgs e)
        {
            Dulce temp = codigo.subirInformacion(1);
            pintarEnPantalla(temp);
            txtBusqueda.Text = "1";
            MessageBox.Show("Se ha cargado el primer registro.");
        }

        public void pintarEnPantalla(Dulce pDulce)
        {
            String mensaje;

            if(pDulce.getEstado())
            {
                String tempFecha = pDulce.getFecha().ToString();
                String fecha = tempFecha.Substring(0,Dulce.MAX_FECHA);

                mensaje = "Nombre: " + pDulce.getNombre() + "\n"
                        + "Fecha: " + fecha + "\n"
                        + "Cantidad: " + pDulce.getCantidad() + " paquetes." + "\n"
                        + "Precio:$" + pDulce.getPrecio();
            }
            else
            {
                mensaje = "Éste registro se encuentra eliminado.";
            }
            
            RITtextos.Clear();
            RITtextos.Text = mensaje;
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


        private void btmCargarFinal_Click(object sender, EventArgs e)
        {
            Dulce temp = codigo.subirInformacion(codigo.darNumRegistros());
            pintarEnPantalla(temp);
            txtBusqueda.Text = codigo.darNumRegistros().ToString();
            MessageBox.Show("Se ha cargado el ultimo registro.");
        }

        public void limpiar()
        {
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btmAgregarAUnPunto_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = int.Parse(txtBusqueda.Text);

                double temp1 = codigo.convertirPrecio(txtPrecio.Text);
                int temp2 = codigo.convertirCantidad(txtCantidad.Text);
                
                Dulce t = new Dulce(txtNombre.Text, dtpFecha.Value, temp2, temp1, true);

                codigo.guardar(t, pos);
                pintarEnPantalla(t);
                actualizarRegistros();
                limpiar();

                btmFinalizarModifcacion.Enabled = false;
                btmCargarInicio.Enabled = true;
                btmCargarFinal.Enabled = true;
                btmAgregar.Enabled = true;
                btmModificar.Enabled = true;
                txtBusqueda.Enabled = true;
                btmEliminar.Enabled = true;
                btmVolcar.Enabled = true;
                btmVolcarDesorden.Enabled = true;

                MessageBox.Show("Se ha modificado el registro exitosamente.");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }

        private void btmAgregarFinal_Click(object sender, EventArgs e)
        {
            try
            {              
                double temp1 = codigo.convertirPrecio(txtPrecio.Text);
                int temp2 = codigo.convertirCantidad(txtCantidad.Text);
                
                Dulce t = new Dulce(txtNombre.Text, dtpFecha.Value, temp2, temp1, true);

                codigo.guardar(t, codigo.darNumRegistros() + 1);
                actualizarRegistros();
                limpiar();

                if(!pnlCargar.Enabled)
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


        private void btmBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                codigo.verificarPosicion(txtBusqueda.Text);
                int pos = Int32.Parse(txtBusqueda.Text);
                pintarEnPantalla(codigo.subirInformacion(pos));
                
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }
            

        private void btmModificar_Click(object sender, EventArgs e)
        {
            try
            {
                codigo.verificarPosicion(txtBusqueda.Text);
                int pos = int.Parse(txtBusqueda.Text);
                txtBusqueda.Enabled = false;
                btmModificar.Enabled = false;

                Dulce datos = codigo.subirInformacion(pos);
                pintarEnPantalla(datos);

                txtNombre.Text = datos.getNombre();
                dtpFecha.Value = datos.getFecha();
                txtCantidad.Text = datos.getCantidad().ToString();
                txtPrecio.Text = datos.getPrecio().ToString();

                MessageBox.Show("Se ha cargado el registro: " + pos + " para su modificación.");

                btmFinalizarModifcacion.Enabled = true;
                btmCargarInicio.Enabled = false;
                btmCargarFinal.Enabled = false;
                btmAgregar.Enabled = false;
                btmEliminar.Enabled = false;
                btmVolcar.Enabled = false;
                btmVolcarDesorden.Enabled = false;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RITtextos.Clear();
                txtBusqueda.Clear();
                txtRutaArchivo.Text = openFileDialog1.FileName;
                codigo.setRuta(openFileDialog1.FileName);
                actualizarRegistros();
                pnlRegistro.Enabled = true;
                btmVolcar.Enabled = true;
                btmVolcarDesorden.Enabled = true;

                try
                {
                    if (codigo.darNumRegistros() != 0) 
                    {
                        txtBusqueda.Text = "1";
                        pintarEnPantalla(codigo.subirInformacion(Int32.Parse(txtBusqueda.Text)));
                        pnlCargar.Enabled = true;
                    }
                    else
                    {
                        pnlCargar.Enabled = false;
                    }

                    txtRutaArchivo.Enabled = false;
                }
                catch 
                {
                    txtRutaArchivo.Clear();
                    pnlRegistro.Enabled = false;
                    MessageBox.Show("Abrir un archivo de texto plano o .txt");
                    
                }
                
            }
        }


        private void btmEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                codigo.verificarPosicion(txtBusqueda.Text);
                int pos = Int32.Parse(txtBusqueda.Text);
                pintarEnPantalla(codigo.subirInformacion(pos));

                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el registro actual?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.OK))
                {
                    codigo.eliminarRegistro(pos);
                    pintarEnPantalla(codigo.subirInformacion(pos));
                }
                else
                {
                    //no hace nada.
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                codigo.volcar(openFileDialog1.FileName, true);
                actualizarRegistros();
                MessageBox.Show("Se ha cargado los registros del archivo: " + openFileDialog1.FileName);
                pnlCargar.Enabled = true;
            }
        }


        private void btmAnterior_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtPosicionAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void RITtextos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void labArchivo_Click(object sender, EventArgs e)
        {

        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                codigo.volcar(openFileDialog1.FileName, false);
                actualizarRegistros();
                MessageBox.Show("Se ha cargado los registros del archivo: " + openFileDialog1.FileName);
                pnlCargar.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemArchivos_Click(object sender, EventArgs e)
        {

        }

        private void ItemListas_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();
            temp.Show();

           // this.Hide();
            
        }
    }
}
