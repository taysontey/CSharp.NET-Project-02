using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estoque.Web.Areas.Admin.Models
{
    public class ProdutoModelConsulta
    {
        public int IdProduto { get; set; }
    }

    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public int IdFornecedor { get; set; }
    }
}