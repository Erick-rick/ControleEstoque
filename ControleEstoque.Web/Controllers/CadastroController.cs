using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GrupoProduto()
        {
            return View();
        }
        public IActionResult MarcaProduto()
        {
            return View();
        }
        public IActionResult LocalProduto()
        {
            return View();
        }
        public IActionResult UnidadeMedida()
        {
            return View();

        }
        public IActionResult Produto()
        {
            return View();
        }
        public IActionResult Pais()
        {
            return View();
        }
        public IActionResult Estado()
        {
            return View();
      
        }
        public IActionResult Cidade()
        {
            return View();
        }
        public IActionResult Fornecedor()
        {
            return View();
        }
        public IActionResult PerfilUsuario()
        {
            return View();
        }
        public IActionResult Usuario()
        {
            return View();
        }
    }
}
