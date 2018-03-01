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
            numRegistros = 0;
            cabeza = null;
               
        }

        public DulceLista darCabeza()
        {
            return cabeza;
        }

        public void setCabeza(DulceLista pDulcelLista)
        {
            cabeza = pDulcelLista;
        }


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


    }
}
