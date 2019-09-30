using MoboSeller.Application.EstoqueApp;
using MoboSeller.Application.ProdutoApp;
using MoboSeller.Application.UsuarioApp;
using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using System.Collections.Generic;

namespace MoboSeller.Application.Utility.Profile
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
            CreateMap<Estoque, EstoqueResponse>().ReverseMap();
            CreateMap<Produto, ProdutoResponse>().ReverseMap();

            CreateMap<AutenticarDTO, AutenticarRequest>().ReverseMap();
            CreateMap<ObterDTO, ObterRequest>().ReverseMap();
        }
    }
}
