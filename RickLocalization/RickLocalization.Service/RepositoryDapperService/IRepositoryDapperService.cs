using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace RickLocalization.Service.RepositoryDapperService
{
    public interface IRepositoryDapperService
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object parametros);
       
        Task<GridReader> QueryMultipleAsync(string sql, object parametros);
        string DataBaseName { get; }
    }
}
