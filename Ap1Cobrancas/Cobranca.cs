using System;
namespace Cobrancas
{
    public class Cobranca
    {

        public int Id { get;  set; }
        public Cliente Cliente { get;  set; }
        public DateTime DataEmissao { get;  set; }
        public DateTime DataVencimento { get;  set; }
        public decimal Valor { get; set; }
        public DateTime? DataPgto { get; set; }
        
        public Cobranca()
        {
            
        }
        public Cobranca(int id, Cliente cliente, DateTime dataEmissao, DateTime dataVencimento, decimal valor, DateTime dataPgto) 
        {
            this.Id = id;
            this.Cliente = cliente;
            this.DataEmissao = dataEmissao;
            this.DataVencimento = dataVencimento;
            this.Valor = valor;               
        }
        
    }
}