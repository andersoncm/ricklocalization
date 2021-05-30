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
            List<RickObterTodosResponseItem> lista = new List<RickObterTodosResponseItem>();
        }

        public List<RickObterTodosResponseItem> lista { get; set; }
    }


    public class RickObterTodosResponseItem
    {
        public int RickId { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
    }

   

    
}
