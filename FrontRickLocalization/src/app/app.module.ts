import { AngularMaterialModule } from 'src/app/angular-material/material.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { PaginaoNaoEncontradaComponent } from './paginao-nao-encontrada/paginao-nao-encontrada.component';

import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { HeaderComponent } from './_layout/header/header.component';
import { FooterComponent } from './_layout/footer/footer.component';
import { LayoutComponent } from './_layout/layout/layout.component';
import { SidenavListComponent } from './_layout/sidenav-list/sidenav-list.component';
import { NgxSpinnerModule } from 'ngx-spinner';
import { HttpLoadingSpinnerInterceptor } from './interceptor/http-loading-spinner.interceptor';


import { HomeComponent } from './home/home.component';
import { ErroServidorComponent } from './pagina-erro-servidor/erro-servidor.component';

@NgModule({
  declarations: [
    AppComponent,
    PaginaoNaoEncontradaComponent,
    HeaderComponent,
    FooterComponent,
    LayoutComponent,
    SidenavListComponent,
    ErroServidorComponent,
    HomeComponent,

  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule  ,
   AngularMaterialModule,
    AppRoutingModule,
    NgxSpinnerModule



  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpLoadingSpinnerInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
