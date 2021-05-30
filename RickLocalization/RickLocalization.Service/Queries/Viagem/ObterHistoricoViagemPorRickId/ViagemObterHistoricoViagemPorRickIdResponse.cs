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
            List<ViagemObterHistoricoViagemPorRickIdResponseItem> lista = new List<ViagemObterHistoricoViagemPorRickIdResponseItem>();
        }

        public List<ViagemObterHistoricoViagemPorRickIdResponseItem> lista { get; set; }
    }

    public class ViagemObterHistoricoViagemPorRickIdResponseItem
    {
        public string DimensaoDescricao { get; set; }
        public DateTime DataViagem { get; set; }
        public string Motivo { get; set; }
    }



}
