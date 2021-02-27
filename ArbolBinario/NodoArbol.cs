using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class NodoArbol<T>
    {
        public T data { get; set; }
        public NodoArbol<T> izq { get; set; }
        public NodoArbol<T> der { get; set; }
    }
}
