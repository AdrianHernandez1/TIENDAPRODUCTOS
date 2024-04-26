import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VentasGlobalesComponent } from './ventas-globales.component';

describe('VentasGlobalesComponent', () => {
  let component: VentasGlobalesComponent;
  let fixture: ComponentFixture<VentasGlobalesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VentasGlobalesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VentasGlobalesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
