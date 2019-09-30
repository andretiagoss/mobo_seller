using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoboSeller.Application.EstoqueApp;
using MoboSeller.WebAPI.Extension;

namespace MoboSeller.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private readonly IEstoqueApp EstoqueApp;

        public EstoqueController(IEstoqueApp estoqueApp)
        {
            this.EstoqueApp = estoqueApp;
        }
       
        [Route("obterAsync")]
        [HttpPost]
        public async Task<IActionResult> ObterAsync([FromBody] ObterRequest request)
        {
            var result = await this.EstoqueApp.ObterAsync(request);
            return result.ToHttpResponse();
        }
    }
}
