using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TiendaProductos.Models;

namespace TiendaProductos.Controlador
{
    public class ProductosController
    {
        private HttpClient cliente;
        private string BaseURL = "http://localhost:58683/api/productos/";

        public ProductosController()
        {
            cliente = new HttpClient();
        }

        public async Task<List<VentaPorArticulo>> obtenerVentasPorArticulo(int idsProductos)
        {
            try
            {
                var productos = new int[] { idsProductos };
                var requestBody = new { productos };

                var jsonBody = JsonSerializer.Serialize(requestBody);

                HttpResponseMessage response = await cliente.PostAsync(BaseURL + "listar-ventas-por-articulo",
                                                                       new StringContent(jsonBody, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    List<VentaPorArticulo> ventasPorArticulo = JsonSerializer.Deserialize<List<VentaPorArticulo>>(jsonResponse);

                    return ventasPorArticulo;
                }
                else
                {
                    throw new Exception("Error al enviar la solicitud. Código de estado: " + response.StatusCode);
                }   
            } 
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la respuesta JSON: " + ex.Message);
            }
        }

        public async Task<List<VentaPorArticulo>> obtenerVentasGlobales()
        {
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(BaseURL + "ventas-globales");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    List<VentaPorArticulo> ventasGlobales = JsonSerializer.Deserialize<List<VentaPorArticulo>>(jsonResponse);

                    return ventasGlobales;
                }
                else
                {
                    throw new Exception("Error al enviar la solicitud. Código de estado: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la respuesta JSON: " + ex.Message);
            }
        }

        public async Task<List<VentaPorArticulo>> obtenerArticulosMasVendidos()
        {
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(BaseURL + "articulos-mas-vendidos");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    List<VentaPorArticulo> articulosMasVendidos = JsonSerializer.Deserialize<List<VentaPorArticulo>>(jsonResponse);

                    return articulosMasVendidos;
                }
                else
                {
                    throw new Exception("Error al enviar la solicitud. Código de estado: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la respuesta JSON: " + ex.Message);
            }
        }

        public async Task<List<Productos>> obtenerCantidadProductosExistentes()
        {
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(BaseURL + "cantidad-productos-existentes");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    List<Productos> cantidadProductosExistentes = JsonSerializer.Deserialize<List<Productos>>(jsonResponse);

                    return cantidadProductosExistentes;
                }
                else
                {
                    throw new Exception("Error al enviar la solicitud. Código de estado: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la respuesta JSON: " + ex.Message);
            }
        }
    }


}
