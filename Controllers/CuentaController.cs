using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Controllers
{
    public class CuentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
