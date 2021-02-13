using System;

namespace ListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple<String> listaNombres = new ListaEnlazadaSimple<String>();
            listaNombres.agregar("Michelle");
            listaNombres.agregar("Robin");
            listaNombres.agregar("Edy");

            listaNombres.recorrer();

            Console.WriteLine("");
            Console.WriteLine("-------------------------");

            ListaEnlazadaSimple<int> listaNotas = new ListaEnlazadaSimple<int>();
            listaNotas.agregar(80);
            listaNotas.agregar(50);
            listaNotas.agregar(90);
            listaNotas.recorrer();

            /*ListaEnlazadaSimple<Alumno> listaAlumno = new ListaEnlazadaSimple<Alumno>();
            listaAlumno.agregar*/
        }
    }
}
