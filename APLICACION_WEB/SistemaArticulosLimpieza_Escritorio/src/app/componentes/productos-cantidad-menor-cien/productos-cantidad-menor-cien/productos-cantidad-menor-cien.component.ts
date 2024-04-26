import { Component, OnInit } from '@angular/core';
import { CantidadProductosExistentes, ServiceCantidadProductosExistentesService } from '../../cantidad-productos-existentes/service-cantidad-productos-existentes.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-productos-cantidad-menor-cien',
  templateUrl: './productos-cantidad-menor-cien.component.html',
  styleUrls: ['./productos-cantidad-menor-cien.component.css']
})
export class ProductosCantidadMenorCienComponent implements OnInit {

  public arrayCantidadProductosExistentes: CantidadProductosExistentes[] = [];
  public numeroProductos: number=0;


  constructor(private _serviceCantidadProductosExistentes: ServiceCantidadProductosExistentesService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.obtenerCantidadProductosExistentes();
  }

  obtenerCantidadProductosExistentes() {
    this._serviceCantidadProductosExistentes.obtenerCantidadProductosExistentes_Servicio().subscribe({
      next: (productos: CantidadProductosExistentes) => {
        this.arrayCantidadProductosExistentes = this.arrayCantidadProductosExistentes.concat(productos);

        this.arrayCantidadProductosExistentes = this.arrayCantidadProductosExistentes.filter(producto => producto.Existencias < 100);

        console.log(this.arrayCantidadProductosExistentes)
        this.numeroProductos = this.arrayCantidadProductosExistentes.length;
      },
      error: (error: Error) => {
        this._snackBar.open("Ha ocurrido un error. Intente mas tarde.");
      }
    });
  }

  badgeClicked() {
    alert("HOLA")
  }





}
