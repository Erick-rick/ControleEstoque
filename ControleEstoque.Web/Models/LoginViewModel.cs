using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Models
{
    public class LoginViewModel
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool LembrarMe { get; set; }
    }
}
