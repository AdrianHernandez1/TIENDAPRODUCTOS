import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CantidadProductosExistentesComponent } from './cantidad-productos-existentes.component';

describe('CantidadProductosExistentesComponent', () => {
  let component: CantidadProductosExistentesComponent;
  let fixture: ComponentFixture<CantidadProductosExistentesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CantidadProductosExistentesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CantidadProductosExistentesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
