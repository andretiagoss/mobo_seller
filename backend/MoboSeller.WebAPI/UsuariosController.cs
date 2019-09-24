using Microsoft.AspNetCore.Mvc;
using MoboSeller.Application.UsuarioApp;
using MoboSeller.WebAPI.Extension;
using System.Threading.Tasks;

namespace MoboSeller.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioApp usuarioApp;

        public UsuariosController(IUsuarioApp usuarioApp)
        {
            this.usuarioApp = usuarioApp;
        }

        [Route("autenticar")]
        [HttpPost]
        public async Task<IActionResult> AutenticarAsync([FromBody] AutenticarRequest request)
        {
            var result = await this.usuarioApp.AutenticarAsync(request);
            return result.ToHttpResponse();
        }
    }
}
