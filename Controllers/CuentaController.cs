using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Controllers
{
    public class CuentaController : Controller
    {
        private Producto pro = new Producto();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.alerta = "info";
            ViewBag.res = "Registrar Nuevo Producto ";
            return View(pro.listar());
        }
        [HttpPost]
        public ActionResult Index(int productID, string productName, int stock, string productType, float price, string productImage)
        {
            if (pro.Insertar(productID, productName, stock, productType, price, productImage))
            {
                ViewBag.alerta = "success";
                ViewBag.res = "Producto Registrado";
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "Producto no Registrado";
            }
            return View(pro.listar());
        }
        public ActionResult Editar(int productID)
        {
            ViewBag.alerta = "info";
            ViewBag.res = "Actualizar Producto";
            return View(pro.un_registro(productID));
        }
        [HttpPost]
        public ActionResult Editar(int productID, string productName, int stock, string productType, float price, string productImage)
        {
            if (pro.Actualizar(productID, productName, stock, productType, price, productImage))
            {
                ViewBag.alerta = "success";
                ViewBag.res = "Datos del producto actualizados";
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "Ocurrio un error :( ";
            }
            return View(pro.un_registro(productID));
        }
        public ActionResult Eliminar(int productID)
        {
            if (pro.Eliminar(productID))
            {
                return RedirectToAction("Index", "Producto");
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "El producto algo";
                return View(pro.un_registro(productID));
            }
        }
    }
}

