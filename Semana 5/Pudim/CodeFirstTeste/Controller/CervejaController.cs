using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        Model1 contextDB = new Model1(@"data source=(localdb)\MSSQLLocalDB;initial catalog=RevisandoEntity.Model.CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void AddCerveja(Cerveja cerveja)
        {
            contextDB.Cervejas.Add(cerveja);
            contextDB.SaveChanges();
           
        }
    }
}
