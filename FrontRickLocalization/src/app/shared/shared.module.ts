import { AngularMaterialModule } from 'src/app/angular-material/material.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DialogoSucessoComponent } from './dialogo-sucesso/dialogo-sucesso.component';
import { DialogoErroComponent } from './dialogo-erro/dialogo-erro.component';



@NgModule({
  declarations: [DialogoSucessoComponent, DialogoErroComponent],
  imports: [
    CommonModule,
    AngularMaterialModule
  ],
  exports : [
    AngularMaterialModule,
    DialogoSucessoComponent,
    DialogoErroComponent
  ]
})
export class SharedModule { }
