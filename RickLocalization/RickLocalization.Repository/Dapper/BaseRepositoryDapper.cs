using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RickLocalization.Repository.Dapper
{
    public abstract class BaseRepositoryDapper : IDisposable
    {
        IConfiguration _configuration;

        private string _connectionString;
        protected IDbConnection con;
        public string DataBaseName { get; private set; }

        public BaseRepositoryDapper(IConfiguration configuration)
        {
            _configuration = configuration;

            SetConnectionString();

            con = new SqlConnection(_connectionString);
        }

        private void SetConnectionString()
        {
            _connectionString = _configuration.GetConnectionString("RickDbConnection");
        }
        

        public void Dispose()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
