namespace EjemploListaDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaDoble lista = new ListaDoble();

            // Esto imprime Lista vacia
            lista.MostrarAdelante();

            lista.InsertarAlFinal(new Producto("Laptop", 3000.0));
            lista.InsertarAlFinal(new Producto("Impresora", 500.0));

            // Imprime la lista correcta
            lista.MostrarAdelante();
            
        }
    }
}
