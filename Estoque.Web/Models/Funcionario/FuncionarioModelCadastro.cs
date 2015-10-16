using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Estoque.Web.Models.CustomValidators;

namespace Estoque.Web.Models
{
    public class FuncionarioModelCadastro
    {
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        [Display(Name = "Nome do Funcionário:")]
        public string Nome { get; set; }

        [LoginDisponivel(ErrorMessage = "Erro. Este Login já encontra-se em uso.")]
        [Required(ErrorMessage = "Por favor, informe o login de acesso.")]
        [Display(Name = "Login de Acesso:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha de acesso.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso:")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Por favor, confirme a senha de acesso.")]
        [Compare("Senha", ErrorMessage = "Por favor, confirme a senha de acesso.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme sua Senha:")]
        public string ConfirmaSenha { get; set; }

        [UploadFoto(ErrorMessage = "Erro. Envie apenas imagens JPG de até 1MB.")]
        [Required(ErrorMessage = "Por favor, envie sua foto.")]
        [Display(Name = "Envie sua Foto:")]
        public HttpPostedFileBase Foto { get; set; }
    }
}