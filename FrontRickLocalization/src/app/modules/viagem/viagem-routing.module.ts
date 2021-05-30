import { HistoricoNavegacaoComponent } from './historico-navegacao/historico-navegacao.component';
import { DetalheRickComponent } from './detalhe-rick/detalhe-rick.component';
import { PesquisarViagemPorRickComponent } from './pesquisar-viagem-por-rick/pesquisar-viagem-por-rick.component';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [

  {path: 'pesquisaPorRick', component:PesquisarViagemPorRickComponent},
  {path: 'detalheRick/:id', component:DetalheRickComponent},
  {path: 'historicoNavegacao/:id', component:HistoricoNavegacaoComponent},
  {path : '' , redirectTo :'pesquisaPorRick', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ViagemRoutingModule { }
