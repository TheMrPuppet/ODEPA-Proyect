using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ODEPA_.Controllers;
using ODEPA_.Model;
using Microsoft.AspNetCore.Http;

namespace ODEPA_.Pages
{
    public class ProductorModel : PageModel
    {
        private string correo;
        public void OnGetLogin()
        {
        }


        public void OnPostLogin()
        {
            Input input = new();
            Producto p = new();
            Output output = new();
            Productor pr = new();
            pr = output.GetProductor(correo);
            p.ProductName = Request.Form["nombre"].ToString();
            p.ProducerID = pr.Prut;
            p.Stock = int.Parse(Request.Form["stock"]);
            p.ProductType = Request.Form["tipo"].ToString();
            p.Price = float.Parse(Request.Form["precio"]);
            p.SellAdress = Request.Form["adress"].ToString();
            p.ProductImage = Request.Form["url"].ToString();
            input.InsertProducto(p);
        }
    }
}
