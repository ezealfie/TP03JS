using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace TP03_ALFIE_FAINSCHTEIN.Models
{
    public class PalabrasAhorcado
    {
        private List<string> palabras;
        public PalabrasAhorcado()
        {
            palabras = new List<string>()
            {
         "MURCIELAGO",
"BRUJULA",
"RELAMPAGO",
"ASTRONAUTA",
"SERPENTINA",
"CATARATA",
"XILOFONO",
"PINGUINO",
"LABERINTO",
"CHIMENEA",
"TORNASOL",
"ESCARABAJO",
"BICICLETA",
"TERREMOTO",
"HELICOPTERO",
"PARAGUAYO",
"MARIPOSA",
"BIBLIOTECA",
"CARAMELO",
"DINOSAURIO"
        };

        }
        public string ObtenerPalabra()
        {
            Random rnd = new Random();
            int numero = rnd.Next(palabras.Count - 1);
            return palabras[numero];

        }
    }
}