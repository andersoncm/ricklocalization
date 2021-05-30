import { ViagemService } from './../service/viagem.service';
import { Component, OnInit } from '@angular/core';
import { RickDetalhe } from '../model/rick-detalhes.model';
import { ActivatedRoute, Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { ModalInserirViagemComponent } from '../modal-inserir-viagem/modal-inserir-viagem.component';
import { ErroHandlerService } from 'src/app/shared/erro-handler.service';

@Component({
  selector: 'app-detalhe-rick',
  templateUrl: './detalhe-rick.component.html',
  styleUrls: ['./detalhe-rick.component.css']
})
export class DetalheRickComponent implements OnInit {
  rick: RickDetalhe;
  id;
  private dialogConfig;

  constructor(
    private viagemService: ViagemService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    public dialog: MatDialog,
    private errorService : ErroHandlerService) { }

  async ngOnInit() {

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: { }
    }

    this.id = await this.activatedRoute.snapshot.params.id;
    if (this.id)
      this.obterDetalhesRick(this.id);
    else{
      this.router.navigate([`viagem/pesquisar`]);
    }

  }

  obterDetalhesRick(rickId: number) {
    this.viagemService.obterDetalhesRick(rickId).subscribe(res => {
      if (res)
        this.rick = res;
    }, error => {
      this.errorService.dialogConfig = { ...this.dialogConfig };
      this.errorService.handleError(error);
    })

  }

  redirecionarHistoricoViagem(rickId : number){
    this.router.navigate([`viagem/historicoNavegacao/${rickId}`]);

   }
   abrirModal(){
    const dialogRef = this.dialog.open(ModalInserirViagemComponent, {
      height: '400px',
      width: '400px',
      data: {rick : this.rick}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }




}
