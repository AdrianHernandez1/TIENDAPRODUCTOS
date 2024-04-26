using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Data
{
    public class ProductosData   {

        public static List<VentaPorArticulo> ListarVentasPorArticulo(ProductosIds idsProductos)
        {
            List<VentaPorArticulo> ventasPorArticulo = new List<VentaPorArticulo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {


                string idsParametro = string.Join(",", idsProductos.productos);

                SqlCommand cmd = new SqlCommand($@"
            SELECT 
                P.IDProductos,
                P.Titulo,
                P.Descripcion,
                SUM(V.CantidadVendida) AS TotalVendido,
                P.PrecioUnitario AS PrecioUnitario,
                SUM(V.CantidadVendida * P.PrecioUnitario) AS TotalVentas
            FROM 
                Productos P
            INNER JOIN 
                Ventas V ON P.IDProductos = V.IDProductos
            WHERE
                P.IDProductos IN ({idsParametro})
            GROUP BY 
                P.IDProductos, P.Titulo, P.Descripcion, P.PrecioUnitario
            ORDER BY 
                P.IDProductos;", conexion);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VentaPorArticulo venta = new VentaPorArticulo
                            {
                                IDProducto = Convert.ToInt32(reader["IDProductos"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                TotalVendido = Convert.ToInt32(reader["TotalVendido"]),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                                TotalVentas = Convert.ToDecimal(reader["TotalVentas"])
                            };
                            ventasPorArticulo.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return ventasPorArticulo;
        }


        public static List<VentaPorArticulo> ListarVentasGlobales()
        {
            List<VentaPorArticulo> listarVentasGlobales = new List<VentaPorArticulo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        P.IDProductos,
                        P.Titulo,
	                    P.Descripcion,
                        SUM(V.CantidadVendida) AS TotalVendido,
                        P.PrecioUnitario AS PrecioUnitario,
                        SUM(V.CantidadVendida * P.PrecioUnitario) AS TotalVentas
                    FROM 
                        Productos P
                    INNER JOIN 
                        Ventas V ON P.IDProductos = V.IDProductos
                    GROUP BY 
                        P.IDProductos, P.Titulo, P.Descripcion, P.PrecioUnitario
                    ORDER BY 
                        P.IDProductos;", conexion);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VentaPorArticulo venta = new VentaPorArticulo
                            {
                                IDProducto = Convert.ToInt32(reader["IDProductos"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                TotalVendido = Convert.ToInt32(reader["TotalVendido"]),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                                TotalVentas = Convert.ToDecimal(reader["TotalVentas"])
                            };
                            listarVentasGlobales.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return listarVentasGlobales;
        }

        public static List<VentaPorArticulo> ArticulosMasVendidos()
        {
            List<VentaPorArticulo> articulosMasVendidos = new List<VentaPorArticulo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand(@"
                    SELECT P.Titulo, P.Descripcion, SUM(V.CantidadVendida) AS TotalVentas
                    FROM Productos AS P
                    INNER JOIN Ventas AS V ON P.IDProductos = V.IDProductos
                    GROUP BY P.Titulo, P.Descripcion
                    ORDER BY TotalVentas DESC;", conexion);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VentaPorArticulo venta = new VentaPorArticulo
                            {
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                TotalVentas = Convert.ToDecimal(reader["TotalVentas"])
                            };
                            articulosMasVendidos.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return articulosMasVendidos;
        }

        public static List<Productos> CantidadProductosExistente()
        {
            List<Productos> cantidadProductosExistentes = new List<Productos>();

            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand(@"
                    SELECT P.IDProductos,
                           P.Titulo ,
                           P.Descripcion,
                           P.PrecioUnitario,
                           P.Existencias,
                           ISNULL(SUM(V.CantidadVendida), 0) AS TotalVentas
                    FROM Productos AS P
                    LEFT JOIN Ventas AS V ON P.IDProductos = V.IDProductos
                    GROUP BY P.IDProductos, P.Titulo, P.Descripcion, P.PrecioUnitario, P.Existencias;", conexion);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Productos venta = new Productos
                            {
                                IDProductos = Convert.ToInt32(reader["IDProductos"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                                Existencias = Convert.ToInt32(reader["Existencias"]),
                                TotalVentas = Convert.ToInt32(reader["TotalVentas"])
                            };
                            cantidadProductosExistentes.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return cantidadProductosExistentes;
        }

    }
}