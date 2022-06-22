using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ODEPA_.Model;
using ODEPA_.Pages;
using ODEPA_.Database;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ODEPA_.Controllers
{
	public class AccesoController : Controller
	{
		public ActionResult Login()
		{
			return View();
		}

		public ActionResult Registro()
		{
			return View();
		}

		public ActionResult Registro(Cuenta cuenta, Productor productor, string confirmar)
		{
			Input input = new();

			if (input.IsCorreoThere(cuenta.Correo) != true)
			{
				if (cuenta.Pw == confirmar)
                {
					input.InsertCuenta(cuenta);
					input.InsertProductor(productor);
					return Login();
				}
                else
                {
					ViewData["Mensaje"] = "Contraseñas no coinciden";
					return View();
				}
					
			}
            else
            {
				ViewData["Mensaje"] = "Correo ya registrado";
				return View();
			}		

		}

		public ActionResult Login(String correo, String pw)
		{
			Input input = new();
			if (input.IsCorreoThere(correo))
			{
				if (input.CheckPW(correo, pw)) {
					return View();
				}
			}


			return View();
		}

	}

}