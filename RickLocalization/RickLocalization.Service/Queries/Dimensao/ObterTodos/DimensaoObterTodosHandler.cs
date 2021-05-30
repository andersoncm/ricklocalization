using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RickLocalization.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Dimensao.ObterTodos
{
    public class DimensaoObterTodosHandler : IRequestHandler<DimensaoObterTodosRequest, DimensaoObterTodosResponse>
    {
        private readonly RickLocalizationContext _context;
        IMapper _mapper;

        public DimensaoObterTodosHandler(RickLocalizationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<DimensaoObterTodosResponse> Handle(DimensaoObterTodosRequest request, CancellationToken cancellationToken)
        {
            var response = new DimensaoObterTodosResponse();

            try
            {
                var query = await _context.Dimensoes.AsNoTracking().Where(a => a.Ativo).ToListAsync();

                var resultado = _mapper.Map<List<ItemDimensao>>(query);

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
