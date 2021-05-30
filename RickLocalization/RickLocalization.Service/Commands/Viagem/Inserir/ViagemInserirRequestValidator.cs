using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Commands.Viagem.Inserir
{
    public class ViagemInserirRequestValidator : AbstractValidator<ViagemInserirRequest>
    {
        public ViagemInserirRequestValidator()
        {
            RuleFor(x => x.DimensaoId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);


            RuleFor(x => x.RickId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
