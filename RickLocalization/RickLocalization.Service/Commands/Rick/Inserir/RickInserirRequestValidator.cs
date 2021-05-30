using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Commands.Rick.Inserir
{
    public class RickInserirRequestValidator : AbstractValidator<RickInserirRequest>
    {
        public RickInserirRequestValidator()
        {
            RuleFor(p => p.Nome)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50)
            .MinimumLength(1);
           

            RuleFor(p => p.Foto)                
               .NotNull()
                .NotEmpty();
               

            RuleFor(p => p.DimensaoId)
               .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                ;


        }
    }
}
