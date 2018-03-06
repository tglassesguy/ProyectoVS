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
        private int numRegistros;
        FileStream archivo;
        private DulceLista cabeza;

        public MundoLista(String pRuta)
        {
            ruta = pRuta;
            cabeza = null;
        }

        public DulceLista darCabeza()
        {
            return cabeza;
        }

        /*
        public void setCabeza(DulceLista pDulcelLista)
        {
            cabeza = pDulcelLista;
        }
        */

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

        public void guardar(DulceLista pDulceLista)
        {
            DulceLista actual = cabeza;
            if(actual == null)
            {
                cabeza = pDulceLista;
            }
            else
            {
                if(actual.getSiguiente() == null)
                {
                    actual.setSiguiente(cabeza);
                    cabeza = pDulceLista;
                }
                else
                {
                    actual = actual.getSiguiente();
                }
            }         
        }



    }
}
