﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estoque.Web.Areas.Admin.Models;
using Estoque.DAL.Entity;
using Estoque.DAL.Persistence;

namespace Estoque.Web.Areas.Admin.Controllers
{
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

        #endregion
    }
}