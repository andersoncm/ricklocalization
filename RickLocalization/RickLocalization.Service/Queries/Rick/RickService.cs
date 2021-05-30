using Dapper;
using RickLocalization.Service.Interfaces;
using RickLocalization.Service.Queries.Rick.ObterDetalhesPorId;
using RickLocalization.Service.Queries.Rick.ObterTodos;
using RickLocalization.Service.RepositoryDapperService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Rick
{
    public class RickService : IRickService
    {
        private readonly IRepositoryDapperService _repository;

        public RickService(IRepositoryDapperService repository)
        {
            _repository = repository;
        }

        public async Task<RickObterDetalhesPorIdItemDapper> ObterDetalhesPorId(int rickId)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@RickId", rickId);

            var result = await _repository.QueryAsync<RickObterDetalhesPorIdItemDapper>(ResRick.ObterDetalhesPorId, parametros);

            return result.SingleOrDefault();
        }

        public async Task<List<RickObterTodosResponseItemDapper>> ObterTodos()
        {
            var parametros = new DynamicParameters();

            var result = await _repository.QueryAsync<RickObterTodosResponseItemDapper>(ResRick.ObterTodos, parametros);

            return result.ToList();
        }
    }
}
