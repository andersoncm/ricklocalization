using MediatR;
using RickLocalization.Domain.Interfaces.Validations;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Commands.Rick.Inserir
{
    public class RickInserirRequest : Validatable, IRequest<RickInserirResponse>
    {
        public string Foto { get; set; }
        public int DimensaoId { get; set; }
        public string Nome { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AddNotification("Nome", "O Nome é obrigatório.", ETypeNotification.Error);

            if (string.IsNullOrEmpty(Foto))
                AddNotification("Foto", "A Foto é obrigatório.", ETypeNotification.Error);

            if (DimensaoId <= 0)
                AddNotification("DimensaoId", "A DimensaoId é obrigatório.", ETypeNotification.Error);
        }
    }
}
