import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArticulosMasVendidosComponent } from './articulos-mas-vendidos.component';

describe('ArticulosMasVendidosComponent', () => {
  let component: ArticulosMasVendidosComponent;
  let fixture: ComponentFixture<ArticulosMasVendidosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ArticulosMasVendidosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ArticulosMasVendidosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
