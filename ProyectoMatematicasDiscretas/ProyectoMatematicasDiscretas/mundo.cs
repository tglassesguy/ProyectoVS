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
        public static int MAX_FECHA = 11;
        public static String RUTA = "D:/DATA.txt";

        FileStream archivo;

        public String darRuta()
        {
            return RUTA;
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
        public void agregarAlInicio(String nombre, DateTime fecha, String cantidad, String precio)
        {
            String data ="";

            data += ajustarData(nombre, MAX_NOMBRE);
            data += ajustarData(fecha.ToString(), MAX_FECHA);
            data += ajustarData(cantidad, MAX_CANTIDAD);
            data += ajustarData(precio, MAX_PRECIO);

            archivo = new FileStream(RUTA, FileMode.Open);

            archivo.Seek(0, SeekOrigin.Begin);
            archivo.Write(Encoding.ASCII.GetBytes(data), 0, data.Length);
            archivo.Close();
        }

        
    }



    
   
}












