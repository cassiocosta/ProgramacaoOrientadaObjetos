using System.Collections.Generic;
using System.ComponentModel;
namespace ListTests
{
    //Padrão de nomenclaturas
    //nome de classes, métodos, propriedades usamos PascalCase
    //nome de variáveis, parametros, camelCase;
    public class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }        

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade=idade;
        }

        public static List<Pessoa>GetAll()
        {
            return new List<Pessoa>();
        }

    }
}