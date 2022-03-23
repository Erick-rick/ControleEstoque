using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public IActionResult EntradaEstoque()
        {
            return View();
        }
        [Authorize]
        public IActionResult SaidaEstoque()
        {
            return View();
        }
        [Authorize]
        public IActionResult LancamentoPerdaProduto()
        {
            return View();
        }
        [Authorize]
        public IActionResult Inventario()
        {
            return View();
        }
    }
}
