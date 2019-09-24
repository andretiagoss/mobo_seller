using Microsoft.Extensions.DependencyInjection;
using MoboSeller.Application.UsuarioApp;
using MoboSeller.Domain.Interfaces;
using MoboSeller.Domain.Interfaces.UnitOfWork;
using MoboSeller.Infra.Data.Context;
using MoboSeller.Infra.Data.Repositories;
using MoboSeller.Infra.Data.Repositories.UnitOfWork;

namespace MoboSeller.Infra.CrossCutting.IoC
{
    public class NativeInjectorConfig
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //services.AddScoped<IDapperContext>();
            services.AddScoped<IDapperContext, DapperContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IUsuarioApp, UsuarioApp>();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IEstoqueRepository, EstoqueRepository>();
        }
    }
}
