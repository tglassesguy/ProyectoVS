using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ProyectoMatematicasDiscretas
{
    class mundo
    {
    
        public static int MAX_NOMBRE = 10;  
        public static int MAX_CANTIDAD = 10;
        public static int MAX_PRECIO = 10;
        public static int MAX_FECHA = 10;
       
        public static int TAM_DATA = MAX_NOMBRE + MAX_CANTIDAD + MAX_PRECIO + MAX_FECHA;

        private String ruta;

        FileStream archivo;
        private int numRegistros = 0;



        public String darRuta()
        {
            return ruta;
        }
        public void setRuta(String pRuta)
        {
            ruta = pRuta;
        }

        public int darNumRegistros()
        {
            //try catch, hacer.

            FileInfo temp = new FileInfo(darRuta());
            numRegistros = (int)temp.Length / TAM_DATA;
            return numRegistros;
        }

        public Dulce subirInformacion(int pos)
        {
            Dulce d;
            String data = cargarRegistro(pos);

            if (data.StartsWith("/!/"))
            {
                String fakeDate = "01/01/2018";
                d = new Dulce("", Convert.ToDateTime(fakeDate), 0, 0, false);
            }
            else
            {
                String temp1, temp2, temp3, temp4;
                temp1 = data.Substring(0, MAX_NOMBRE).Trim(' ');
                temp2 = data.Substring(MAX_NOMBRE, MAX_FECHA).Trim(' ');
                temp3 = data.Substring(MAX_NOMBRE + MAX_FECHA, MAX_CANTIDAD).Trim(' ');
                temp4 = data.Substring(MAX_NOMBRE + MAX_FECHA + MAX_CANTIDAD, MAX_PRECIO).Trim(' ');

                d = new Dulce(temp1, Convert.ToDateTime(temp2), Convert.ToInt32(temp3), Convert.ToDouble(temp4), true);
            }

            return d;
            
        }
        public void Modificar(String nombre, DateTime fecha, String cantidad, String precio , int pos)
        {
            String data = "";

            data += ajustarData(nombre, MAX_NOMBRE);
            data += ajustarData(fecha.ToString(), MAX_FECHA);
            data += ajustarData(cantidad, MAX_CANTIDAD);
            data += ajustarData(precio, MAX_PRECIO);

            archivo = new FileStream(darRuta(), FileMode.Open);

            archivo.Seek(TAM_DATA * (pos - 1), SeekOrigin.Begin);
            archivo.Write(Encoding.ASCII.GetBytes(data), 0, data.Length);
            archivo.Close();
        }
     
        public String ajustarData(String text, int max)
        {
            String mensaje;

            if(text.Length > max)
            {
                mensaje = text.Substring( 0 , max );
            }
            else
            {
                mensaje = text + new string(' ', max - text.Length);
            }

            return mensaje;
        }

        public void guardar (Dulce pDulce, int pPos)
        {
            String data = "";

            data += ajustarData(pDulce.getNombre(), MAX_NOMBRE);
            data += ajustarData(pDulce.getFecha().ToString(), MAX_FECHA);
            data += ajustarData(Convert.ToString(pDulce.getCantidad()) , MAX_CANTIDAD);
            data += ajustarData(Convert.ToString(pDulce.getPrecio()), MAX_PRECIO);

            archivo = new FileStream(darRuta(), FileMode.Open);

            archivo.Seek(TAM_DATA * (pPos - 1), SeekOrigin.Begin);
            archivo.Write(Encoding.ASCII.GetBytes(data), 0, data.Length);
            archivo.Close();

        }

        public String cargarRegistro(int pos)
        {
            byte[] info = new byte[TAM_DATA];
            archivo = new FileStream(darRuta(), FileMode.Open);
            archivo.Seek(TAM_DATA * (pos - 1), SeekOrigin.Begin);
            archivo.Read(info, 0, TAM_DATA);
            archivo.Close();

            return System.Text.Encoding.Default.GetString(info);
            
        }

        public void volcar(String pRuta)
        {
            Dulce temp; 
            StreamReader lector = new StreamReader(pRuta);
            String line = " ";

            while(line != null)
            {
                //la condición del while no se está evaluando.

                line = lector.ReadLine();
                temp = importarDatos(line);

                guardar(temp, darNumRegistros() + 1);
            }

            lector.Close();
        }

        public Dulce importarDatos(String pTexto)
        {
            String[] partes = pTexto.Split(';');

            Dulce c = new Dulce(partes[0], Convert.ToDateTime(partes[1]), Int32.Parse(partes[2]), double.Parse(partes[3]), true);
            return c;

        }

        public void eliminarRegistro(int pPos)
        {
            String deleteData = "/!/";
            deleteData += new string('%', Dulce.TAM_DULCE - 3);
            archivo = new FileStream( darRuta(), FileMode.Open);

            archivo.Seek(TAM_DATA * (pPos - 1), SeekOrigin.Begin);
            archivo.Write(Encoding.ASCII.GetBytes(deleteData), 0, deleteData.Length);
            archivo.Close();

        }



    }
}












