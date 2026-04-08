using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01Ejemplo01
{
    internal class Utilitario
    {

        public static ListaEnlazada Mezclar(ListaEnlazada lista1, ListaEnlazada lista2)
        {
            ListaEnlazada ListaFinal = new ListaEnlazada();
            Nodo ActualLista1 = lista1.Cabeza;
            Nodo ActualLista2 = lista2.Cabeza;
            int Dato;
            while (ActualLista1 != null && ActualLista2 != null)
            {
                if (ActualLista1.Dato <= ActualLista2.Dato)
                {
                    Dato = ActualLista1.Dato;
                    ActualLista1 = ActualLista1.Siguiente;
                }
                else
                {
                    Dato = ActualLista2.Dato;
                    ActualLista2 = ActualLista2.Siguiente;
                }
                ListaFinal.AgregarAlFinal(Dato);
            }
            while (ActualLista1 != null)
            {
                ListaFinal.AgregarAlFinal(ActualLista1.Dato);
                ActualLista1 = ActualLista1.Siguiente;
            }
            while (ActualLista2 != null)
            {
                ListaFinal.AgregarAlFinal(ActualLista2.Dato);
                ActualLista2 = ActualLista2.Siguiente;
            }
            return ListaFinal;
        }


    }
}
