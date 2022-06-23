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
        public string c;
        public int rut;
        public void OnGetLogin(string correo)
        {
            try{
                
                c = correo.Trim();
                Output output = new();
                Productor pr = new();
                pr = output.GetProductor(c);
                
                rut = int.Parse(pr.Prut.ToString().Trim());
                Console.WriteLine("-"+pr.Prut+"-");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void OnPostDelete(int id)
        {
            try
            {
                Input input = new();
                input.DeleteProducto(id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        public void OnPost()
        {
            Input input = new();
            Producto p = new();
            try
            {
                p.ProductName = Request.Form["nombre"].ToString();
                p.ProducerID = int.Parse(Request.Form["rut"]);
                Console.WriteLine("-" + p.ProducerID + "-");
                p.Stock = int.Parse(Request.Form["stock"]);
                p.ProductType = Request.Form["tipo"].ToString();
                p.Price = float.Parse(Request.Form["precio"]);
                p.SellAdress = Request.Form["adress"].ToString();
                p.ProductImage = Request.Form["url"].ToString();
                input.InsertProducto(p);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }
    }
}
