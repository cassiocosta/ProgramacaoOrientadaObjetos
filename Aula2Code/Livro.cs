using System.Linq;
namespace Aula2Code
{    
    public class Livro
    {
        public int id { get; set; }        
        public string nome {get; private set;}
        public string descricao {get;set;}
        public decimal valor { get; set; }

        public string isbn {get;set;}

        public Autor autor { get; set; }

        public Livro(int id, Autor autor,string nome, decimal valor)
        {
            this.id = id;
            this.nome=nome;
            this.valor=valor;
            this.autor = autor;
        }

        public decimal AplicarDesconto(decimal percDesconto)
        {
            return 0;
        }

        public void Save(Livro livro)
        {
            //vai salvar o livro no bd
        }
    }
}