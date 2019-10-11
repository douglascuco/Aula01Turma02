using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBicicletas.Model;

namespace BibliotecaBicicletas.Controller
{
    public class BicicletaController
    {
        BicicletaContext contextDB = new BicicletaContext();

        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDB.Bicicletas.Where(x => x.Ativo == true);
        }

       
        public bool AtualizarBicicleta(Bicicleta item)
        {
            var bicicleta = contextDB.Bicicletas.FirstOrDefault(x => x.Id == item.Id);
            if (bicicleta == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();
            return true;
        }

       
        public bool InserirBicicleta(Bicicleta item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Valor <= 0)
                return false;

            contextDB.Bicicletas.Add(item);
            contextDB.SaveChanges();
            return true;
        }

       
        public bool RemoverBicicleta(int id)
        {
            var bicicleta = contextDB.Bicicletas.FirstOrDefault(x => x.Id == id);
            if (bicicleta == null)
                return false;

            bicicleta.Ativo = false;

            contextDB.SaveChanges();
            return true;

        }


    }
}
