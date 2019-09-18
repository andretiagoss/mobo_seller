using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoboSeller.Domain.Interfaces
{
    public interface IEstoqueRepository
    {
        IEnumerable<Estoque> ObterEstoque(ObterEstoqueDTO request);
    }
}
