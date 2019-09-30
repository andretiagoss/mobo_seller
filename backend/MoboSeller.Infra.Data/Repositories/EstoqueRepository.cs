using Dapper;
using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using MoboSeller.Domain.Interfaces;
using MoboSeller.Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoboSeller.Infra.Data.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly IUnitOfWork UnitOfWork = null;
        public EstoqueRepository(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Estoque>> ObterAsync(ObterDTO request)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT E.LOJA Loja,");
                query.AppendLine("       E.IDPRODUTO Codigo,");
                query.AppendLine("       E.CUSTO Custo,");
                query.AppendLine("       E.VENDA Venda,");
                query.AppendLine("       (E.QTDE_A + E.QTDE_B) QtdeDisponivel,");
                query.AppendLine("       E.IDCODIGO ProdutoId,");
                query.AppendLine("       E.COR Cor,");
                query.AppendLine("       E.TAMANHO Tamanho,");
                query.AppendLine("       E.FAMILIA Familia,");
                query.AppendLine("       E.DT_CHEGADA DataInclusao,");
                query.AppendLine("       E.DT_ULTIMO_RECEB DataAlterecao,");
                query.AppendLine("       P.NOME NomeProduto,");
                query.AppendLine("       C.NOME NomeCor");
                query.AppendLine("  FROM ESTOQUE E");
                query.AppendLine("  LEFT JOIN PRODUTOS P");
                query.AppendLine("    ON P.IDPRODUTO = E.IDCODIGO");
                query.AppendLine(" INNER JOIN COR C");
                query.AppendLine("    ON C.IDCOR = E.COR");
                query.AppendLine(" WHERE 1 = 1");

                if (!string.IsNullOrEmpty(request.Loja))
                {
                    query.AppendLine($"AND E.LOJA = '{request.Loja}' ");
                }

                if (!string.IsNullOrEmpty(request.Codigo))
                {
                    query.AppendLine($"AND E.IDPRODUTO LIKE '%{request.Codigo}%' ");
                }

                if (!string.IsNullOrEmpty(request.NomeProduto))
                {
                    query.AppendLine($"AND P.NOME LIKE '%{request.NomeProduto}%' ");
                }

                if (!string.IsNullOrEmpty(request.NomeCor))
                {
                    query.AppendLine($"AND C.NOME LIKE '%{request.NomeCor}%' ");
                }

                if (!string.IsNullOrEmpty(request.Tamanho))
                {
                    query.AppendLine($"AND E.TAMANHO = '{request.Tamanho}' ");
                }

                if (!string.IsNullOrEmpty(request.Familia))
                {
                    query.AppendLine($"AND E.FAMILIA = '{request.Familia}' ");
                }

                var result = await SqlMapper.QueryAsync<Estoque, Produto, Estoque>(this.UnitOfWork.Connection,
                        query.ToString(), (estoque, produto) =>
                        {
                            estoque.Produto = produto;

                            if (produto != null) produto.Id = estoque.ProdutoId;

                            return estoque;
                        }, null, this.UnitOfWork.Transaction, splitOn: "NomeProduto");

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
