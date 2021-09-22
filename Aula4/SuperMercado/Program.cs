using System.Numerics;
using System;

namespace SuperMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bicicleta = new Bike(12,"biccross",150);
            
            Produto produtoRecemNascido = new Produto(13,"Teclado");
            produtoRecemNascido.Valor = 250;
            produtoRecemNascido.QuantidadeEstoque = 15;

            Produto produto = new Produto(12,"Mouse",150,10);
            produto.Valor = 159;
            produto.QuantidadeEstoque = 8;

            


            Console.WriteLine($"O produto {produto.Nome} contém {produto.QuantidadeEstoque} em estoque.");
        }
    }
}
