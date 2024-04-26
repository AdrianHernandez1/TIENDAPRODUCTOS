import { Component, OnInit } from '@angular/core';
import { ServiceVentasGlobalesService, VentasGlobales } from '../service-ventas-globales.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-ventas-globales',
  templateUrl: './ventas-globales.component.html',
  styleUrls: ['./ventas-globales.component.css']
})
export class VentasGlobalesComponent implements OnInit {

  public arrayOriginalVentasGlobales: VentasGlobales[] = [];
  public arrayVentasGlobales: VentasGlobales[] = [];


  constructor(private _serviceVentasGlobales: ServiceVentasGlobalesService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.obtenerVentasGlobales();
  }

  obtenerVentasGlobales(){
    const ventas=[];

    this._serviceVentasGlobales.obtenerVentasGlobales_Servicio().subscribe({
      next:(ventas:VentasGlobales)=>{
        this.arrayOriginalVentasGlobales = this.arrayOriginalVentasGlobales.concat(ventas);
        this.arrayVentasGlobales = this.arrayOriginalVentasGlobales.concat(ventas).slice(0, 5);
      },
      error:(error: Error)=>{
        this._snackBar.open("Ha ocurrido un error. Intente mas tarde.");
      }
    });
  }

  paginatorProductos(event: PageEvent): void {
    const startIndex = event.pageIndex * event.pageSize;
    const endIndex = startIndex + event.pageSize;
    this.arrayVentasGlobales = this.arrayOriginalVentasGlobales.slice(startIndex, endIndex);
  }

}
