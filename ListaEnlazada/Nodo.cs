using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazada
{
    class Nodo<T>
    {
        public T dato { get; set; }
        public Nodo<T> siguiente { get; set; }

        public Nodo(T pDato)
        {
            this.dato = pDato;
            this.siguiente = null;
        }
    }
}
