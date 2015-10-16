using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Estoque.DAL.Entity;
using Estoque.DAL.DataSource;
using Estoque.DAL.Generics;

namespace Estoque.DAL.Persistence
{
    public class FuncionarioDal : GenericDal<Funcionario>
    {
        public Funcionario Authenticate(string Login, string Senha)
        {
            using(Conexao Con = new Conexao())
            {
                return Con.Funcionario
                    .Where(f => f.Login.Equals(Login) && f.Senha.Equals(Senha))
                    .FirstOrDefault();
            }
        }

        public bool HasLogin(string Login)
        {
            using(Conexao Con = new Conexao())
            {
                return Con.Funcionario
                    .Where(f => f.Login.Equals(Login))
                    .Count() > 0;
            }
        }
    }
}
