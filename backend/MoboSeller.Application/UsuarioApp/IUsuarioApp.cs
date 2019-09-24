using MoboSeller.Application.Comunication;
using System.Threading.Tasks;

namespace MoboSeller.Application.UsuarioApp
{
    public interface IUsuarioApp
    {
        Task<Result> AutenticarAsync(AutenticarRequest autenticar);
    }
}
