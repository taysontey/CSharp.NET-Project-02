using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estoque.Web.Models;
using Estoque.DAL.Entity;
using Estoque.DAL.Persistence;
using Estoque.Util.Security;
using System.Web.Security;


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

                    ViewBag.Mensagem = "Funcionario " + f.Nome + ", cadastrado com sucesso.";
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
            try
            {
                if (ModelState.IsValid)
                {
                    FuncionarioDal d = new FuncionarioDal();
                    Funcionario f = d.Authenticate(model.Login, Criptografia.GetMD5Hash(model.Senha));

                    if(f != null)
                    {
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(f.Login, model.ManterConectado, 5);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                        Response.Cookies.Add(cookie);

                        Session.Add("funcionariologado", f);

                        return RedirectToAction("Index", "Fornecedor", new {area = "Admin"});
                    }
                    else
                    {
                        ViewBag.Mensagem = "Acesso Negado.";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = e.Message;
            }
            return View("Login");
        }
    }
}