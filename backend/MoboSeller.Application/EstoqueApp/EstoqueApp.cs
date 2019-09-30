using AutoMapper;
using Flunt.Notifications;
using MoboSeller.Application.Comunication;
using MoboSeller.Application.UsuarioApp;
using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using MoboSeller.Domain.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace MoboSeller.Application.EstoqueApp
{
    public class EstoqueApp : IEstoqueApp
    {
        private readonly IMapper Mapper;
        private readonly IEstoqueRepository Repository;

        public EstoqueApp(IMapper mapper, IEstoqueRepository repository)
        {
            this.Mapper = mapper;
            this.Repository = repository;
        }
        public async Task<Result> ObterAsync(ObterRequest autenticar)
        {
            autenticar.Validate();

            if (autenticar.Invalid) return new Result(autenticar.Notifications);

            var obterDTO = this.Mapper.Map<ObterDTO>(autenticar);
            var estoque = await this.Repository.ObterAsync(obterDTO);

            var estoqueResponse = this.Mapper.Map<IEnumerable<Estoque>,List<EstoqueResponse>>(estoque);
            
            return new Result(HttpStatusCode.OK, estoqueResponse);
        }
    }
}
