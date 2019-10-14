using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    public class CervejaController
    {
        CervejaContextDB contextDB = new CervejaContextDB();

        public void AddCerveja(Cerveja cerveja)
        {
            if (cerveja.Nome.Contains("Cerveja"))
            {
                contextDB.Cervejas.Add(cerveja);
            }

            contextDB.SaveChanges();
        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDB.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }

    }
}
