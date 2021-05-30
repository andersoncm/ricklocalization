using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RickLocalization.Domain.Notification;
using RickLocalization.Service.GenericResponse;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RickLocalization.Api.Filters
{
    public class GenericResponseAsyncActionFilter : IAsyncActionFilter
    {
              

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            
            var response = new Response();

            if (!context.ModelState.IsValid)
            {  
                var errors = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(e => e.Key, e => e.Value.Errors.Select(e => new 
                    {
                        e.ErrorMessage
                    })).ToArray();

                var n = new Notifiable();
                foreach (var item in errors)
                {                   
                    n.AddNotification(item.Key, string.Join("," ,item.Value.Select(a=> a.ErrorMessage)), ETypeNotification.Error);
                }

                response.AddNotifications(n.GetNotifications());
                response.Title = "Ocorreu um ou mais erros de validação.";
                response.Status = (int)HttpStatusCode.BadRequest;
                context.Result = new BadRequestObjectResult(response);
                return;
            }


            var resultContext = await next();

            if (resultContext.Result != null)
            {
                var dados = ((ObjectResult)resultContext.Result).Value;


                if (dados is Notifiable notifiableResult)
                {
                    if (!notifiableResult.Valid())
                    {
                       
                        response.Title = "Ocorreu um ou mais erros de validação.";
                        response.Status = (int)HttpStatusCode.BadRequest;
                        response.AddNotifications(notifiableResult);

                        resultContext.Result = new BadRequestObjectResult(response) { ContentTypes = { "application/problem+json" } };

                        return;
                    }

                    response.Title = "Sucesso!";
                    response.Status = (int)HttpStatusCode.OK;
                    response.Data = dados;
                    response.AddNotifications(notifiableResult);
                    resultContext.Result = new OkObjectResult(response);
                    return;
                }
            }
        }

    }
}
