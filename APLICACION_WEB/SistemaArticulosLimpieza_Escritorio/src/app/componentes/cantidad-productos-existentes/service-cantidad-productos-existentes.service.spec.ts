import { TestBed } from '@angular/core/testing';

import { ServiceCantidadProductosExistentesService } from './service-cantidad-productos-existentes.service';

describe('ServiceCantidadProductosExistentesService', () => {
  let service: ServiceCantidadProductosExistentesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceCantidadProductosExistentesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
