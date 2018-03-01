using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatematicasDiscretas
{
    class DulceLista
    {
     
        public static int MAX_NOMBRE = 10;
        public static int MAX_CANTIDAD = 10;
        public static int MAX_PRECIO = 10;
        public static int MAX_FECHA = 10;
        public static int TAM_DULCE = MAX_NOMBRE + MAX_CANTIDAD + MAX_PRECIO + MAX_FECHA;

        private String nombre;
        private DateTime fecha;
        private int cantidad;
        private double precio;
        private bool estado;
        private DulceLista siguiente;


        public DulceLista(String pNombre, DateTime pFecha, int pCantidad, double pPrecio, bool pEstado)
        {

            nombre = pNombre;
            fecha = pFecha;
            cantidad = pCantidad;
            precio = pPrecio;
            estado = pEstado;
            siguiente = null;

            verificarDatos();

        }

        public void setSiguiente(DulceLista pDulceLista)
        {
            siguiente = pDulceLista;
        }

        public DulceLista getSiguiente()
        {
            return siguiente;
        }

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }
        public String getNombre()
        {
            return nombre;
        }

        public void setFecha(DateTime pFecha)
        {
            fecha = pFecha;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public void setCantidad(int pCantidad)
        {
            cantidad = pCantidad;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setPrecio(double pPrecio)
        {
            precio = pPrecio;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setEstado(bool pEstado)
        {
            estado = pEstado;
        }
        public bool getEstado()
        {
            return estado;
        }

        public void verificarDatos()
        {
            Exception e;
            if (nombre == null || nombre == "")
            {
                e = new Exception("Ingrese un nombre válido.");
                throw e;
            }
            if (fecha.CompareTo(DateTime.Now) == 1)
            {
                e = new Exception("Ingrese una fecha anterior a la fecha de hoy.");
                throw e;
            }
            if (cantidad.Equals(null) || cantidad.Equals("") || cantidad < 1)
            {
                e = new Exception("Ingrese una cantidad válida.");
                throw e;
            }
            if (precio.Equals(null) || precio.Equals("") || precio < 0)
            {
                e = new Exception("Ingrese un precio válido.");
                throw e;
            }
        }




    }
}
