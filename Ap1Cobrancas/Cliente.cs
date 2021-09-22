
using System.Collections.Generic;
using Ap1Cobrancas;

namespace Cobrancas
{
    public class Cliente : Pessoa
    {        
        public List<Cobranca> cobrancas { get; set; }
        public decimal LimiteCredito { get; set; }
        public Cliente()
        {
            
        }
        public Cliente(int id, string nome, string fone, decimal limiteCredito) 
            :base(id,nome,fone)
        {     
            this.LimiteCredito=limiteCredito;
        }

    }
}