using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ProductoController : ApiController
    {
        [HttpPost]
        [Route("api/productos/listar-ventas-por-articulo")]
        public HttpResponseMessage ListarVentasPorArticulo([FromBody] ProductosIds request)
        {
            if (request == null )
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                response.Content = new StringContent("El arreglo de productos no puede ser nulo.");
                return response;
            }

            return Request.CreateResponse(HttpStatusCode.OK, ProductosData.ListarVentasPorArticulo(request));
        }
        [HttpGet]
        [Route("api/productos/ventas-globales")]
        public HttpResponseMessage ListarVentasGlobales()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ProductosData.ListarVentasGlobales());
        }

        [HttpGet]
        [Route("api/productos/articulos-mas-vendidos")]
        public HttpResponseMessage ArticulosMasVendidos()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ProductosData.ArticulosMasVendidos());
        }

        [HttpGet]
        [Route("api/productos/cantidad-productos-existentes")]
        public HttpResponseMessage CantidadProductosExistente()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ProductosData.CantidadProductosExistente());
        }






    }
}