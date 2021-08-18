using System;

namespace Aula2Code
{
    class Program
    {

        static void Main(string[] args)
        {                       
            Livro meuLivro = new Livro(1234,"Clean code - uncle bob",150);
            Console.WriteLine(meuLivro.nome);

            //como alterar o descricao do livro
            meuLivro.descricao = "clean code uncle bob toster ful";
            meuLivro.valor= 159;
           

            Console.WriteLine("Hello World!");

            //DRY dont repeat your self
        }
    }





}
