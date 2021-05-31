import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { ErroHandlerService } from 'src/app/shared/erro-handler.service';
import { RickHistoricoViagem } from '../model/rick-historico-viagem.model';
import { ViagemService } from '../service/viagem.service';

@Component({
  selector: 'app-historico-navegacao',
  templateUrl: './historico-navegacao.component.html',
  styleUrls: ['./historico-navegacao.component.css']
})
export class HistoricoNavegacaoComponent implements OnInit, AfterViewInit {
  private dialogConfig;
  id;
  rickHistoricoViagem: RickHistoricoViagem[];

  displayedColumns = ['dataViagem', 'dimensaoDescricao', 'motivo'];
  dataSource: MatTableDataSource<RickHistoricoViagem> = new MatTableDataSource<RickHistoricoViagem>();

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private viagemService: ViagemService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private errorService : ErroHandlerService) {

  }

  async ngOnInit() {

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: { }
    }

    this.id = await this.activatedRoute.snapshot.params.id;
    if (this.id)
      this.obterHistoricoNavegacao(this.id);
    else {
      this.router.navigate([`viagem/pesquisar`]);
    }

  }

  obterHistoricoNavegacao(rickId: number) {
    this.viagemService.obterHistoricoNavegacao(rickId).subscribe(res => {
      if (res) {
        this.rickHistoricoViagem = res;
        this.dataSource = new MatTableDataSource(this.rickHistoricoViagem);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      }

    }, error => {
      this.errorService.dialogConfig = { ...this.dialogConfig };
      this.errorService.handleError(error);
    })

  }

  /**
   * Set the paginator and sort after the view init since this component will
   * be able to query its view for the initialized paginator and sort.
   */
  ngAfterViewInit() {
   // this.dataSource.paginator = this.paginator;
   // this.dataSource.sort = this.sort;
  }

  aplicarFiltro(filterValue: string) {
    filterValue = filterValue.trim();
    filterValue = filterValue.toLowerCase();
    this.dataSource.filter = filterValue;
  }


  voltarPagina(){
     this.router.navigate([`viagem/detalheRick/${this.id}`]);
  }

}

