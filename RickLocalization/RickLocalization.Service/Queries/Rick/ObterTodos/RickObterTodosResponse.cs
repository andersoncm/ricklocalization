using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Rick.ObterTodos
{
    public class RickObterTodosResponse : Notifiable
    {
        public RickObterTodosResponse()
        {
            List<RickObterTodosResponseItemDapper> lista = new List<RickObterTodosResponseItemDapper>();
        }

        public List<RickObterTodosResponseItemDapper> lista { get; set; }
    }

    public class ItemRick
    {
        public int RickId { get; set; }
        public string Foto { get; set; }
    }

    public class RickObterTodosResponseItemDapper
    {
        public int RickId { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }

    }
}
