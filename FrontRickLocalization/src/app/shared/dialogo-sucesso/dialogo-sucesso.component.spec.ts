import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogoSucessoComponent } from './dialogo-sucesso.component';

describe('DialogoSucessoComponent', () => {
  let component: DialogoSucessoComponent;
  let fixture: ComponentFixture<DialogoSucessoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DialogoSucessoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DialogoSucessoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
