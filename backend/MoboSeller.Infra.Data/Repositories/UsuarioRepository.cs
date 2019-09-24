using Dapper;
using MoboSeller.Domain.DTO;
using MoboSeller.Domain.Entities;
using MoboSeller.Domain.Interfaces;
using MoboSeller.Domain.Interfaces.UnitOfWork;
using System;
using System.Text;
using System.Threading.Tasks;

namespace MoboSeller.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IUnitOfWork UnitOfWork = null;

        public UsuarioRepository(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public async Task<Usuario> AutenticarAsync(AutenticarDTO request)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT ID_USUARIO Id, NOME Login, SENHA, INATIVO, SP_LOJ Loja, SP_DAT DataInclusao, SP_DAT_ALT DataAlteracao");
                query.AppendLine("  FROM USUARIOS");
                query.AppendLine(" WHERE NOME = :nome");
                query.AppendLine("   AND SENHA = :senha");

                var result = await SqlMapper.QueryFirstOrDefaultAsync<Usuario>(this.UnitOfWork.Connection,
                    query.ToString(), new { nome = request.Login, senha = request.Senha }, this.UnitOfWork.Transaction);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
