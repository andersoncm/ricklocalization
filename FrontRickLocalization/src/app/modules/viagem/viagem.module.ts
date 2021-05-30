import { SharedModule } from './../../shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ViagemRoutingModule } from './viagem-routing.module';

import { AngularMaterialModule } from 'src/app/angular-material/material.module';
import { PesquisarViagemPorRickComponent } from './pesquisar-viagem-por-rick/pesquisar-viagem-por-rick.component';
import { HttpClientModule } from '@angular/common/http';
import { DetalheRickComponent } from './detalhe-rick/detalhe-rick.component';
import { HistoricoNavegacaoComponent } from './historico-navegacao/historico-navegacao.component';
import { ModalInserirViagemComponent } from './modal-inserir-viagem/modal-inserir-viagem.component';


@NgModule({
  declarations: [

    PesquisarViagemPorRickComponent,
     DetalheRickComponent,
     HistoricoNavegacaoComponent,
    ModalInserirViagemComponent
  ],
  imports: [
    CommonModule,
    ViagemRoutingModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ]
})
export class ViagemModule { }
