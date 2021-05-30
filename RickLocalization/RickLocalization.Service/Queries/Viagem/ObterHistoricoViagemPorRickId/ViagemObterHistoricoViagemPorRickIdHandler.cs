using AutoMapper;
using MediatR;
using RickLocalization.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId
{
    public class ViagemObterHistoricoViagemPorRickIdHandler : IRequestHandler<ViagemObterHistoricoViagemPorRickIdRequest,ViagemObterHistoricoViagemPorRickIdResponse>
    {
        private readonly IViagemService _viagemService;
        IMapper _mapper;
        public ViagemObterHistoricoViagemPorRickIdHandler(IViagemService viagemService, IMapper mapper)
        {
            _viagemService = viagemService;
            _mapper = mapper;
        }
        public async Task<ViagemObterHistoricoViagemPorRickIdResponse> Handle(ViagemObterHistoricoViagemPorRickIdRequest request, CancellationToken cancellationToken)
        {
            var response = new ViagemObterHistoricoViagemPorRickIdResponse();
            try
            {
                var query = await _viagemService.ObterHistoricoViagemPorRickId(request.RickId);

                var resultado = _mapper.Map<List<ViagemObterHistoricoViagemPorRickIdResponseItem>>(query);

                response.lista = resultado;

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
