using MediatR;
using RickLocalization.Repository.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;

namespace RickLocalization.Service.Commands.Dimensao.Inserir
{
    public class DimensaoInserirHandler : IRequestHandler<DimensaoInserirRequest, DimensaoInserirResponse>
    {

        private readonly RickLocalizationContext _context;
        IMapper _mapper;

        public DimensaoInserirHandler(RickLocalizationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DimensaoInserirResponse> Handle(DimensaoInserirRequest request, CancellationToken cancellationToken)
        {
            var response = new DimensaoInserirResponse();

            try
            {
               
                if (ValidarInserirDimensao(request, response))
                {
                    DateTime _dataAtual = DateTime.Now;

                    var dimensao = _mapper.Map<RickLocalization.Domain.Entities.Dimensao>(request);

                  
                    dimensao.Ativo = true;
                    dimensao.DataInclusao = _dataAtual;
                    dimensao.DataOperacao = _dataAtual;
                    dimensao.NaturezaOperacao = "I";

                    _context.Dimensoes.Add(dimensao);

                    await _context.SaveChangesAsync();

                    return response;

                }

                return response;

            }
            catch (Exception)
            {
                response.AddNotification("Erro", "Ocorreu uma exceção na sua solicitação");
            }

            return response;



        }


        private bool ValidarInserirDimensao(DimensaoInserirRequest request, DimensaoInserirResponse response)
        {
            return ValidarDuplicado(request,response);
        }


        private bool ValidarDuplicado(DimensaoInserirRequest request, DimensaoInserirResponse response)
        {

            bool validaSeExisteDimensaoDescricaoIgual = _context.Dimensoes.Any(a=> a.Descricao == request.Descricao && a.Ativo);

            if (validaSeExisteDimensaoDescricaoIgual)
            {
                response.AddNotification("Duplicidade", "Já existe uma dimensão com esta descricao cadastrado");
                return false;
            }


            return true;
        }

    }
}
