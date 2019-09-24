using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Flunt.Notifications;
using MoboSeller.Application.Comunication;
using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Interfaces;

namespace MoboSeller.Application.UsuarioApp
{
    public class UsuarioApp : IUsuarioApp
    {
        private readonly IMapper Mapper;
        private readonly IUsuarioRepository Repository;

        public UsuarioApp(IMapper mapper, IUsuarioRepository repository)
        {
            this.Mapper = mapper;
            this.Repository = repository;
        }
        public async Task<Result> AutenticarAsync(AutenticarRequest autenticar)
        {
            autenticar.Validate();

            if (autenticar.Invalid) return new Result(autenticar.Notifications);

            var usuarioDTO = this.Mapper.Map<AutenticarDTO>(autenticar);
            var usuario = await this.Repository.AutenticarAsync(usuarioDTO);

            if (usuario == null)
            {
                return new Result(new Notification("Problema de autenticação", "Usuário e/ou Senha inválido(s)"));
            }

            var usuarioResponse = this.Mapper.Map<UsuarioResponse>(usuario);

            return new Result(HttpStatusCode.OK, usuarioResponse);
        }
    }
}
