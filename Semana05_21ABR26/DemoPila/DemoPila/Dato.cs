namespace DemoPila
{
    internal class Dato
    {

        public string estudiante {  get; set; }
        public int nota { get; set; }


        public Dato(string estudiante, int nota)
        {
            this.estudiante = estudiante;
            this.nota = nota;
        }

        public override string ToString()
        {
            return $"({this.estudiante}, {this.nota})";
        }
        
    }
}
