using System;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            NodoArbol<string> jesus = new NodoArbol<string>
            { data = "M Jesus",
                der = new NodoArbol<string> { data = "Abel", der = null, izq = null },
                izq = new NodoArbol<string> { data = "Anyora", der = null, izq = null },
            };
            NodoArbol<string> esperanza = new NodoArbol<string>
            {
                data = "Esperanza",
                der = new NodoArbol<string> { data = "Rodrigo", der = null, izq = null },
                izq = new NodoArbol<string> { data = "Maria", der = null, izq = null },
            };
            NodoArbol<string> raiz = new NodoArbol<string>
            { data = "Esperanza", der = jesus, izq = esperanza };
        }
    }
}
