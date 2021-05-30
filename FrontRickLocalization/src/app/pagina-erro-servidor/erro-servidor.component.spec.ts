import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ErroServidorComponent } from './erro-servidor.component';

describe('ErroServidorComponent', () => {
  let component: ErroServidorComponent;
  let fixture: ComponentFixture<ErroServidorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ErroServidorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ErroServidorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
