using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ODEPA_.Controllers;
using ODEPA_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ODEPA_.Pages
{
    public class IndexModel : PageModel
    {
        public List<Producto> productos { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Output output = new();
            productos = output.ListarProductos(-1);
        }
    }
}
