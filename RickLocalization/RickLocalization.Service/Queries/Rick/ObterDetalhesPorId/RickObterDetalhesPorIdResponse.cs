using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Rick.ObterDetalhesPorId
{
   public class RickObterDetalhesPorIdResponse : Notifiable
    {

        public int RickId { get; set; }
        public string Nome { get; set; }
        public string DimensaoOrigem { get; set; }

       
    }
}
