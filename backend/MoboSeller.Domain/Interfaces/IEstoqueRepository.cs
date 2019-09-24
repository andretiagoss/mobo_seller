using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoboSeller.Domain.Interfaces
{
    public interface IEstoqueRepository
    {
        Task<IEnumerable<Estoque>> ObterAsync(ObterDTO request);
    }
}
