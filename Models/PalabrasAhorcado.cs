using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TP03JS.Models;


namespace TP03_ALFIE_FAINSCHTEIN.Models
{
    public class PalabrasAhorcado
    {
        BD datos;
        private List<string> palabras;
        public PalabrasAhorcado()
        {
            datos = new BD();
            palabras = datos.devolverPalabras();


        }
        public string ObtenerPalabra()
        {
            Random rnd = new Random();
            int numero = rnd.Next(palabras.Count - 1);
            return palabras[numero];

        }
        public bool AgregarPalabra(string palabra)
        {
            if(!palabras.Contains(palabra)){
                datos.agregar(palabra);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}