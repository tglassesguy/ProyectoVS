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
            FileInfo temp = new FileInfo(darRuta());
            numRegistros = (int)temp.Length / TAM_DATA;
            return numRegistros;
        }

        public Dulce subirInformacion(int pos)
        {
           

            String[] array = new String[4];
            String data = cargarRegistro(pos);
            String temp1, temp2, temp3, temp4;
            temp1 = data.Substring(0,MAX_NOMBRE);
            array[0] = temp1.Trim(' ');
            temp2 = data.Substring(MAX_NOMBRE, MAX_FECHA);
            array[1] = temp2.Trim(' ');
            temp3 = data.Substring(MAX_NOMBRE + MAX_FECHA, MAX_CANTIDAD);
            array[2] = temp3.Trim(' ');
            temp4 = data.Substring(MAX_NOMBRE + MAX_FECHA + MAX_CANTIDAD, MAX_PRECIO);
            array[3] = temp4.Trim(' ');

            Dulce D = new Dulce(temp1,Convert.ToDateTime(temp2),Convert.ToInt32(temp3),Convert.ToDouble(temp4), true);

            return D;
            
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

     /*   public String DarRuta()
        {
            


        }
        */
    }
    

    
   
}












