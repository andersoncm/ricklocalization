
using Dapper;
using RickLocalization.Service.Interfaces;
using RickLocalization.Service.Queries.Rick.ObterTodos;
using RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId;
using RickLocalization.Service.RepositoryDapperService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Viagem
{
    public class ViagemService : IViagemService
    {
        private readonly IRepositoryDapperService _repository;

        public ViagemService(IRepositoryDapperService repository)
        {
            _repository = repository;
        }

        public async Task<List<ViagemObterHistoricoViagemPorRickIdItemDapper>> ObterHistoricoViagemPorRickId(int rickId)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@RickId", rickId);

            var result = await _repository.QueryAsync<ViagemObterHistoricoViagemPorRickIdItemDapper>(ResViagem.ObterHistoricoViagemPorRickId, parametros);

            return result.ToList();
        }
    }
}

