using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ODEPA_.Model;
using ODEPA_.Controllers;
using Microsoft.AspNetCore.Http;

namespace ODEPA_.Pages
{
    public class RegistroModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Input input = new();
            Productor productor = new();
            Cuenta cuenta = new();
            //productor
            productor.Prut = int.Parse(Request.Form["rut"].ToString().Remove(Request.Form["rut"].ToString().Length - 3));
            productor.Prutid = Request.Form["rut"].ToString().Substring(Request.Form["rut"].ToString().Length - 1);
            productor.Pnombre = Request.Form["nombre"].ToString();
            productor.Pcorreo = Request.Form["correo"].ToString();
            productor.Padress = Request.Form["adress"].ToString();
            //cuenta
            cuenta.Nombre = productor.Pnombre;
            cuenta.Correo = productor.Pcorreo;
            cuenta.Pw = Request.Form["pw"].ToString();
            //

            input.InsertCuenta(cuenta);
            input.InsertProductor(productor);
            return RedirectToPage("Login");
        }
    }
}
