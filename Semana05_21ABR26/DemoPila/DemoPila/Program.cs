using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();

            Console.WriteLine($"Tamanio: {pila.getTamanio()}");

            pila.push(new Dato("Gustavo", 15));
            Console.WriteLine($"Tamanio: {pila.getTamanio()}");

            pila.push(new Dato("Claudia", 18));
            Console.WriteLine($"Tamanio: {pila.getTamanio()}");

            pila.push(new Dato("Jorge", 10));
            Console.WriteLine($"Tamanio: {pila.getTamanio()}");


            Nodo nodo = pila.pop();
            Console.WriteLine(nodo.dato);
            Console.WriteLine($"Tamanio: {pila.getTamanio()}");
        }
    }
}
