using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Commands.Dimensao.Inserir
{
    public class DimensaoInserirRequestValidator : AbstractValidator<DimensaoInserirRequest>
    {
        public DimensaoInserirRequestValidator()
        {
            RuleFor(p => p.Descricao)
            .NotNull()
            .NotEmpty();
            



        }
    }
}
