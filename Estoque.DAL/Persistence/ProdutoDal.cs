using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Estoque.DAL.DataSource;
using Estoque.DAL.Entity;
using Estoque.DAL.Generics;

namespace Estoque.DAL.Persistence
{
    public class ProdutoDal : GenericDal<Produto>
    {
        public void Delete(int IdProduto)
        {
            using (Conexao Con = new Conexao())
            {
                var found_produto = Con.Produto
                            .Where(p => p.IdProduto == IdProduto)
                            .FirstOrDefault();

                Con.Produto.Remove(found_produto);
                Con.SaveChanges();
            }
        }
    }
}
