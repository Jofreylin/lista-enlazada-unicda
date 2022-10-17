using System;
using System.Collections.Generic;
using System.Text;

namespace CLASS_13_10_22
{
    internal class Multimedia
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public float Precio { get; set; }
        public string Genero { get; set; }
        public Multimedia Siguiente { get; set; }
    }
}
