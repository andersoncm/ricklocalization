
import { ViagemService } from './../service/viagem.service';
import { ChangeDetectorRef, Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Observable } from 'rxjs';
import { CardRick } from '../model/card-rick.model';
import { DomSanitizer } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { MatSort } from '@angular/material/sort';
import { ErroHandlerService } from 'src/app/shared/erro-handler.service';





@Component({
  selector: 'app-pesquisar-viagem-por-rick',
  templateUrl: './pesquisar-viagem-por-rick.component.html',
  styleUrls: ['./pesquisar-viagem-por-rick.component.css']
})
export class PesquisarViagemPorRickComponent implements OnInit, OnDestroy  {
  private dialogConfig;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  obs: Observable<any>;
  dataSource: MatTableDataSource<CardRick> = new MatTableDataSource<CardRick>();
  listaRick : CardRick[];

  constructor(
    private changeDetectorRef: ChangeDetectorRef,
    private viagemService : ViagemService,
    private sanitizer: DomSanitizer,
    private router : Router,
    private errorService : ErroHandlerService
   ) { }

  ngOnInit(): void {
    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: { }
    }

    this.changeDetectorRef.detectChanges();

    this.obterRickParaViagem();
  }



  ngOnDestroy() {
    if (this.dataSource) {
      this.dataSource.disconnect();
    }
  }

  obterRickParaViagem(){
   this.viagemService.obterRickParaViagem().subscribe(res=> {

    res.forEach(element => {
      element.picture = this.sanitizer.bypassSecurityTrustResourceUrl(element.foto);
    });

    this.listaRick = res;

    this.dataSource = new MatTableDataSource<CardRick>(this.listaRick);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    this.obs = this.dataSource.connect();


   },error => {
    this.errorService.dialogConfig = { ...this.dialogConfig };
    this.errorService.handleError(error);
   })

  }

  aplicarFiltro(filterValue: string) {
    filterValue = filterValue.trim();
    filterValue = filterValue.toLowerCase();
    this.dataSource.filter = filterValue;
  }

  redirecionar(card : CardRick){
   this.router.navigate(['viagem/detalheRick/'+card.rickId]);

  }





}
