using RickLocalization.Service.Queries.Viagem;
using RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RickLocalization.Service.Interfaces
{
    public interface IViagemService
    {
        Task<List<ViagemObterHistoricoViagemPorRickIdItemDapper>> ObterHistoricoViagemPorRickId(int rickId);

    }
}
