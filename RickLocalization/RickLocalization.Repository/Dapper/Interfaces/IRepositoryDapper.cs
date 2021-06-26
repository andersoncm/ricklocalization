using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace RickLocalization.Repository.Dapper.Interfaces
{
   public interface IRepositoryDapper
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object parametros);
        Task<GridReader> QueryMultipleAsync(string sql, object parametros);
        

    }
}
