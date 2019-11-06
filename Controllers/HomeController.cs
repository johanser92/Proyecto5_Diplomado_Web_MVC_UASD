using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto5_Diplomado_Web_MVC_UASD.Models;

namespace Proyecto5_Diplomado_Web_MVC_UASD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productos = new List<Producto>
            {
               new Producto {Id=1, Descripcion="Boligrafo", Precio=8.35},
               new Producto {Id=2, Descripcion="Cuaderno Grande", Precio=21.5},
               new Producto {Id=3, Descripcion="Cuaderno Pequeño", Precio=10},
               new Producto {Id=4, Descripcion="Folio 500 uds.", Precio=550.55},
               new Producto {Id=5, Descripcion="Grapadora", Precio=85.25},
               new Producto {Id=6, Descripcion="Tijeras", Precio=62},
               new Producto {Id=7, Descripcion="Cinta Adhesiva", Precio=45.10},
               new Producto {Id=8, Descripcion="Rotulador", Precio=20.75},
               new Producto {Id=9, Descripcion="Mochila Escolar", Precio=800.90},
               new Producto {Id=10, Descripcion="Pegamento Barra", Precio=30.15},
               new Producto {Id=11, Descripcion="Lapicero", Precio=15.55},
               new Producto {Id=12, Descripcion="Grapas", Precio=40.90},
           
            };
            ///*Codigo LinQ que muestra los productos con la letra "I" en su descripcion*/
            //var resulProductos = from Productos in productos
            //                     where Productos.Descripcion.Contains("i")
            //                     select Productos;

            //return View(resulProductos);

            /*Codigo LinQ que muestra los productos con la letra "C" en su descripcion*/
            //var resulProductos = from Productos in productos
            //                     where Productos.Descripcion.StartsWith("C")
            //                     select Productos;

            //return View(resulProductos);


            //var resulProductos = from Productos in productos
            //                     where Productos.Descripcion.EndsWith("o")
            //                     select Productos;

            //return View(resulProductos);

            //var resulProductos = from Productos in productos
            //                     where Productos.Precio>20
            //                     select Productos;

            //return View(resulProductos);
            var resulProductos = from Productos in productos
                                 where Productos.Precio <70
                                 select Productos;

            return View(resulProductos);




        }
    }
}