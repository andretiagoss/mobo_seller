using System.Data;

namespace MoboSeller.Infra.Data.Context
{
    public interface IDapperContext
    {
        IDbConnection GetConnection();
    }
}
