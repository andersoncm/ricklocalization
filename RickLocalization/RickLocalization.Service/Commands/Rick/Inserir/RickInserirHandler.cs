using MediatR;
using Microsoft.EntityFrameworkCore;
using RickLocalization.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RickLocalization.Domain.Entities;
using AutoMapper;

namespace RickLocalization.Service.Commands.Rick.Inserir
{
    public class RickInserirHandler : IRequestHandler<RickInserirRequest, RickInserirResponse>
    {
        private readonly RickLocalizationContext _context;
        IMapper _mapper;

        public RickInserirHandler(RickLocalizationContext context, IMapper mapper)
        {
            _context = context;
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

                _context.Ricks.Add(rick);

                await _context.SaveChangesAsync();


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
