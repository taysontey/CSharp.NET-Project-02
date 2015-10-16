using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Estoque.DAL.Entity;
using System.Configuration;


namespace Estoque.DAL.DataSource
{
    public class Conexao : DbContext
    {
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["estoque"].ConnectionString)
        {
                
        }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
