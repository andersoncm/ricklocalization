using AutoMapper;
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
        IMapper _mapper;

        public ViagemInserirHandler(RickLocalizationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ViagemInserirResponse> Handle(ViagemInserirRequest request, CancellationToken cancellationToken)
        {
            var response = new ViagemInserirResponse();
            try
            {
                DateTime _dataAtual = DateTime.Now;

                var viagem = _mapper.Map<Domain.Entities.Viagem>(request);

                viagem.DataViagem = _dataAtual;               
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
                response.AddNotification("Erro", "Ocorreu uma exceção na sua solicitação");
                return response;
            }

           
        }
    }
}
