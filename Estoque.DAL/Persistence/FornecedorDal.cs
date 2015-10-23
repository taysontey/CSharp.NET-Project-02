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
    public class FornecedorDal : GenericDal<Fornecedor>
    {
        public void Delete(int IdFornecedor)
        {
            using(Conexao Con = new Conexao())
            {
                var found_fornecedor = Con.Fornecedor
                            .Where(f => f.IdFornecedor == IdFornecedor)
                            .FirstOrDefault();

                Con.Fornecedor.Remove(found_fornecedor);
                Con.SaveChanges();
            }
        }
    }
}
