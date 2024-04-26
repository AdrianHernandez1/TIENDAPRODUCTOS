import { Component, OnInit } from '@angular/core';
import { ArticulosMasVendidos, ServiceArticulosMasVendidosService } from '../service-articulos-mas-vendidos.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-articulos-mas-vendidos',
  templateUrl: './articulos-mas-vendidos.component.html',
  styleUrls: ['./articulos-mas-vendidos.component.css']
})
export class ArticulosMasVendidosComponent implements OnInit {

  public arrayOriginalArticulosMasVendidos: ArticulosMasVendidos[] = [];
  public arrayArticulosMasVendidos: ArticulosMasVendidos[] = [];

  constructor(private _serviceArticulosMasVendidos: ServiceArticulosMasVendidosService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.obtenerVentasGlobales();
  }

  obtenerVentasGlobales(){
    this._serviceArticulosMasVendidos.obtenerArticulosMasVendidos_Servicio().subscribe({
      next:(articulos:ArticulosMasVendidos)=>{
        this.arrayOriginalArticulosMasVendidos = this.arrayOriginalArticulosMasVendidos.concat(articulos);
        this.arrayArticulosMasVendidos = this.arrayOriginalArticulosMasVendidos.concat(articulos).slice(0, 5);
      },
      error:(error: Error)=>{
        this._snackBar.open("Ha ocurrido un error. Intente mas tarde.");
      }
    });
  }

  paginatorProductos(event: PageEvent): void {
    const startIndex = event.pageIndex * event.pageSize;
    const endIndex = startIndex + event.pageSize;
    this.arrayArticulosMasVendidos = this.arrayOriginalArticulosMasVendidos.slice(startIndex, endIndex);
  }

}
