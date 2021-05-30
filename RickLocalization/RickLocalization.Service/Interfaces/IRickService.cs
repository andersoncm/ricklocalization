using RickLocalization.Service.Queries.Rick.ObterDetalhesPorId;
using RickLocalization.Service.Queries.Rick.ObterTodos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Service.Interfaces
{
   public interface IRickService
    {
        Task<List<RickObterTodosResponseItemDapper>> ObterTodos();
        Task<RickObterDetalhesPorIdItemDapper> ObterDetalhesPorId(int rickId);

    }
}
