using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListTests
{
    class Program
    {
        static List<Pessoa> pessoas;
        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            
            pessoas.Add(new Pessoa("Maria",43,eDiaSemana.seg));
            pessoas.Add(new Pessoa("Cassiano",20,eDiaSemana.qui));
            pessoas.Add(new Pessoa("Gean",25));

            Console.WriteLine("Lista usando forEach Normal\n---------");
            
            foreach (var item in pessoas)
            {   
                    Console.WriteLine(item.Nome + " " + item.Idade);
            }
            Console.WriteLine("\n");
            ListaComForeachDelegate();
            InserirItemNaPosicao();
            ListaComForeachDelegate();
            RemoverItemDalista();
            Lambdas();
        }
        static void ListaComForeachDelegate()
        {
            Console.WriteLine("Lista com Foreach e delegate\n---------");
            pessoas.ForEach(delegate(Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
        }
        static void InserirItemNaPosicao()
        {
            Console.WriteLine("uma pessoa na posição 1 e outra na 3\n----------");
            pessoas.Insert(1,new Pessoa("Diego",28));
            pessoas.Insert(3,new Pessoa("Taina",50));            
        }
        static void RemoverItemDalista()
        {
            Console.WriteLine("remover o cassiano\n----------");
            //funções lambdas.
            var i = pessoas.FindIndex(x=>x.Idade == 20);
            var x = pessoas.FindIndex(x=>x.Idade == 50);
            var result = pessoas.Where(x=>x.Idade>18).Count();
            pessoas.Where
        }

        static void Lambdas()
        {
            int c=0;            
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };           

            foreach (var item in numbers)
            {                
                int n = item %2;
                if(n==1)
                    c++;
            }            
            Console.WriteLine($"normal { c }");

            int oddNumbers = numbers.Count(n => n % 2 == 1);
            int soma = numbers.Sum();
            double media = numbers.Average();
            int maximo = numbers.Max();
            var result = numbers.Where()
            Console.WriteLine($"lambda { oddNumbers }");

        }
        string resposta => Console.ReadLine();
        static string Resposta()
        {
            return Console.ReadLine();
        }
    }
}
