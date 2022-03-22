using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EntradaEstoque()
        {
            return View();
        }
        public IActionResult SaidaEstoque()
        {
            return View();
        }
        public IActionResult LancamentoPerdaProduto()
        {
            return View();
        }
        public IActionResult Inventario()
        {
            return View();
        }
    }
}
