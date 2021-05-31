import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PaginaErroServidorComponent } from './pagina-erro-servidor.component';

describe('ErroServidorComponent', () => {
  let component: PaginaErroServidorComponent;
  let fixture: ComponentFixture<PaginaErroServidorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PaginaErroServidorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PaginaErroServidorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
