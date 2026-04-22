namespace DemoPila
{
    internal class Nodo
    {
        public Dato dato {  get; set; }
        public Nodo siguiente { get; set; }

        public Nodo(Dato dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

    }
}
