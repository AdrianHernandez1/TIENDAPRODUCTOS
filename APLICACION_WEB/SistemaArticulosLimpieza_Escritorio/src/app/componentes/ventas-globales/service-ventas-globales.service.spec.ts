import { TestBed } from '@angular/core/testing';

import { ServiceVentasGlobalesService } from './service-ventas-globales.service';

describe('ServiceVentasGlobalesService', () => {
  let service: ServiceVentasGlobalesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceVentasGlobalesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
