using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Estoque.DAL.Persistence;

namespace Estoque.Web.Models.CustomValidators
{
    public class LoginDisponivel : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                string Login = (string)value;
                FuncionarioDal d = new FuncionarioDal();
                return !d.HasLogin(Login);
            }
            catch 
            {
                return false;
            }
        }
    }
}