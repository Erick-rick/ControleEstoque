using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public IActionResult PosicaoEstoque()
        {
            return View();
        }
        [Authorize]
        public IActionResult Ressuprimento()
        {
            return View();
        }
    }
}
