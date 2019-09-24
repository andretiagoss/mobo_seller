using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using MoboSeller.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoboSeller.Infra.Data.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        public async Task<IEnumerable<Estoque>> ObterAsync(ObterDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
