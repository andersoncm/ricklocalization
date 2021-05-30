import { environment } from './../../../../environments/environment';
import { HttpClient, HttpClientModule, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { delay, first, map } from 'rxjs/operators';
import { of, Observable } from 'rxjs';
import {  CardRick } from '../model/card-rick.model';
import { RickDetalhe } from '../model/rick-detalhes.model';
import { RickHistoricoViagem } from '../model/rick-historico-viagem.model';
import { Dimensao } from '../model/dimensao.model';

@Injectable({
  providedIn: 'root'
})
export class ViagemService {

  constructor(private http: HttpClient) { }

  obterRickParaViagem() : Observable<CardRick[]> {
    return this.http.get<CardRick[]>(`${environment.apiUrl}Rick/obterTodos`).pipe(map((res :any) => { return res.data.lista }),first());

   // return of(DATA).pipe(delay(1000));
  }

  obterDetalhesRick(rickId: number) :Observable<RickDetalhe>{
    const params = new HttpParams().set('RickId', rickId.toString());
    return this.http.get<RickDetalhe>(`${environment.apiUrl}Rick/obterdetalhesporid`,{params}).pipe(map((res :any) => { return res.data}),first());
  }

  obterHistoricoNavegacao(rickId: number) :Observable<RickHistoricoViagem[]>{
    const params = new HttpParams().set('RickId', rickId.toString());
    return this.http.get<RickHistoricoViagem[]>(`${environment.apiUrl}Viagem/obterhistoricoviagemporrickid`,{params}).pipe(map((res :any) => { return res.data.lista }),first());
  }
  obterTodasDimensoes() : Observable<Dimensao[]>{
    return this.http.get<Dimensao[]>(`${environment.apiUrl}Dimensao/obtertodos`).pipe(map((res :any) => { return res.data.lista }),first());
  }

  salvarViagem(form){

    return this.http.post(`${environment.apiUrl}Viagem/inserir`,form).pipe(first());
  }




}







