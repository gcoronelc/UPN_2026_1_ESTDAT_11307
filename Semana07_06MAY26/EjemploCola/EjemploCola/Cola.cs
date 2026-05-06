using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Cola
    {
        private Nodo cabeza;
        private Nodo cola;
        public int nodos { get; set; } // Tamaño de la cola

        public Cola()
        {
            this.cabeza = null;
            this.cola = null;
            this.nodos = 0;
        }

        public void encolar(Producto dato)
        {
            // 1. Crear nodo
            Nodo nodo = new Nodo(dato);
            // 2. Si tamaño de la cola es cero
            if (this.cabeza == null)
            {
                this.cabeza = nodo;
                this.cola = nodo;
                this.nodos = 1;
                return;
            }
            // 3. Si la cola ya tiene nodos
            this.cola.siguiente = nodo;
            this.cola = nodo;
            this.nodos++;
        }

        public Nodo desencolar()
        {
            if(this.cabeza == null)
            {
                return null;
            }
            Nodo nodo;
            // Cola con un solo nodo
            if(this.cabeza == this.cola)
            {
                nodo = this.cabeza;
                this.cabeza = this.cola = null;
                this.nodos = 0;
                return nodo;
            }
            // Cola con varios nodos
            nodo = this.cabeza;
            this.cabeza = this.cabeza.siguiente;
            cola.siguiente = null;
            this.nodos--;
            return nodo;
        }


        public bool eliminarNodo(string nombre)
        {
            // 1. Cola vacía
            if (this.cabeza == null)
                return false;

            // 2. El nodo a eliminar es la cabeza
            if (this.cabeza.dato.nombre == nombre)
            {
                // Caso: un único nodo en la cola
                if (this.cabeza == this.cola)
                {
                    this.cabeza = this.cola = null;
                    this.nodos = 0;
                    return true;
                }
                // Caso: varios nodos, se elimina la cabeza
                this.cabeza = this.cabeza.siguiente;
                this.nodos--;
                return true;
            }

            // 3. Buscar el nodo en el resto de la cola
            Nodo anterior = this.cabeza;
            Nodo actual = this.cabeza.siguiente;

            while (actual != null)
            {
                if (actual.dato.nombre == nombre)
                {
                    // Enlazar anterior con el siguiente del nodo a eliminar
                    anterior.siguiente = actual.siguiente;

                    // Si se eliminó el último nodo, actualizar la referencia cola
                    if (actual == this.cola)
                        this.cola = anterior;

                    this.nodos--;
                    return true;
                }
                anterior = actual;
                actual = actual.siguiente;
            }

            // 4. No se encontró ningún nodo con ese nombre
            return false;
        }
    }
}
