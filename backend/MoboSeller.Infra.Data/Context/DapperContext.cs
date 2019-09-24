using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.IO;

namespace MoboSeller.Infra.Data.Context
{
    public class DapperContext : IDapperContext
    {
        public string User { get; private set; }
        public string Passaword { get; private set; }
        public string Datasource { get; private set; }
        public int ConnectionTimeout { get; private set; }

        private OracleConnection oracleConnection = null;
        public DapperContext()
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile("appsettings.Development.json", optional: true)
               .Build();

            User = config.GetSection("Oracle:UserID").Value;
            Passaword = config.GetSection("Oracle:Password").Value;
            Datasource = config.GetSection("Oracle:DataSource").Value;
            ConnectionTimeout = Convert.ToInt32(config.GetSection("Oracle:ConnectionTimeout").Value);
        }
        public IDbConnection GetConnection()
        {
            if (oracleConnection == null)
            {
                oracleConnection = new OracleConnection()
                {
                    ConnectionString = new OracleConnectionStringBuilder
                    {
                        UserID = User,
                        Password = Passaword,
                        DataSource = Datasource,
                        ConnectionTimeout = ConnectionTimeout
                    }.ConnectionString
                };
            }

            if (oracleConnection.State == ConnectionState.Closed)
            {
                oracleConnection.Open();
            }

            return oracleConnection;
        }
    }
}
