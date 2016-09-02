using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ventas2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }


        public JsonResult ObtenerProductos()
        {
            var ListSucursal = new List<Models.Sucursal>();
            var Su1 = new Models.Sucursal() { IdSucursal = 1, Nombre = "HipermaxiSur" };
            var Su2 = new Models.Sucursal() { IdSucursal = 2, Nombre = "HipermaxiNur" };
            ListSucursal.Add(Su1);
            ListSucursal.Add(Su2);
            var ListTipoProducto = new List<Models.tipoProducto>();
            var tu1 = new Models.tipoProducto() { idTipoProducto = 1, Categoria = "Enbutidos" };
            var tu2 = new Models.tipoProducto() { idTipoProducto = 2, Categoria = "FARMACIA" };
            var tu3 = new Models.tipoProducto() { idTipoProducto = 3, Categoria = "Ferreteria" };
            ListTipoProducto.Add(tu1);
            ListTipoProducto.Add(tu2);
            ListTipoProducto.Add(tu3);
            var listProducto = new List<Models.producto>();
            var produ1 = new Models.producto() { IdpOrducto = 1, NombrewProducto = "Yoogurt", Precio = 1, Categoria=ListTipoProducto, Nombre=ListSucursal};
            var produ2 = new Models.producto() { IdpOrducto = 2, NombrewProducto = "ANTIGRIPAL", Precio = 10, Categoria = ListTipoProducto, Nombre=ListSucursal};
            var produ3 = new Models.producto() { IdpOrducto = 3, NombrewProducto = "Pala", Precio = 1100, Categoria = ListTipoProducto, Nombre=ListSucursal };

            listProducto.Add(produ1);
            listProducto.Add(produ2);
            listProducto.Add(produ3);

            return Json(listProducto, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ObtenerUsuarios()
        {

         

            var ListCargo = new List<Models.tipoUsuario>();
            var tu1 = new Models.tipoUsuario(){idTipoUsuario = 1, cargo = "Administrador"};
            var tu2 = new Models.tipoUsuario(){idTipoUsuario = 2, cargo = "operario"};
            ListCargo.Add(tu1);
            ListCargo.Add(tu2);
            var listUsuario = new List<Models.usuario>();
            var u1 = new Models.usuario() { idUsuario = 1, nombre = "papo",apellido="YO", login = "papo" ,password="123", cargo=ListCargo};
            var u2 = new Models.usuario() { idUsuario = 1, nombre = "tito", apellido = "Flores", login = "tito", password = "123", cargo = ListCargo };
            var u3 = new Models.usuario() { idUsuario = 1, nombre = "Mario", apellido = " Son", login = "mario", password = "123", cargo = ListCargo };

            listUsuario.Add(u1);
            listUsuario.Add(u2);
            listUsuario.Add(u3);

            return Json(listUsuario, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerSucursales()
        {
            var listProducto = new List<Models.producto>();
            var produ1 = new Models.producto() { IdpOrducto = 1, NombrewProducto = "peras", Precio = 12 };
            var produ2 = new Models.producto() { IdpOrducto = 1, NombrewProducto = "manzanas", Precio = 12 };
            var produ3 = new Models.producto() { IdpOrducto = 1, NombrewProducto = "kiwi", Precio = 12 };

            listProducto.Add(produ1);
            listProducto.Add(produ2);
            listProducto.Add(produ3);

            return Json(listProducto, JsonRequestBehavior.AllowGet);
        }


    }

    
}
