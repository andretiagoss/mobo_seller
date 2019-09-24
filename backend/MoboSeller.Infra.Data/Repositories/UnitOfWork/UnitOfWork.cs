using MoboSeller.Domain.Interfaces.UnitOfWork;
using MoboSeller.Infra.Data.Context;
using System.Data;

namespace MoboSeller.Infra.Data.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDapperContext context;
        private IDbConnection connection = null;
        private IDbTransaction transaction = null;

        public UnitOfWork(IDapperContext context)
        {
            this.context = context;
            this.connection = context.GetConnection();
        }

        IDbConnection IUnitOfWork.Connection
        {
            get
            {
                if (this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                return this.connection;
            }
        }

        IDbTransaction IUnitOfWork.Transaction
        {
            get { return this.transaction;}
        }

        public void Begin()
        {
            if (this.connection != null && this.transaction == null)
            {
                if (this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                this.transaction = this.connection.BeginTransaction();
            }
        }

        public void Commit()
        {
            if (this.transaction != null)
            {
                this.transaction.Commit();
                Dispose();
            }
        }

        public void Rollback()
        {
            if (this.transaction != null)
            {
                this.transaction.Rollback();
                Dispose();
            }
        }

        public void Dispose()
        {
            if (this.transaction != null)
                this.transaction.Dispose();
            this.transaction = null;
        }
    }
}
