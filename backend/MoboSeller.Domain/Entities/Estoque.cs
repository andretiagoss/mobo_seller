﻿namespace MoboSeller.Domain.Entities
{
    public class Estoque
    {
        public Estoque()
        {
            Produto = new Produto();
        }
        public string Loja { get; set; }
        public string Codigo { get; set; }
        public decimal Custo { get; set; }
        public decimal Venda { get; set; }
        public int QtdeDisponivel { get; set; }
        public long ProdutoId { get; set; }
        public string CorId { get; set; }
        public string Tamanho { get; set; }
        public string Familia { get; set; }
        public Produto Produto { get; set; }

        public override string ToString() => $"{ProdutoId}";
    }
}
