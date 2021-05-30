using MediatR;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Rick.ObterDetalhesPorId
{
   public class RickObterDetalhesPorIdRequest :  IRequest<RickObterDetalhesPorIdResponse>
    {
        public int RickId { get; set; }

       
    }
}
