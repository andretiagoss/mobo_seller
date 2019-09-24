using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using System.Threading.Tasks;

namespace MoboSeller.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> AutenticarAsync(AutenticarDTO request);
    }
}
