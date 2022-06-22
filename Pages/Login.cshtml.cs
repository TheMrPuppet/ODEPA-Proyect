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
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Input input = new();
            if (input.IsCorreoThere(Request.Form["correo"].ToString()))
            {
                if(input.CheckPW(Request.Form["correo"].ToString(), Request.Form["pw"].ToString()))
                {
                    return RedirectToPage("Productor","Login", new { correo = Request.Form["correo"].ToString().Trim() });
                }
                else
                {
                    ViewData["Message"] = string.Format("Wrong Password");
                    return Page();
                }
            }
            else
            {
                ViewData["Message"] = string.Format("Correo no encontrado");
                return Page();
            }
        }
    }
}
