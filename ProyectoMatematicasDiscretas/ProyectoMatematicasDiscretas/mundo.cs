﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ProyectoMatematicasDiscretas
{
    class Mundo
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
            Dulce d;
            String data = cargarRegistro(pos);

            if (data.StartsWith("/!/"))
            {
                String fakeDate = "01/01/2018";
                d = new Dulce(" ", Convert.ToDateTime(fakeDate), 1, 0, false);
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

        public void volcar(String pRuta ,Boolean pOrden)
        {
            Dulce temp; 
            StreamReader lector = new StreamReader(pRuta);
            String line;

            line = lector.ReadLine();

            while (line != null)
            { 
                temp = importarDatos(line, pOrden);
                guardar(temp, darNumRegistros() + 1);
                line = lector.ReadLine();
            } 

            lector.Close();
        }

        public Dulce importarDatos(String pTexto, Boolean pOrden)
        {
            String[] partes = pTexto.Split(';');
            Dulce c;

            if (pOrden)
            {
                c = new Dulce(partes[0], Convert.ToDateTime(partes[1]), Int32.Parse(partes[2]), Convert.ToDouble(partes[3]), true);
            }
            else
            {

                String tempNombre = "";
                DateTime tempFecha = DateTime.Now;
                int tempCantidad = 0;
                double tempPrecio = 0;

                for (int i = 0; i < partes.Length; i++)
                {
                    if (partes[i].Contains(","))
                    {
                        tempPrecio = Convert.ToDouble(partes[i]);
                    }
                    else if (partes[i].Contains("/"))
                    {
                        tempFecha = Convert.ToDateTime(partes[i]);
                    }
                    else if (isNumeric(partes[i]))
                    {
                        tempCantidad = Int32.Parse(partes[i]);
                    }
                    else
                    {
                        tempNombre = partes[i];
                    }

                }

                 c = new Dulce(tempNombre, tempFecha, tempCantidad, tempPrecio, true);
            }

            return c;

        }
        public Boolean isNumeric(String pText)
        {
            try
            {
                int temp = Int32.Parse(pText);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public void eliminarRegistro(int pPos)
        {
            
            String deleteData = "/!/";
            deleteData += new string('%', Dulce.TAM_DULCE - 3);
            archivo = new FileStream(darRuta(), FileMode.Open);

            archivo.Seek(TAM_DATA * (pPos - 1), SeekOrigin.Begin);
            archivo.Write(Encoding.ASCII.GetBytes(deleteData), 0, deleteData.Length);
            archivo.Close();

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

        public void verificarPosicion(String pPos)
        {
            int prueba;
            Exception m;
            try
            {
                prueba = Int32.Parse(pPos);

            }
            catch
            {
                throw m = new Exception("Debe ingresar un número, no un caracter.");
            }

            if (prueba < 1 || prueba > darNumRegistros())
            {
                throw m = new Exception("Debe ingresar un número de registro mayor que 0 y menor que " + (darNumRegistros() + 1) + ".");
            }
        }



    }
}












