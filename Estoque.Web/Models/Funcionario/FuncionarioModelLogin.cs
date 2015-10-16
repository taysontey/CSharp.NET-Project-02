using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Estoque.Web.Models
{
    public class FuncionarioModelLogin
    {
        [Required(ErrorMessage = "Erro, informe o login corretamente.")]
        [Display(Name = "Login:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Erro, informe a senha corretamente.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }
    }
}