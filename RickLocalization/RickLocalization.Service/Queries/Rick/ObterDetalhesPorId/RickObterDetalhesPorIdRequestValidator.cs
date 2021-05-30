using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Rick.ObterDetalhesPorId
{
  public class RickObterDetalhesPorIdRequestValidator : AbstractValidator<RickObterDetalhesPorIdRequest>
    {
        public RickObterDetalhesPorIdRequestValidator()
        {
            RuleFor(p => p.RickId)
              .NotNull()
               .NotEmpty()
               .GreaterThan(0)
               ;
        }
    }
}
