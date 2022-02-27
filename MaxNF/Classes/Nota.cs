namespace MaxNF.Classes
{
    class Nota
    {
        private int id;
        private int numeracao;
        private string tipo;
        private string data;

        private static readonly Nota _Instancia = new Nota();
        public static Nota instancia
        {
            get { return _Instancia; }
        }
        public int Id { get => id; set => id = value; }
        public int Numeracao { get => numeracao; set => numeracao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Data { get => data; set => data = value; }
    }
}
