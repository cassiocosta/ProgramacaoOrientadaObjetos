namespace Aula2Code
{
    public class Autor
    {
        public int id { get; private set; }
        public string nome { get; private set; }
        public string fone { get; private set; }

        public Autor(int id, string nome, string fone)
        {
            this.id=id;
            this.nome=nome;
            this.fone=fone;


        }
    }
}