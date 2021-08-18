using System;

namespace Aula2Code
{
    class Program
    {

        static void Main(string[] args)
        {                      

            //Autor uncle = new Autor(23,"Martin", "5551515151");

            Livro meuLivro = 
                new Livro(1234, 
                          new Autor(23, "Martin","515651651"),
                          "Clean code - uncle bob",150);
            
            //quem é o autor do meuLivro
            Console.WriteLine(meuLivro.autor.nome + meuLivro.autor.fone);


            //como alterar o descricao do livro
            meuLivro.descricao = "clean code uncle bob toster ful";
            meuLivro.valor= 159;
           

            Console.WriteLine("Hello World!");

            //DRY dont repeat your self
        }
    }





}
