using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RickLocalization.Api.Controllers;
using RickLocalization.Service.GenericResponse;
using RickLocalization.Service.Queries.Rick.ObterTodos;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace RickLocalization.Test
{
   public class RickControllerUnitTest
    {
        private Mock<IMediator> Mediator;

        public RickControllerUnitTest()
        {
            Mediator = new Mock<IMediator>();
        }

        
        [Fact]
        public void Get_ObterTodos_ReturnsOkResult2()
        {
            var rickObterTodosRequest = new RickObterTodosRequest();

            Mediator.Setup(x => x.Send(It.IsAny<RickObterTodosRequest>(), new CancellationToken())).
                ReturnsAsync(new RickObterTodosResponse());

            var rickController = new RickController(Mediator.Object);

            var teste = new Mock<RickObterTodosRequest>().Object;

            //Action
            var result = rickController.ObterTodos(teste);

           // var dados = ((ObjectResult)result.Result).Value;

            //Assert
            //Assert.IsType<OkObjectResult>(result);
           
        }
    }
}
