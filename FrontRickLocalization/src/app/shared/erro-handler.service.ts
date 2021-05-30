import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { DialogoErroComponent } from './dialogo-erro/dialogo-erro.component';

@Injectable({
  providedIn: 'root'
})
export class ErroHandlerService {
  public errorMessage: string = '';
  public listErrorMessage: string[] = [];
  public dialogConfig;
  constructor(private router: Router, private dialog: MatDialog) { }


  public handleError = (error: any) => {
    if (error.status === 500) {
      this.handle500Error(error);
    }
    else if (error.status === 404) {
      this.handle404Error(error)
    }
    else {
      this.handleOtherError(error);
    }
  }

  private handle500Error = (error: any) => {
    this.createErrorMessage(error);
    this.router.navigate(['/500']);
  }

  private handle404Error = (error: any) => {
    this.createErrorMessage(error);
    this.router.navigate(['/404']);
  }

  private handleOtherError = (error: any) => {
    this.createErrorMessage(error);
    this.dialogConfig.data = { 'errorMessage': this.listErrorMessage };
    this.dialog.open(DialogoErroComponent, this.dialogConfig);
  }

  private createErrorMessage(error: any) {
    this.listErrorMessage = [];

    if (typeof error === 'string') {
      this.listErrorMessage.push(error)
    } else if (typeof error.error === 'string') {
      this.listErrorMessage.push(error)
    } else if (error.error && error.error.notifications && error.error.notifications.length > 0) {
      error.error.notifications.forEach(element => {
        this.listErrorMessage.push(element.reason);
      });

    }else{
      this.listErrorMessage.push("Ocorreu um erro ao processar sua solicitação");
    }







    //this.errorMessage = error.error ? error.error : error.statusText;


    /*error.notifications.forEach(element => {
      console.log(element);
    });*/


  }
}
