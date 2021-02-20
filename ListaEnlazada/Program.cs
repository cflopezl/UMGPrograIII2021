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
            Console.WriteLine(listaNombres.buscar( (x,y)=>x==y , "Edy"));

            Console.WriteLine("-------------------------");

            ListaEnlazadaSimple<int> listaNotas = new ListaEnlazadaSimple<int>();
            listaNotas.agregar(80);
            listaNotas.agregar(50);
            listaNotas.agregar(90);
            listaNotas.recorrer();

            Console.WriteLine("");
            Console.WriteLine(listaNotas.buscar((x, y) => x == y, 80));
            Console.WriteLine("-------------------------");

            ListaEnlazadaSimple<Banco> listaBanco = new ListaEnlazadaSimple<Banco>();
            Banco banrural = new Banco { id = 1, nombre = "BANRURAL" };
            listaBanco.agregar(banrural);
            listaBanco.agregar(new Banco { id = 2, nombre = "G&T" });
            listaBanco.agregar(new Banco { id = 3, nombre = "PROMERICA" });
            listaBanco.recorrer();
            Console.WriteLine("");
            Console.WriteLine(listaBanco.buscar(Banco.EsIgual , new Banco { id=1, nombre="BANCO INDUSTRIAL"}));



        }
    }
}
