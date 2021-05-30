using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Service.Commands.Viagem.Inserir;
using RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ViagemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<ViagemInserirResponse> Inserir([FromBody] ViagemInserirRequest request)
        {
            var result = await _mediator.Send(request);
            return result;
        }


        [HttpGet]
        [Route("obterhistoricoviagemporrickid")]
        public async Task<ViagemObterHistoricoViagemPorRickIdResponse> ObterHistoricoViagemPorRickId([FromQuery] ViagemObterHistoricoViagemPorRickIdRequest request)
        {
            var result = await _mediator.Send(request);
            return result;
        }

    }
}
