using MediatR;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId
{
   public class ViagemObterHistoricoViagemPorRickIdRequest : Validatable, IRequest<ViagemObterHistoricoViagemPorRickIdResponse>
    {
        public int RickId { get; set; }

        public override void Validate()
        {
            if (RickId <= 0)
                AddNotification("RickId", "O campo RickId é obrigatório", ETypeNotification.Error);
        }
    }
}
