using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatematicasDiscretas
{
    class MundoLista
    {

        public static int MAX_NOMBRE = 10;
        public static int MAX_CANTIDAD = 10;
        public static int MAX_PRECIO = 10;
        public static int MAX_FECHA = 10;

        public static int TAM_DATA = MAX_NOMBRE + MAX_CANTIDAD + MAX_PRECIO + MAX_FECHA;

        private String ruta;
        FileStream archivo;
        private DulceLista cabecera;

        public MundoLista() //Establecer el parámetro ruta luego.
        {
            /*ruta = pRuta;*/
            cabecera = null;
        }

        public DulceLista darCabeza()
        {
            return cabecera;
        }

        public String darRuta()
        {
            return ruta;
        }
        public void setRuta(String pRuta)
        {
            ruta = pRuta;
        }
        public double convertirPrecio(String pPrecio)
        {

            double resultado;

            try
            {
                resultado = Convert.ToDouble(pPrecio);
            }
            catch (Exception m)
            {
                m = new Exception("Ingresar un valor numérico válido para el precio.");
                throw m;
            }

            return resultado;
        }

        public int convertirCantidad(String pCantidad)
        {

            int resultado;

            try
            {
                resultado = Int32.Parse(pCantidad);
            }
            catch (Exception m)
            {
                m = new Exception("Ingresar un valor numérico válido para la cantidad.");
                throw m;
            }

            return resultado;
        }
        /*
        public void guardar(DulceLista pDulceLista)
        {
            DulceLista actual = cabecera;
            if(actual == null)
            {
                cabecera = pDulceLista;
            }
            else
            {
                if(actual.getSiguiente() == null)
                {
                    actual.setSiguiente(cabecera);
                    cabecera = pDulceLista;
                }
                else
                {
                    actual = actual.getSiguiente();
                }
            }         
        }
        */

        private Boolean comprobarCabeza()
        {
            Boolean result = false;

            if(cabecera == null)
            {
                result = true;
            }

            return result;
               
        }

        public void agregarFinal(DulceLista pDulceLista)
        {
            if (comprobarCabeza())
            {
                cabecera = pDulceLista;
            }
            else
            {
                DulceLista actual = cabecera;

                while (actual.getSiguiente() != null)
                {
                    actual = actual.getSiguiente();
                }

                actual.setSiguiente(pDulceLista);
                actual.getSiguiente().setAnterior(actual);
            }
        }

        public void agregarPos(DulceLista pDulceLista, int pos)
        {
            DulceLista actual = cabecera;
            DulceLista temp;

            if(pos == 0)
            {
                temp = cabecera;
                cabecera = pDulceLista;
                cabecera.setSiguiente(temp);
                return;
            }

            for(int i = 0; i < pos - 1; i++)
            {
                actual = actual.getSiguiente();
            }

            temp = actual.getSiguiente();
            actual.setSiguiente(pDulceLista);
            pDulceLista.setAnterior(actual);
            pDulceLista.setSiguiente(temp);
            temp.setAnterior(pDulceLista);

        }

        public DulceLista cargarNodoFinal()
        {
            DulceLista resultado;
            if(comprobarCabeza())
            {
                resultado = null;
            }
            else
            {
                resultado = cabecera;

                while(resultado.getSiguiente() != null)
                {
                    resultado = resultado.getSiguiente();
                }
            }
            return resultado;
        }

        public void guardar(String ruta)
        {
            String data = persistencia();

            archivo = new FileStream(ruta, FileMode.Open);

            archivo.Seek(0, SeekOrigin.Begin);
            archivo.Write(Encoding.ASCII.GetBytes(data), 0, data.Length);
            archivo.Close();
        }

        public String persistencia()
        {
            String resultado = "";

            DulceLista actual = cabecera;
            //TODO - comprobar si cabecera está vacia. luego. 
            while(actual!=null)
            {
                resultado += actual.getNombre().ToString() + actual.getPrecio().ToString() + actual.getFecha() + actual.getCantidad() + "|||||";
                actual = actual.getSiguiente();
            }

            return resultado;
        }
    }
}
