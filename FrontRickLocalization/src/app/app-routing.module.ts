import { HomeComponent } from './home/home.component';
import { PaginaoNaoEncontradaComponent } from './paginao-nao-encontrada/paginao-nao-encontrada.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ErroServidorComponent } from './erro-servidor/erro-servidor.component';


const routes: Routes = [
  {
    path: 'home' , component:HomeComponent
  },
  {
    path: 'rick', loadChildren: () => import('./modules/rick/rick.module').then(m => m.RickModule)
  },
  {
    path: 'dimensao', loadChildren: () => import('./modules/dimensao/dimensao.module').then(m => m.DimensaoModule)
  },
  {
    path: 'viagem', loadChildren: () => import('./modules/viagem/viagem.module').then(m => m.ViagemModule)
  },
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },

  { path: '404', component: PaginaoNaoEncontradaComponent},
  { path: '500', component: ErroServidorComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', redirectTo: '/404', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
