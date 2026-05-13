using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class ArbolBinario
    {

        public Nodo Raiz { get; set; }

        public ArbolBinario()
        {
            this.Raiz = null;
        }

        public void MostrarArbol()
        {
            if (Raiz == null)
            {
                Console.WriteLine("El árbol está vacío.");
                return;
            }

            // La raíz se imprime sola, luego arranca la jerarquía con │
            Console.WriteLine(Raiz.Dato);

            bool tieneIzquierda = Raiz.Izquierda != null;
            bool tieneDerecha = Raiz.Derecha != null;

            if (tieneIzquierda && tieneDerecha)
            {
                MostrarNodo(Raiz.Izquierda, "", false);
                MostrarNodo(Raiz.Derecha, "", true);
            }
            else if (tieneIzquierda)
            {
                MostrarNodo(Raiz.Izquierda, "", true);
            }
            else if (tieneDerecha)
            {
                MostrarNodo(Raiz.Derecha, "", true);
            }
        }

        private void MostrarNodo(Nodo nodo, string prefijo, bool esUltimo)
        {
            if (nodo == null) return;

            string conector = esUltimo ? "└─ " : "├─ ";
            string prefijHijos = prefijo + (esUltimo ? "   " : "│  ");

            Console.WriteLine(prefijo + conector + nodo.Dato);

            bool tieneIzquierda = nodo.Izquierda != null;
            bool tieneDerecha = nodo.Derecha != null;

            if (tieneIzquierda && tieneDerecha)
            {
                MostrarNodo(nodo.Izquierda, prefijHijos, false);
                MostrarNodo(nodo.Derecha, prefijHijos, true);
            }
            else if (tieneIzquierda)
            {
                MostrarNodo(nodo.Izquierda, prefijHijos, true);
            }
            else if (tieneDerecha)
            {
                MostrarNodo(nodo.Derecha, prefijHijos, true);
            }
        }

        public void AgregarNodo(int dato)
        {
            Raiz = AgregarRecursivo(this.Raiz,dato);
         }

        public Nodo AgregarRecursivo(Nodo raiz, int valor)
        {
            if(raiz == null)
            {
               return new Nodo(valor);
            }
            if(valor < raiz.Dato)
            {
                raiz.Izquierda = AgregarRecursivo(raiz.Izquierda, valor);
            }
            else if(valor > raiz.Dato)
            {
                raiz.Derecha = AgregarRecursivo(raiz.Derecha, valor);
            }
            return raiz;
        }


        public void ImprimirInOrden()
        {
            Console.Write("Recorrido InOrden: ");
            ImprimirInOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        private void ImprimirInOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                ImprimirInOrdenRecursivo(raiz.Izquierda);
                Console.Write(raiz.Dato + " ");
                ImprimirInOrdenRecursivo(raiz.Derecha);
            }
        }


        public void ImprimirPreOrden()
        {
            Console.Write("Recorrido PreOrden: ");
            ImprimirPreOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        private void ImprimirPreOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                Console.Write(raiz.Dato + " ");
                ImprimirPreOrdenRecursivo(raiz.Izquierda);
                ImprimirPreOrdenRecursivo(raiz.Derecha);
            }
        }

        public void ImprimirPostOrden()
        {
            Console.Write("Recorrido PostOrden: ");
            ImprimirPostOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        public void ImprimirPostOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                ImprimirPostOrdenRecursivo(raiz.Izquierda);
                ImprimirPostOrdenRecursivo(raiz.Derecha);
                Console.Write(raiz.Dato + " ");
            }
        }


    }
}
