using System;
using System.Collections.Generic;
using System.Text;

namespace CLASS_13_10_22
{
    internal class ListaMultimedia
    {
        public Multimedia inicio;

        private Multimedia BuscarUltimo(Multimedia nodo)
        {
            if(nodo.Siguiente == null)
            {
                return nodo;
            }

            Multimedia final = BuscarUltimo(nodo.Siguiente);
            return final;
        }

        public void AgregarInicio(Multimedia nodo)
        {
            if(inicio == null)
            {
                inicio = nodo;
            }
            else
            {
                Multimedia aux = inicio;
                inicio = nodo;
                inicio.Siguiente = aux;
            }
        }

        public void AgregarFinal(Multimedia nodo)
        {
            if(inicio == null)
            {
                inicio = nodo;
            }
            else
            {
                Multimedia aux = BuscarUltimo(inicio);
                aux.Siguiente = nodo;
            }
        }
    }
}
