using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazada
{
    class Banco
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public override string ToString()
        {
            return $"id={id}, nombre={nombre}";
        }

        public static bool EsIgual(Banco ban1, Banco ban2)
        {
            if (ban1.nombre == ban2.nombre)
                return true;
            return false;
        }
    }
}
