using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public IActionResult PerdaMes()
        {
            return View();
        }
        [Authorize]
        public IActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}
