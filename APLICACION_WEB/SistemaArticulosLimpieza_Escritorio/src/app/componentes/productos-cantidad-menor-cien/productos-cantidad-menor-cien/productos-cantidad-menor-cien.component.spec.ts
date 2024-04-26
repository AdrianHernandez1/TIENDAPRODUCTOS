import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductosCantidadMenorCienComponent } from './productos-cantidad-menor-cien.component';

describe('ProductosCantidadMenorCienComponent', () => {
  let component: ProductosCantidadMenorCienComponent;
  let fixture: ComponentFixture<ProductosCantidadMenorCienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductosCantidadMenorCienComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductosCantidadMenorCienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
