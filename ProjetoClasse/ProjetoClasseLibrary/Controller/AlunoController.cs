using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoClasseLibrary.Model;

namespace ProjetoClasseLibrary.Controller
{
    public class AlunoController
    {
        ProjetoContextBD contextDB = new ProjetoContextBD();

        public IQueryable<Aluno> GetAlunos()
        {
            return contextDB.ListaDeAlunos;
        }

        public void AddPessoa(Aluno aluno)
        {
            contextDB.ListaDeAlunos.Add(aluno);
        }

        public void SalvarDB()
        {
            contextDB.SaveChanges();
        }
    }
}
