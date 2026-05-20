using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABB
{
	internal class Program
	{
		static void Main(string[] args)
		{

			ArbolBinario arbol = new ArbolBinario();

			arbol.Insertar(50);
			arbol.Insertar(80);
			arbol.Insertar(30);
			arbol.Insertar(70);
			arbol.Insertar(75);
			arbol.Insertar(20);
			arbol.Insertar(25);

			arbol.MostrarJerarquico();
			Console.WriteLine("==============================");
			arbol.MostrarComoArbol();
            Console.WriteLine("==============================");
            Console.WriteLine($"Existe el 20: {arbol.Buscar(20)}");
            Console.WriteLine($"Existe el 100: {arbol.Buscar(100)}");
            //Console.ReadKey();

        }
	}
}
