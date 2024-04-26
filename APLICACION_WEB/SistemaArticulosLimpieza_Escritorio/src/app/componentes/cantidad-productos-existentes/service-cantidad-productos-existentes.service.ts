import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

export interface CantidadProductosExistentes {
  IDProductos:    number;
  Titulo:         string;
  Descripcion:    string;
  PrecioUnitario: number;
  Existencias:    number;
  TotalVentas:    number;
}

@Injectable({
  providedIn: 'root'
})
export class ServiceCantidadProductosExistentesService {
  private url = environment.BaseURL;

  constructor(private _http: HttpClient) { }

  public obtenerCantidadProductosExistentes_Servicio():Observable<CantidadProductosExistentes>{
       return this._http.get<CantidadProductosExistentes>(this.url+"cantidad-productos-existentes");
  }
}
