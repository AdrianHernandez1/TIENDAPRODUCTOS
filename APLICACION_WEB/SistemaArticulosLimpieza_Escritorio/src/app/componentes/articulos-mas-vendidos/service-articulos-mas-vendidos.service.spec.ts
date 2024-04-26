import { TestBed } from '@angular/core/testing';

import { ServiceArticulosMasVendidosService } from './service-articulos-mas-vendidos.service';

describe('ServiceArticulosMasVendidosService', () => {
  let service: ServiceArticulosMasVendidosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceArticulosMasVendidosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
