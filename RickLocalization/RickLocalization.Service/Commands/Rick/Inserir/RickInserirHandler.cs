using AutoMapper;
using MediatR;
using RickLocalization.Service.Repository;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Commands.Rick.Inserir
{
    public class RickInserirHandler : IRequestHandler<RickInserirRequest, RickInserirResponse>
    {
        
        IRickRepository _repository;
        IMapper _mapper;

        public RickInserirHandler(IRickRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<RickInserirResponse> Handle(RickInserirRequest request, CancellationToken cancellationToken)
        {           

            var response = new RickInserirResponse();
            try
            {
                DateTime _dataAtual = DateTime.Now;

                var rick = _mapper.Map<Domain.Entities.Rick>(request);
             
                rick.Ativo = true;
                rick.DataInclusao = _dataAtual;
                rick.DataOperacao = _dataAtual;
                rick.NaturezaOperacao = "I";

               await _repository.Add(rick);

                return response;
            }
            catch (Exception)
            {
                response.AddNotification("Erro", "Ocorreu uma exceção na sua solicitação");
            }
            return response;

        }
    }
}
