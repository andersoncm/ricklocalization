using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RickLocalization.Repository.EF;
using RickLocalization.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Service.Queries.Rick.ObterTodos
{
    public class RickInserirHandler : IRequestHandler<RickObterTodosRequest, RickObterTodosResponse>
    {      

        private readonly IRickService _rickService;
        IMapper _mapper;

        public RickInserirHandler( IRickService rickService, IMapper mapper)
        {           

            _rickService = rickService;
            _mapper = mapper;
        }
        public async Task<RickObterTodosResponse> Handle(RickObterTodosRequest request, CancellationToken cancellationToken)
        {

            var response = new RickObterTodosResponse();
            try
            {
                var query = await _rickService.ObterTodos();

                var resultado = _mapper.Map<List<RickObterTodosResponseItem>>(query);

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
