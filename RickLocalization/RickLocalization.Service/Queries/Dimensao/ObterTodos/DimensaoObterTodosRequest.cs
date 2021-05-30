using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Queries.Dimensao.ObterTodos
{
    public class DimensaoObterTodosRequest : Validatable, IRequest<DimensaoObterTodosResponse>
    {
        public override void Validate()
        {
           
        }
    }
}
