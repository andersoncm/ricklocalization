import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PaginaoNaoEncontradaComponent } from './paginao-nao-encontrada.component';

describe('PaginaoNaoEncontradaComponent', () => {
  let component: PaginaoNaoEncontradaComponent;
  let fixture: ComponentFixture<PaginaoNaoEncontradaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PaginaoNaoEncontradaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PaginaoNaoEncontradaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
