import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { inject } from '@angular/core/testing';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

export interface VentasPorArticulo {
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
export class ServiceVentasPorArticuloService {
  private url = environment.BaseURL;

  constructor(private _http: HttpClient) { }

  public obtenerVentasPorArticulos_Servicio(idsProductos:number[]):Observable<VentasPorArticulo>{
    let body ={
      "productos":idsProductos
  }
  return this._http.post<VentasPorArticulo>(this.url+"listar-ventas-por-articulo",body);
  }

}
