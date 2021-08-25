using System;
using System.Collections.Generic;

namespace SuperMercado
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public Cliente Cliente { get; set; }
        public List<ProdutosDoPedido> Itens { get; set; }
    }

    public struct ProdutosDoPedido
    {
        int id;
        string nome;
    }

}