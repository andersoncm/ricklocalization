using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Entities
{
   public class Dimensao
    {

        public Dimensao()
        {
            Rickis = new List<Rick>();
            Viagens = new List<Viagem>();
        }
        public int DimensaoId { get; set; }
        public string Descricao { get; set; }
       
        public bool Ativo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string NaturezaOperacao { get; set; }
        public DateTime? DataOperacao { get; set; }
        public virtual List<Rick> Rickis { get; set; }
        public virtual List<Viagem> Viagens { get; set; }
    }
}
