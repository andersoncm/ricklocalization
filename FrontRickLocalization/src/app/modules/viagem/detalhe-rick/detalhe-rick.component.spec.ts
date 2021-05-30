import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalheRickComponent } from './detalhe-rick.component';

describe('DetalheRickComponent', () => {
  let component: DetalheRickComponent;
  let fixture: ComponentFixture<DetalheRickComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DetalheRickComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DetalheRickComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
