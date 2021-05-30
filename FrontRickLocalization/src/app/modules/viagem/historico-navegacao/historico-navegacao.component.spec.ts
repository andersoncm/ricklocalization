import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HistoricoNavegacaoComponent } from './historico-navegacao.component';

describe('HistoricoNavegacaoComponent', () => {
  let component: HistoricoNavegacaoComponent;
  let fixture: ComponentFixture<HistoricoNavegacaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HistoricoNavegacaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HistoricoNavegacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
