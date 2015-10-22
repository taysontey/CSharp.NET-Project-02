using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estoque.DAL.Entity;
using Estoque.DAL.Persistence;
using Estoque.Web.Areas.Admin.Models;

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

        public ActionResult Consulta()
        {
            return View();
        }

        #region Metodos AJAX

        public JsonResult FillDropDownFornecedor()
        {
            FornecedorDal d = new FornecedorDal();

            var lista = d.FindAll();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Cadastrar(ProdutoModelCadastro model)
        {
            try
            {
                Funcionario u = (Funcionario)Session["funcionariologado"];

                Produto p = new Produto();

                p.Nome = model.Nome;
                p.Preco = model.Preco;
                p.Quantidade = model.Quantidade;
                p.Descricao = model.Descricao;
                p.IdFornecedor = model.IdFornecedor;

                ProdutoDal d = new ProdutoDal();
                d.Insert(p);

                return Json("Dados gravados com sucesso.");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        public JsonResult Consultar(ProdutoModelConsulta model)
        {
            try
            {
                Funcionario u = (Funcionario)Session["funcionariologado"];

                ProdutoDal d = new ProdutoDal();

                var data = d.FindById(model.IdProduto);

                Produto p = new Produto();

                p.IdProduto = data.IdProduto;
                p.Nome = data.Nome;
                p.Preco = data.Preco;
                p.Quantidade = data.Quantidade;
                p.Descricao = data.Descricao;
                p.IdFornecedor = data.IdFornecedor;

                List<Produto> lista = new List<Produto>();
                lista.Add(p);

                return Json(lista);

            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }
        #endregion
    }
}