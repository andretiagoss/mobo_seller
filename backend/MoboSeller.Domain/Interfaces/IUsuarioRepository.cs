using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;

namespace MoboSeller.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario AutenticarUsuario(AutenticarUsuarioDTO request);
    }
}
