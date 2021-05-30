using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId
{
   public class ViagemObterHistoricoViagemPorRickIdResponse : Notifiable
    {

        public ViagemObterHistoricoViagemPorRickIdResponse()
        {
            List<ViagemObterHistoricoViagemPorRickIdItemDapper> lista = new List<ViagemObterHistoricoViagemPorRickIdItemDapper>();
        }

        public List<ViagemObterHistoricoViagemPorRickIdItemDapper> lista { get; set; }
    }

    public class ViagemObterHistoricoViagemPorRickIdItemDapper
    {
        public string DimensaoDescricao { get; set; }
        public DateTime DataViagem { get; set; }
        public string Motivo { get; set; }
    }
}
