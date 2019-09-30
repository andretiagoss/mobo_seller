using System;
using System.Collections.Generic;
using System.Text;

namespace MoboSeller.Application.ProdutoApp
{
    public class ProdutoResponse
    {
        public long Id { get; set; }
        public string NomeProduto { get; set; }
        public string NomeCor { get; set; }
        public override string ToString() => $"{Id} - {NomeProduto} - {NomeCor}";
    }
}
