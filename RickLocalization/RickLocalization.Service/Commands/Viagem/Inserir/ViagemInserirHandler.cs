using MediatR;
using RickLocalization.Repository.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Commands.Viagem.Inserir
{
    public class ViagemInserirHandler : IRequestHandler<ViagemInserirRequest, ViagemInserirResponse>
    {
        private readonly RickLocalizationContext _context;

        public ViagemInserirHandler(RickLocalizationContext context)
        {
            _context = context;
        }
        public async Task<ViagemInserirResponse> Handle(ViagemInserirRequest request, CancellationToken cancellationToken)
        {
            var response = new ViagemInserirResponse();
            try
            {
                DateTime _dataAtual = DateTime.Now;

                var viagem = new Domain.Entities.Viagem();

                viagem.RickId = request.RickId;
                viagem.DimensaoId = request.DimensaoId;
                viagem.DataViagem = _dataAtual;
                viagem.Motivo = request.Motivo;

                viagem.Ativo = true;
                viagem.DataInclusao = _dataAtual;
                viagem.DataOperacao = _dataAtual;
                viagem.NaturezaOperacao = "I";

                _context.Viagens.Add(viagem);

                await _context.SaveChangesAsync();


                return response;
            }
            catch (Exception)
            {
                response.AddNotification("Erro", "Ocorreu uma excessao na sua solicitação");
                return response;
            }

           
        }
    }
}
