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



namespace RickLocalization.Service.Commands.Rick.Inserir
{
    public class RickInserirHandler : IRequestHandler<RickInserirRequest, RickInserirResponse>
    {
        private readonly RickLocalizationContext _context;

        public RickInserirHandler(RickLocalizationContext context)
        {
            _context = context;
        }
        public async Task<RickInserirResponse> Handle(RickInserirRequest request, CancellationToken cancellationToken)
        {           

            var response = new RickInserirResponse();
            try
            {
                DateTime _dataAtual = DateTime.Now;

                var rick = new Domain.Entities.Rick();

                rick.Foto = request.Foto;
                rick.DimensaoId = request.DimensaoId;
                rick.Nome = request.Nome;
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
                response.AddNotification("Erro", "Ocorreu uma excessao na sua solicitação");
            }
            return response;

        }
    }
}
