import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { CantidadProductosExistentes, ServiceCantidadProductosExistentesService } from '../service-cantidad-productos-existentes.service';
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-cantidad-productos-existentes',
  templateUrl: './cantidad-productos-existentes.component.html',
  styleUrls: ['./cantidad-productos-existentes.component.css']
})
export class CantidadProductosExistentesComponent implements OnInit {

  public arrayOriginalCantidadProductosExistentes: CantidadProductosExistentes[] = [];
  public arrayCantidadProductosExistentes: CantidadProductosExistentes[] = [];


  constructor(private _serviceCantidadProductosExistentes: ServiceCantidadProductosExistentesService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.obtenerCantidadProductosExistentes();
  }

  obtenerCantidadProductosExistentes(){
    this._serviceCantidadProductosExistentes.obtenerCantidadProductosExistentes_Servicio().subscribe({
      next:(productos:CantidadProductosExistentes)=>{
        this.arrayOriginalCantidadProductosExistentes = this.arrayOriginalCantidadProductosExistentes.concat(productos);
        this.arrayCantidadProductosExistentes = this.arrayCantidadProductosExistentes.concat(productos).slice(0, 5);
      },
      error:(error: Error)=>{
        this._snackBar.open("Ha ocurrido un error. Intente mas tarde.");
      }
    });
  }

  paginatorProductos(event: PageEvent): void {
    const startIndex = event.pageIndex * event.pageSize;
    const endIndex = startIndex + event.pageSize;
    this.arrayCantidadProductosExistentes = this.arrayCantidadProductosExistentes.slice(startIndex, endIndex);
  }

}
