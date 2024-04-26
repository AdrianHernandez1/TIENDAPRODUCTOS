import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

export interface VentasGlobales {
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
export class ServiceVentasGlobalesService {
  private url = environment.BaseURL;

  constructor(private _http: HttpClient) { }

  public obtenerVentasGlobales_Servicio():Observable<VentasGlobales>{
       return this._http.get<VentasGlobales>(this.url+"ventas-globales");
  }

}
