using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Entities
{
   public class Rick
    {
        public int RickId { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public int DimensaoId { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string NaturezaOperacao { get; set; }      
        public DateTime? DataOperacao { get; set; }

        public virtual Dimensao Dimensao { get; set; }


    }
}
