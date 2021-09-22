namespace Ap1Cobrancas
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        protected string Nome { get; set; }
        protected string Fone { get; set; }

        public string MyProperty { get; set; }

        public Pessoa()
        {
            
        }
        public Pessoa(int id, string nome, string fone) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Fone = fone;
        }
    }   
}