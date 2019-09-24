using MoboSeller.Application.UsuarioApp;
using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;

namespace MoboSeller.Application.Utility.Profile
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
            CreateMap<AutenticarDTO, AutenticarRequest>().ReverseMap();
        }
    }
}
