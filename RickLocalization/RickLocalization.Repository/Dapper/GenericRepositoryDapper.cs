using Dapper;
using Microsoft.Extensions.Configuration;
using RickLocalization.Repository.Dapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Repository.Dapper
{
    public class GenericRepositoryDapper : BaseRepositoryDapper, IRepositoryDapper
    {
        public GenericRepositoryDapper(IConfiguration configuration)
            : base(configuration)
        {

        }


        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object parametros)
        {
            return await con.QueryAsync<T>(sql, param: parametros, commandType: CommandType.Text);
        }

        public async Task<SqlMapper.GridReader> QueryMultipleAsync(string sql, object parametros)
        {
            return await con.QueryMultipleAsync(sql, param: parametros, transaction: null, commandType: CommandType.Text);
        }
    }
}
