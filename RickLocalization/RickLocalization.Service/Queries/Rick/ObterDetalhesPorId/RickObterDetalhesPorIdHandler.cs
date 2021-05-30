using MediatR;
using RickLocalization.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Rick.ObterDetalhesPorId
{
    public class RickObterDetalhesPorIdHandler : IRequestHandler<RickObterDetalhesPorIdRequest, RickObterDetalhesPorIdResponse>
    {
        private readonly IRickService _rickService;

        public RickObterDetalhesPorIdHandler(IRickService rickService)
        {
            _rickService = rickService;

        }
        public async Task<RickObterDetalhesPorIdResponse> Handle(RickObterDetalhesPorIdRequest request, CancellationToken cancellationToken)
        {
            var response = new RickObterDetalhesPorIdResponse();
            var query = await _rickService.ObterDetalhesPorId(request.RickId);           

            response.DimensaoOrigem = query.DimensaoOrigem;
            response.Nome = query.Nome;
            response.RickId = query.RickId;

            return response;
        }
    }
}
