using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Estoque.Web.Models.CustomValidators
{
    public class UploadFoto : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                HttpPostedFileBase arquivo = (HttpPostedFileBase)value;

                string tipo = arquivo.ContentType;
                int tamanho = arquivo.ContentLength;

                return tipo.Equals("image/jpeg") && tamanho <= Math.Pow(1024, 2);
            }
            catch
            {
                return false;
            }
        }
    }
}