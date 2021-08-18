using System.Linq;
namespace Aula2Code
{    
    public class Livro
    {
        public int id { get; set; }        
        public string nome {get; private set;}
        public string descricao {get;set;}
        public decimal valor { get; set; }
        public string isbn 
        {
            get
            {
                if(this.isbn.Length>10)
                    return this.isbn;
                else
                    return "";
            }
            set
            {
                this.isbn = value;
            }
        }        

        public Livro(int id, string nome, decimal valor)
        {
            this.id = id;
            this.nome=nome;
            this.valor=valor;
        }

        public void setLivro()
        {
            
        }
    }
}