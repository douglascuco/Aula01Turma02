using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaListagem.Model;

namespace BibliotecaListagem.Controller
{
    public class ControllerPessoas
    {
        PessoasContext pessoasContext = new PessoasContext();

        public List<Pessoa> GetPessoas()
        {
            return pessoasContext.Pessoas.ToList<Pessoa>();
        }

        public bool AddPessoa(Pessoa pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                return false;


            pessoasContext.Pessoas.Add(pessoa);
            pessoasContext.SaveChanges();
            return true;
        }

    }
}
