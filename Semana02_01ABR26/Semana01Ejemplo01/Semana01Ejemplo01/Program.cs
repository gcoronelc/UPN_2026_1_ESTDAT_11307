// Programa principal para probar la lista enlazada

// Importando el namespace para usar las clases Nodo y ListaEnlazada
using Semana01Ejemplo01;

// Crear la lista
ListaEnlazada lista = new ListaEnlazada();

// Insertar 3 elementos
lista.AgregarAlFinal(10);
lista.AgregarAlFinal(40);
lista.AgregarAlFinal(30);
lista.AgregarAlInicio(100);

// Listar elementos
Console.WriteLine("Elementos de la lista enlazada:");
lista.Imprimir();

Nodo encontrado = lista.Buscar(200);
string mensaje = (encontrado == null) ? "NULL" : encontrado.Dato.ToString();
Console.WriteLine("Resultado: " + mensaje);

lista.OrdenarBurbuja();
lista.Imprimir();

// Mezcla
ListaEnlazada lista1 = new ListaEnlazada();
lista1.AgregarAlFinal(20);
lista1.AgregarAlFinal(10);
lista1.AgregarAlFinal(15);
ListaEnlazada lista2 = new ListaEnlazada();
lista2.AgregarAlFinal(30);
lista2.AgregarAlFinal(18);
lista2.AgregarAlFinal(14);
lista2.AgregarAlFinal(60);
lista2.AgregarAlFinal(42);

Console.WriteLine("\n\nEnlazar Listas");
lista1.OrdenarBurbuja();
lista1.Imprimir();
lista2.OrdenarBurbuja();
lista2.Imprimir();

ListaEnlazada nuevaLista = Utilitario.Mezclar(lista1, lista2);
nuevaLista.Imprimir();




// Fin del programa
Console.WriteLine("Presione una tecla para salir...");
Console.ReadKey();

