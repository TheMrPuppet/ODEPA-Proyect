using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ODEPA_.Controllers;
using ODEPA_.Model;

namespace ODEPA_.Pages
{
    public class ProductorModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Input input = new();
            Producto p = new();
            p.ProductName = Request.Form["nombre"];
            p.ProducerID = 20464358;
            p.Stock = int.Parse(Request.Form["stock"]);
            p.ProductType = Request.Form["tipo"];
            p.Price = float.Parse(Request.Form["precio"]);
            p.SellAdress = Request.Form["adress"];
            if(Request.Form.Files.Count != 0)
            {
                foreach(var img in Request.Form.Files)
                {
                    MemoryStream ms = new();
                    img.CopyTo(ms);
                    p.ProductImage = ms.ToArray();

                    ms.Close();
                    ms.Dispose();
                }
                
            }
            input.InsertProducto(p);
        }
    }
}
