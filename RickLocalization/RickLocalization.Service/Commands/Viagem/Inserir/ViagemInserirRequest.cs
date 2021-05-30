using MediatR;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Commands.Viagem.Inserir
{
   public class ViagemInserirRequest : Validatable, IRequest<ViagemInserirResponse>
    {
        public int RickId { get; set; }
        public int DimensaoId { get; set; }
        public string Motivo { get; set; }

        public override void Validate()
        {
            if (RickId <= 0)
                AddNotification("RickId", "O RickId é obrigatório.", ETypeNotification.Error);

            if (DimensaoId <= 0)
                AddNotification("DimensaoId", "A DimensaoId é obrigatório.", ETypeNotification.Error);
        }
    }
}
