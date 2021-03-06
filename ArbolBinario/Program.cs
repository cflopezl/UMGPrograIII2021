using System;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NodoArbol<string> jesus = new NodoArbol<string>
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
            { data = "Esperanza", der = jesus, izq = esperanza };*/

            ArbolBinarioBusqueda<int> abbenteros = new ArbolBinarioBusqueda<int>();
            //delegado mayor y menor para enteros
            Func<int, int, bool> MenorQueEntero = (x, y) => x < y;
            Func<int, int, bool> MayorQueEntero = (x, y) => x > y;
            //agregar nuevas llaves a la EDD
            abbenteros.Insertar(50, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(35, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(80, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(10, MenorQueEntero, MayorQueEntero);

            abbenteros.MostrarArbol(abbenteros.raiz,"");

        }
    }
}
