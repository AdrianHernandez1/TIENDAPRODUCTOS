import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PaginaPrincipalComponent } from './inicio/pagina-principal/pagina-principal.component';
import { VentasPorArticuloComponent } from './componentes/ventas-por-articulo/ventas-por-articulo/ventas-por-articulo.component';
import { VentasGlobalesComponent } from './componentes/ventas-globales/ventas-globales/ventas-globales.component';
import { ArticulosMasVendidosComponent } from './componentes/articulos-mas-vendidos/articulos-mas-vendidos/articulos-mas-vendidos.component';
import { CantidadProductosExistentesComponent } from './componentes/cantidad-productos-existentes/cantidad-productos-existentes/cantidad-productos-existentes.component';
import { ProductosCantidadMenorCienComponent } from './componentes/productos-cantidad-menor-cien/productos-cantidad-menor-cien/productos-cantidad-menor-cien.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


import {MatToolbarModule} from '@angular/material/toolbar';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatTabsModule , MatTabGroup} from '@angular/material/tabs';
import {MatSnackBar, MatSnackBarModule} from '@angular/material/snack-bar';
import { HttpClient, HttpClientModule } from '@angular/common/http';

import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatSort, MatSortModule, SortDirection} from '@angular/material/sort';
import {MatTableModule} from '@angular/material/table';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatBadgeModule} from '@angular/material/badge';
import {MatMenuModule} from '@angular/material/menu';

import {
  MatBottomSheet,
  MatBottomSheetModule,
  MatBottomSheetRef,
} from '@angular/material/bottom-sheet';
import {MatListModule} from '@angular/material/list';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    PaginaPrincipalComponent,
    VentasPorArticuloComponent,
    VentasGlobalesComponent,
    ArticulosMasVendidosComponent,
    CantidadProductosExistentesComponent,
    ProductosCantidadMenorCienComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatButtonModule,
    MatGridListModule,
    MatCardModule,
    MatTabsModule,
    MatSnackBarModule,
    HttpClientModule,
    MatPaginatorModule,
    MatSortModule,
    MatTableModule,
    MatProgressSpinnerModule,
    MatBadgeModule,
    MatMenuModule,
    FormsModule

  ],
  exports:[
    MatToolbarModule,
    MatButtonModule,
    MatGridListModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
