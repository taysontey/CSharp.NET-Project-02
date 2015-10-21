using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estoque.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        // GET: Admin/Produto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }
    }
}