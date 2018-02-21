using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatematicasDiscretas
{
    class Dulce
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

        public Dulce( String pNombre, DateTime pFecha, int pCantidad, double pPrecio , bool pEstado)
        {
            nombre = pNombre;
            fecha = pFecha;
            cantidad = pCantidad;
            precio = pPrecio;
            estado = pEstado;

            verificarInvariante();
        }

        public void setNombre( String pNombre)
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

        public void verificarInvariante()
        {
            //TODO - Pendiente.
        }
        

    }
}
