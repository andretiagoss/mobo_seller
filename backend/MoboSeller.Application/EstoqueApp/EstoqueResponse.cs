using MoboSeller.Application.ProdutoApp;

namespace MoboSeller.Application.EstoqueApp
{
    public class EstoqueResponse
    {
        public string Loja { get; set; }
        public string Codigo { get; set; }
        public decimal Venda { get; set; }
        public int QtdeDisponivel { get; set; }
        public long ProdutoId { get; set; }
        public string Tamanho { get; set; }
        public string Familia { get; set; }
        public ProdutoResponse Produto { get; set; }

        public override string ToString() => $"{ProdutoId}";
    }
}
