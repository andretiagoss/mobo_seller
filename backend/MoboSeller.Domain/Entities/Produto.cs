﻿namespace MoboSeller.Domain.Entities
{
    public class Produto
    {
        public long Id { get; set; }
        public string NomeProduto { get; set; }
        public string NomeCor { get; set; }
        public override string ToString() => $"{Id} - {NomeProduto} - {NomeCor}";
    }
}
