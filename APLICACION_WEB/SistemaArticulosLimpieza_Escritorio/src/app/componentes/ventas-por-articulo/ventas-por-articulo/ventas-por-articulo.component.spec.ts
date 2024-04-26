import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VentasPorArticuloComponent } from './ventas-por-articulo.component';

describe('VentasPorArticuloComponent', () => {
  let component: VentasPorArticuloComponent;
  let fixture: ComponentFixture<VentasPorArticuloComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VentasPorArticuloComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VentasPorArticuloComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
