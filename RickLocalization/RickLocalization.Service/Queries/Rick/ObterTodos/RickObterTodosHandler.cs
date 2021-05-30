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

        public RickInserirHandler( IRickService rickService)
        {
            

            _rickService = rickService;
        }
        public async Task<RickObterTodosResponse> Handle(RickObterTodosRequest request, CancellationToken cancellationToken)
        {

            var response = new RickObterTodosResponse();
            var query = await _rickService.ObterTodos();

          

            response.lista = query;

            return response;

        }
    }
}
