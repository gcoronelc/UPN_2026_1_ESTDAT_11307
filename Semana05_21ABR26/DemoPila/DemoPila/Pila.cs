using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPila
{
    internal class Pila
    {
        private Nodo top;
        private int tamanio;

        public Pila()
        {
            this.top = null;
            this.tamanio = 0;
        }

        public void push(Dato dato)
        {
            Nodo nodo = new Nodo(dato);
            nodo.siguiente = this.top;
            this.top = nodo;
            tamanio++;
        }

        public int getTamanio() { 
            return tamanio; 
        }

        public Nodo pop()
        {
            if(this.top == null)
            {
                return null;
            }
            Nodo nodo = this.top;
            this.top = nodo.siguiente;
            nodo.siguiente = null;
            tamanio--;
            return nodo;
        }
    }
}
