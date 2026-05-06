namespace EjemploCola
{
    internal class Producto
    {
        public string nombre { get; set; }
        public int precio { get; set; }

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

    }
}
