using MediatR;
using Microsoft.EntityFrameworkCore;
using RickLocalization.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Dimensao.ObterTodos
{
    public class DimensaoObterTodosHandler : IRequestHandler<DimensaoObterTodosRequest, DimensaoObterTodosResponse>
    {
        private readonly RickLocalizationContext _context;

        public DimensaoObterTodosHandler(RickLocalizationContext context)
        {
            _context = context;
        }
        public async Task<DimensaoObterTodosResponse> Handle(DimensaoObterTodosRequest request, CancellationToken cancellationToken)
        {

            var response = new DimensaoObterTodosResponse();

            var query =  _context.Dimensoes.AsNoTracking().Where(a => a.Ativo)
               .Select(a => new ItemDimensao
                {
                   DimensaoId = a.DimensaoId,
                    Descricao = a.Descricao
                }).ToList();

            response.lista =  query;

            return response;

        }
    }
}
