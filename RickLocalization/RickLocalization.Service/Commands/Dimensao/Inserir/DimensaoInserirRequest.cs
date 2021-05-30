using MediatR;
using RickLocalization.Domain.Interfaces.Validations;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Commands.Dimensao.Inserir
{
   public class DimensaoInserirRequest : Validatable, IRequest<DimensaoInserirResponse>
    {
        public string Descricao { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Descricao))
                AddNotification("Descricao", "A Descricao é obrigatório.", ETypeNotification.Error);
        }
    }
}
