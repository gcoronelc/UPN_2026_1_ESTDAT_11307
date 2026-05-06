namespace EjemploCola
{
    internal class Nodo
    {

        public Producto dato {  get; set; }
        public Nodo siguiente {  get; set; }

        public Nodo(Producto dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

    }
}
