namespace SuperMercado
{
    public abstract class Veiculo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Veiculo(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

    }
}