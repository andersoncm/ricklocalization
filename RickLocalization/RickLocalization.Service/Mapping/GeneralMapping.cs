using AutoMapper;
using RickLocalization.Domain.Entities;
using RickLocalization.Service.Commands.Dimensao.Inserir;
using RickLocalization.Service.Commands.Rick.Inserir;
using RickLocalization.Service.Commands.Viagem.Inserir;
using RickLocalization.Service.Queries.Dimensao.ObterTodos;
using RickLocalization.Service.Queries.Rick.ObterDetalhesPorId;
using RickLocalization.Service.Queries.Rick.ObterTodos;
using RickLocalization.Service.Queries.Viagem;
using RickLocalization.Service.Queries.Viagem.ObterHistoricoViagemPorRickId;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
           

            CreateMap<ViagemObterHistoricoViagemPorRickIdItemDapper, ViagemObterHistoricoViagemPorRickIdResponseItem>()
               .ReverseMap();

            CreateMap<RickObterTodosResponseItemDapper, RickObterTodosResponseItem>()
              .ReverseMap();

            CreateMap<RickObterDetalhesPorIdItemDapper, RickObterDetalhesPorIdResponse>()
            .ReverseMap();

            CreateMap<Dimensao, ItemDimensao>()
           .ReverseMap();
           

            CreateMap<DimensaoInserirRequest,Dimensao>();
            CreateMap<RickInserirRequest, Rick>();
            CreateMap<ViagemInserirRequest, Viagem>();

        }
    }
}
