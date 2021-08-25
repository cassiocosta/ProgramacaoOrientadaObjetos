namespace SuperMercado
{
    public class Bike : Veiculo
    {
        public int TamQuadro { get; set; }

        public Bike(int id, string nome, int tamQuadro)
            :base(id,nome)
        {
            this.TamQuadro=tamQuadro;
        }
    }
}