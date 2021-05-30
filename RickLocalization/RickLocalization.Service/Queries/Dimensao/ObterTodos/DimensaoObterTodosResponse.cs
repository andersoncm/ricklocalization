using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Dimensao.ObterTodos
{
    public class DimensaoObterTodosResponse : Notifiable
    {
        public DimensaoObterTodosResponse()
        {
            List<ItemDimensao> lista = new List<ItemDimensao>();
        }

        public List<ItemDimensao> lista { get; set; }
    }

    public class ItemDimensao
    {
        public int DimensaoId { get; set; }
        public string Descricao { get; set; }
    }
}
