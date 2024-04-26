import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

export interface ArticulosMasVendidos {
  IDProducto:     number;
  Titulo:         string;
  Descripcion:    string;
  TotalVendido:   number;
  PrecioUnitario: number;
  TotalVentas:    number;
}


@Injectable({
  providedIn: 'root'
})
export class ServiceArticulosMasVendidosService {

  private url = environment.BaseURL;

  constructor(private _http: HttpClient) { }

  public obtenerArticulosMasVendidos_Servicio():Observable<ArticulosMasVendidos>{
       return this._http.get<ArticulosMasVendidos>(this.url+"articulos-mas-vendidos");
  }
}
