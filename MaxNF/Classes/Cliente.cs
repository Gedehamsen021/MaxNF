namespace MaxNF.Classes
{
    class Cliente
    {
        private int id;
        private string nome;
        private int qtd;
        private static readonly Cliente _Instancia = new Cliente();
        public static Cliente instancia
        {
            get { return _Instancia; }
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Qtd { get => qtd; set => qtd = value; }
    }
}
