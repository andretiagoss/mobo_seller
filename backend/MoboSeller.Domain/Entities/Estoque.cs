namespace MoboSeller.Domain.Entities
{
    public class Estoque
    {
        public string NumeroLoja { get; set; }
        public string Codigo { get; set; }
        public long ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public long CorId { get; set; }
        public Cor Cor { get; set; }
        public int QtdeDisponivel { get; set; }
    }
}
