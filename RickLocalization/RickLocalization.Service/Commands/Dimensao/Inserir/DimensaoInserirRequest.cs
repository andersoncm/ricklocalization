using MediatR;
using RickLocalization.Domain.Interfaces.Validations;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Commands.Dimensao.Inserir
{
   public class DimensaoInserirRequest : IRequest<DimensaoInserirResponse>
    {
        public string Descricao { get; set; }

       
    }
}
