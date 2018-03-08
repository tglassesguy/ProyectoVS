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
        private DulceLista cabecera;

        public MundoLista(String pRuta)
        {
            ruta = pRuta;
            cabecera = null;
        }

        public DulceLista darCabeza()
        {
            return cabecera;
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
            }
        }

        public void agregarPos(DulceLista pDulceLista, int pos)
        {
            DulceLista actual = cabecera;

            int indicador = 0;

            while (indicador <= pos-1)
            {
                actual = actual.getSiguiente();
                indicador++;

            }

            DulceLista tempDulce = actual.getSiguiente();
            actual.setSiguiente(pDulceLista);
            actual.getSiguiente().setSiguiente(tempDulce);
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

        private void polloLoMama()
        {
            String perra = "Ce mamo";
        }
    }
}
