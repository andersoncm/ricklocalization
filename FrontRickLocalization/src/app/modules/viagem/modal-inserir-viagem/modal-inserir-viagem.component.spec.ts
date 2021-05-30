import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalInserirViagemComponent } from './modal-inserir-viagem.component';

describe('ModalInserirViagemComponent', () => {
  let component: ModalInserirViagemComponent;
  let fixture: ComponentFixture<ModalInserirViagemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ModalInserirViagemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModalInserirViagemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
