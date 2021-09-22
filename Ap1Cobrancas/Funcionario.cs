namespace Ap1Cobrancas
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }

        public Funcionario(int id, string nome, string fone, decimal salario)
            :base(id,nome,fone)
        {
            this.Salario=salario;
        }
    }
}