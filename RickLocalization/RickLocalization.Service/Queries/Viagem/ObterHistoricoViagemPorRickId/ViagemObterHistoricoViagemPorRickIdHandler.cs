using MediatR;
using RickLocalization.Service.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId
{
    public class ViagemObterHistoricoViagemPorRickIdHandler : IRequestHandler<ViagemObterHistoricoViagemPorRickIdRequest, ViagemObterHistoricoViagemPorRickIdResponse>
    {
        private readonly IViagemService _viagemService;
        public ViagemObterHistoricoViagemPorRickIdHandler(IViagemService viagemService)
        {
            _viagemService = viagemService;
        }
        public async Task<ViagemObterHistoricoViagemPorRickIdResponse> Handle(ViagemObterHistoricoViagemPorRickIdRequest request, CancellationToken cancellationToken)
        {
            var response = new ViagemObterHistoricoViagemPorRickIdResponse();
            var query = await _viagemService.ObterHistoricoViagemPorRickId(request.RickId);

            response.lista = query;

            return response;
        }
    }
}
