using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estoque.Web.Areas.Admin.Models;
using Estoque.DAL.Entity;
using Estoque.DAL.Persistence;

namespace Estoque.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class FornecedorController : Controller
    {
        // GET: Admin/Fornecedor
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

        public ActionResult Lista()
        {
            return View();
        }

        #region Metodos AJAX

        public JsonResult Cadastrar(FornecedorModelCadastro model)
        {
            try
            {
                Funcionario u = (Funcionario)Session["funcionariologado"];

                Fornecedor f = new Fornecedor();
                f.Nome = model.Nome;

                FornecedorDal d = new FornecedorDal();
                d.Insert(f);

                return Json("Dados gravados com sucesso.");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        public JsonResult Consultar(FornecedorModelConsulta model)
        {
            try
            {
                Funcionario u = (Funcionario)Session["funcionariologado"];

                FornecedorDal d = new FornecedorDal();

                List<Fornecedor> list = new List<Fornecedor>();
                list.Add(d.FindById(model.IdFornecedor));

                return Json(list);

            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        public JsonResult Listar()
        {
            try
            {
                Funcionario u = (Funcionario)Session["funcionariologado"];

                FornecedorDal d = new FornecedorDal();

                List<Fornecedor> list = new List<Fornecedor>();
                list = d.FindAll();
                
                return Json(list);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        public JsonResult Excluir(FornecedorModelExclusao model)
        {
            try
            {
                Funcionario u = (Funcionario)Session["funcionariologado"];

                FornecedorDal d = new FornecedorDal();

                d.Delete(model.IdFornecedor);

                return Json("Fornecedor Excluido.");
                
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }
        #endregion
    }
}