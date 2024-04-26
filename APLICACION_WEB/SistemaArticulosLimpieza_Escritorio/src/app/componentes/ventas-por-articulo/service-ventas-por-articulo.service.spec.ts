import { TestBed } from '@angular/core/testing';

import { ServiceVentasPorArticuloService } from './service-ventas-por-articulo.service';

describe('ServiceVentasPorArticuloService', () => {
  let service: ServiceVentasPorArticuloService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceVentasPorArticuloService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
