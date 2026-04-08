namespace Semana01Ejemplo01
{
    internal class ListaEnlazada
    {
        private Nodo Cabeza;

        public ListaEnlazada()
        {
            Cabeza = null;
        }

        public void AgregarAlFinal(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
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
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }

    }
}
