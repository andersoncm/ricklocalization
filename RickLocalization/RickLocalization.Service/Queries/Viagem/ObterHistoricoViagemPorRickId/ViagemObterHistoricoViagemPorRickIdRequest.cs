using MediatR;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId
{
   public class ViagemObterHistoricoViagemPorRickIdRequest :  IRequest<ViagemObterHistoricoViagemPorRickIdResponse>
    {
        public int RickId { get; set; }

       
    }
}
