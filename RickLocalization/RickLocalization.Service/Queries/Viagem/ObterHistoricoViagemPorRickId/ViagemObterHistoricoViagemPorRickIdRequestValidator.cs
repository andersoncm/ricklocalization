using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId
{
    public class ViagemObterHistoricoViagemPorRickIdRequestValidator : AbstractValidator<ViagemObterHistoricoViagemPorRickIdRequest>
    {
        public ViagemObterHistoricoViagemPorRickIdRequestValidator()
        {
            RuleFor(p => p.RickId)
             .NotNull()
              .NotEmpty()
              .GreaterThan(0)
              ;

        }
    }
}
