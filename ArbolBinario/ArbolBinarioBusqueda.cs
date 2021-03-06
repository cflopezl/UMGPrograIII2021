using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class ArbolBinarioBusqueda<T>
    {
        public NodoArbol<T> raiz { get; set; }
        
        public ArbolBinarioBusqueda()
        {
            raiz = null;
        }

        public void Insertar(T valor,
            Func<T, T, bool> MenorQue, Func<T, T, bool> MayorQue)
        {
            raiz = Insertar(raiz, valor, MenorQue, MayorQue);
        }

        public NodoArbol<T> Insertar(NodoArbol<T> raizSub, T valor, 
            Func<T, T, bool>MenorQue, Func<T, T, bool> MayorQue)
        {
            if (raizSub == null)
            {
                raizSub = new NodoArbol<T> 
                    { data = valor, izq = null, der = null };
            }else if( MenorQue(valor, raizSub.data) )
            {
                raizSub.izq = Insertar(raizSub.izq, valor, MenorQue, MayorQue);
            }
            else if ( MayorQue(valor, raizSub.data))
            {
                raizSub.der = Insertar(raizSub.der, valor, MenorQue, MayorQue);
            }
            else throw new Exception("Nodo duplicado");

            return raizSub;
        }

        public void MostrarArbol(NodoArbol<T> raiz, String espacio)
        {
            if (raiz == null)
            {
                Console.WriteLine(espacio + "null");
            }
            else
            {
                MostrarArbol(raiz.der, espacio + "         ");
                Console.WriteLine(espacio + "      /");
                Console.WriteLine(espacio + raiz.data);
                Console.WriteLine(espacio + "      \\");
                MostrarArbol(raiz.izq, espacio + "         ");
            }
        }

    }
}
