using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModaSystemCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CadastroProdutos()
        {
            return View();
        }
        public IActionResult CadastroUnidades()
        {
            return View();
        }
        public IActionResult CadastroMarcas()
        {
            return View();
        }
        public IActionResult CadastroDespesas()
        {
            return View();
        }
        public IActionResult CadastroClientes()
        {
            return View();
        }
        public IActionResult CadastroVendedores()
        {
            return View();
        }
        public IActionResult CadastroFornecedores()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
    }
}