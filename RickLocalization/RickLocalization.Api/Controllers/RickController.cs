using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Service.Commands.Rick.Inserir;
using RickLocalization.Service.Queries.Rick.ObterDetalhesPorId;
using RickLocalization.Service.Queries.Rick.ObterTodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RickController : ControllerBase
    {

        private readonly IMediator _mediator;

        public RickController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("obterTodos")]

        public async Task<RickObterTodosResponse> ObterTodos([FromQuery] RickObterTodosRequest request)
        {
            var result = await _mediator.Send(request);
            return result;
        }


        [HttpPost]
        [Route("inserir")]

        public async Task<RickInserirResponse> Inserir([FromBody] RickInserirRequest request)
        {
            var result = await _mediator.Send(request);
            return result;
        }

        [HttpGet]
        [Route("obterdetalhesporid")]

        public async Task<RickObterDetalhesPorIdResponse> ObterDetalhesPorId([FromQuery] RickObterDetalhesPorIdRequest request)
        {
            var result = await _mediator.Send(request);
            return result;
        }



    }
}
