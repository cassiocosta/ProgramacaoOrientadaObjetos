namespace SuperMercado
{
    public class Item
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public decimal Quantidade { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal Desconto { get; set; }
        
    }
}