using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        EntityContext contextDB = new EntityContext();

        public IQueryable<Pessoa> GetPessoas()
        {
            return contextDB.ListaDePessoas;

        }

        public void AddPessoa(Pessoa pessoa)
        {
            contextDB.ListaDePessoas.Add(pessoa);

            contextDB.SaveChanges();
        }
    }
}
