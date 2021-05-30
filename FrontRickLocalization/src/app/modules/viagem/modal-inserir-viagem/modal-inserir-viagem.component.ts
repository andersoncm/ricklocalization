import { DialogoSucessoComponent } from './../../../shared/dialogo-sucesso/dialogo-sucesso.component';
import { ViagemService } from './../service/viagem.service';
import { RickDetalhe } from './../model/rick-detalhes.model';
import { Component, ErrorHandler, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Dimensao } from '../model/dimensao.model';
import {
  MatSnackBar,

} from '@angular/material/snack-bar';
import { ErroHandlerService } from 'src/app/shared/erro-handler.service';
import { DialogoErroComponent } from 'src/app/shared/dialogo-erro/dialogo-erro.component';

@Component({
  selector: 'app-modal-inserir-viagem',
  templateUrl: './modal-inserir-viagem.component.html',
  styleUrls: ['./modal-inserir-viagem.component.css']
})
export class ModalInserirViagemComponent implements OnInit {
   viagemForm: FormGroup;
   listaDimensoes : Dimensao[];

   private dialogConfig;


  constructor(
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private viagemService : ViagemService,
    public dialogRef: MatDialogRef<ModalInserirViagemComponent>,
    private _snackBar: MatSnackBar,
    private dialog: MatDialog,
    private errorService : ErroHandlerService
  ) { }

  ngOnInit(): void {
    this.criarFormularioInserir();

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: { }
    }

    this.viagemForm.patchValue({rickId : this.data.rick.rickId});
    this.obterTodasDimensoes();

  }

  criarFormularioInserir() {
    this.viagemForm = this.formBuilder.group({
      rickId: [null,Validators.required],
      dimensaoId: [null, Validators.required],
      motivo: [null]
    });
  }

  get f() {
    return this.viagemForm.controls;
  }

  obterTodasDimensoes() {
    this.viagemService.obterTodasDimensoes().subscribe(res => {
      if (res){
        this.listaDimensoes = res;
      }

    }, error => {
      this.errorService.dialogConfig = { ...this.dialogConfig };
      this.errorService.handleError(error);
    })

  }


  salvar() {
    if (!this.viagemForm.valid) {
      return;
    }


    const formData = {
      rickId: this.viagemForm.value.rickId,
      dimensaoId : this.viagemForm.value.dimensaoId,
      motivo: this.viagemForm.value.motivo
    };

    this.viagemService.salvarViagem(formData).subscribe((res : any )=> {
       if(res){
        let dialogRef = this.dialog.open(DialogoSucessoComponent, this.dialogConfig);
        dialogRef.afterClosed()
          .subscribe(result => {
            this.dialogRef.close();
          });


       }else{

        this.dialogConfig.data = { 'errorMessage': "Ocorreu um erro ao salvar"};
        let dialogRef = this.dialog.open(DialogoErroComponent, this.dialogConfig);
        dialogRef.afterClosed()
          .subscribe(result => {
            this.dialogRef.close();
          });

       }

    }, error => {
      this.errorService.dialogConfig = { ...this.dialogConfig };
    this.errorService.handleError(error);
    })




  }


openSnackBar(message) {
    this._snackBar.open(message, 'X');
  }







}
