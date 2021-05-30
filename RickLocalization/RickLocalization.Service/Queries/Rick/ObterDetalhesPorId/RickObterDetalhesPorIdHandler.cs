using AutoMapper;
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
        IMapper _mapper;

        public RickObterDetalhesPorIdHandler(IRickService rickService, IMapper mapper)
        {
            _rickService = rickService;
            _mapper = mapper;

        }
        public async Task<RickObterDetalhesPorIdResponse> Handle(RickObterDetalhesPorIdRequest request, CancellationToken cancellationToken)
        {
            var response = new RickObterDetalhesPorIdResponse();
            try
            {
                var query = await _rickService.ObterDetalhesPorId(request.RickId);

                var resultado = _mapper.Map<RickObterDetalhesPorIdResponse>(query);

                response = resultado;

                return response;
            }
            catch (Exception)
            {

                response.AddNotification("Erro", "Ocorreu uma exceção na sua solicitação");
                return response;
            }

           
        }
    }
}
