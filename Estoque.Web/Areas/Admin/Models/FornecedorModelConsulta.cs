using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estoque.Web.Areas.Admin.Models
{
    public class FornecedorModelConsulta
    {
        public int IdFornecedor { get; set; }
    }

    public class FornecedorModel
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
    }
}