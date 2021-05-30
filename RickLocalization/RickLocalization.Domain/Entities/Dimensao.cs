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
        }
        public int DimensaoId { get; set; }
        public string Descricao { get; set; }
       
        public bool Ativo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string NaturezaOperacao { get; set; }
        public DateTime? DataOperacao { get; set; }
        public List<Rick> Rickis { get; set; }
    }
}
