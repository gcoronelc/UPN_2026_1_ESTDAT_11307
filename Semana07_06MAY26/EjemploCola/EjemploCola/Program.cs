using System;

namespace EjemploCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJEMPLO DE COLAS");

            Cola cola = new Cola();

            cola.encolar(new Producto("Televisor",4500));
            cola.encolar(new Producto("Chocolate", 230));
            cola.encolar(new Producto("Cocina", 2800));
            cola.encolar(new Producto("Perfume", 1500));
            cola.encolar(new Producto("Ramo de Rosas", 180));

            if (cola.eliminarNodo("Ramo de Rosas"))
            {
                Console.WriteLine("Nodo eliminado");
            } else
            {
                Console.WriteLine("Nodo no existe");
            }

            Nodo nodo = cola.desencolar();
            while(nodo != null )
            {
                Producto dato = nodo.dato;
                Console.WriteLine($"{dato.nombre} - {dato.precio}");
                nodo = cola.desencolar();
            }

        }
    }
}
