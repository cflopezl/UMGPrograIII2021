using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazada
{
    class ListaEnlazadaSimple<T>
    {
        Nodo<T> primero { get; set; }
        Nodo<T> ultimo { get; set; }
        Nodo<T> actual { get; set; }
        int total { get; set; }

        public ListaEnlazadaSimple()
        {
            actual = ultimo = primero = null;
            total = 0;
        }

        public void agregar(T pDato)
        {
            //1. crear el nuevo nodo
            Nodo<T> nuevo = new Nodo<T>(pDato);
            //2. depende
            if(primero == null)//lista vacía
            {
                primero = nuevo;
                ultimo = nuevo; 
            }
            else //lista NO vacía
            {                
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            total++;
        }

        public void recorrer()
        {
            actual = primero;
            while( actual != null )
            {
                Console.Write(actual.dato + " -> ");
                actual = actual.siguiente;
            }
        }

        public bool buscar(Func<T, T, bool> fIgualdad, 
                                    T elementoABuscar){
            actual = primero;
            while( actual != null )
            {
                if( fIgualdad(actual.dato,elementoABuscar) ){
                    return true;
                }
                actual = actual.siguiente;
            }
            return false;
        }


    }
}
