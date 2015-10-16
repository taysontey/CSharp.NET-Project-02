using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estoque.Web.Models;
using Estoque.DAL.Entity;
using Estoque.DAL.Persistence;
using Estoque.Util.Security;


namespace Estoque.Web.Controllers
{
    public class FuncionarioController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarFuncionario(FuncionarioModelCadastro model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Funcionario f = new Funcionario();
                    f.Nome = model.Nome;
                    f.Login = model.Login;
                    f.Senha = Criptografia.GetMD5Hash(model.Senha);
                    f.DataCadastro = DateTime.Now;
                    f.Foto = Guid.NewGuid().ToString() + ".jpg";

                    FuncionarioDal d = new FuncionarioDal();
                    d.Insert(f);

                    model.Foto.SaveAs(HttpContext.Server.MapPath("/Imagens/" + f.Foto));

                    ModelState.Clear();

                    ViewBag.Mensagem = "Usuario " + f.Nome + ", cadastrado com sucesso.";
                }
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = e.Message;
            }

            return View("Cadastro");
        }

        [HttpPost]
        public ActionResult AutenticarFuncionario(FuncionarioModelLogin model)
        {
            return View("Login");
        }
    }
}