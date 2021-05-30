using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Entities
{
   public class Viagem
    {

        public int ViagemId { get; set; }
        public int DimensaoId { get; set; }
        public int RickId { get; set; }
        public string Motivo { get; set; }
        public DateTime DataViagem { get; set; }

        public bool Ativo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string NaturezaOperacao { get; set; }
        public DateTime? DataOperacao { get; set; }

        public virtual Dimensao Dimensao { get; set; }
        public virtual Rick Rick { get; set; }


    }
}
