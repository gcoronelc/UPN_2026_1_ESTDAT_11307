using System.Collections;
using System.Data;
using static System.Net.WebRequestMethods;

namespace Semana01Ejemplo01
{
    internal class ListaEnlazada
    {
        public Nodo Cabeza;

        public ListaEnlazada()
        {
            Cabeza = null;
        }

        // Aplicando Cláusulas de Guarda
        public void AgregarAlFinal(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                return;
            }
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }


        public void AgregarAlInicio(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato); 
            nuevoNodo.Siguiente = Cabeza; 
            Cabeza = nuevoNodo;
        }


        public void Imprimir()
        {
            if (Cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return; // Finaliza el programa
            }
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ->");
                actual = actual.Siguiente;
            }
            Console.WriteLine(" NULL");
        }

        public Nodo Buscar(int dato)
        {
            Nodo encontrado = null;
            Nodo actual = Cabeza;
            while (actual != null)
            {
                if(actual.Dato == dato)
                {
                    encontrado = new Nodo(dato);
                    break;
                }
                actual = actual.Siguiente;
            }
            return encontrado;
        }

        public void OrdenarBurbuja()
        {
            if (Cabeza == null) return; // Lista vacía
            bool hayIntercambio;
            do
            {
                hayIntercambio = false;
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    if (actual.Dato > actual.Siguiente.Dato)
                    {
                        // Intercambiar los datos de los nodos
                        int temp = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temp;
                        hayIntercambio = true;
                    }
                    actual = actual.Siguiente;
                } // Bucle hile
            } while (hayIntercambio);
        }


    }
}
