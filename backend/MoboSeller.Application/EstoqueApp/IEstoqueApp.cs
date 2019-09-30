using MoboSeller.Application.Comunication;
using System.Threading.Tasks;

namespace MoboSeller.Application.EstoqueApp
{
    public interface IEstoqueApp
    {
        Task<Result> ObterAsync(ObterRequest request);
    }
}
