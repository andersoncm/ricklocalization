using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Service.Commands.Dimensao.Inserir;
using RickLocalization.Service.Queries.Dimensao.ObterTodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimensaoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DimensaoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("obterTodos")]
        public async Task<DimensaoObterTodosResponse> ObterTodos([FromQuery] DimensaoObterTodosRequest request)
        {
            var result = await _mediator.Send(request);
            return result;
        }


        [HttpPost]
        [Route("inserir")]

        public async Task<DimensaoInserirResponse> Inserir([FromBody] DimensaoInserirRequest request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}
