import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PesquisarViagemPorRickComponent } from './pesquisar-viagem-por-rick.component';

describe('PesquisarViagemPorRickComponent', () => {
  let component: PesquisarViagemPorRickComponent;
  let fixture: ComponentFixture<PesquisarViagemPorRickComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PesquisarViagemPorRickComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PesquisarViagemPorRickComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
