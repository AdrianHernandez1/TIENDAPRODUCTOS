import { Component, OnInit } from '@angular/core';
import { ServiceVentasPorArticuloService, VentasPorArticulo } from '../service-ventas-por-articulo.service';
import { inject } from '@angular/core/testing';
import { MatSnackBar } from '@angular/material/snack-bar';
import { CantidadProductosExistentes, ServiceCantidadProductosExistentesService } from '../../cantidad-productos-existentes/service-cantidad-productos-existentes.service';

@Component({
  selector: 'app-ventas-por-articulo',
  templateUrl: './ventas-por-articulo.component.html',
  styleUrls: ['./ventas-por-articulo.component.css']
})
export class VentasPorArticuloComponent implements OnInit {

  public arrayVentasPorArticulo: VentasPorArticulo[] = [];
  public idsProductos: number=0;
  public arrayCantidadProductosExistentes: CantidadProductosExistentes[] = [];


  constructor(private _serviceCantidadProductosExistentes: ServiceCantidadProductosExistentesService,private _serviceVentasPorArticulo: ServiceVentasPorArticuloService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
     this.obtenerCantidadProductosExistentes();
  }

  obtenerVentasPorArticulo(idProducto:number[]){
    console.log(this.idsProductos);
    this._serviceVentasPorArticulo.obtenerVentasPorArticulos_Servicio(idProducto).subscribe({
      next:(articulos:VentasPorArticulo)=>{
        this.arrayVentasPorArticulo = this.arrayVentasPorArticulo.concat(articulos);
      },
      error:(error: Error)=>{
        this._snackBar.open("Ha ocurrido un error. Intente mas tarde.");
      }
    });
  }

  obtenerCantidadProductosExistentes(){
    this._serviceCantidadProductosExistentes.obtenerCantidadProductosExistentes_Servicio().subscribe({
      next:(productos:CantidadProductosExistentes)=>{
        this.arrayCantidadProductosExistentes = this.arrayCantidadProductosExistentes.concat(productos);
      },
      error:(error: Error)=>{
        this._snackBar.open("Ha ocurrido un error. Intente mas tarde.");
      }
    });
  }

  obtenerProductos(){
    if(this.idsProductos==0){
      this._snackBar.open("Debes seleccionar un producto");
    }else{
      this.arrayVentasPorArticulo=[];
      this.obtenerVentasPorArticulo([this.idsProductos]);
    }
  }

}
