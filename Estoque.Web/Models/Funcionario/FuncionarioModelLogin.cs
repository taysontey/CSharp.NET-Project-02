using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Estoque.Web.Models
{
    public class FuncionarioModelLogin
    {
        [Required(ErrorMessage = "Preencha o campo Login.")]
        [Display(Name = "Login:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        [Display(Name = "Manter conectado.")]
        public bool ManterConectado { get; set; }
    }
}