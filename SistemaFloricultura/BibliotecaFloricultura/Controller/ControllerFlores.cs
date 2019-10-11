using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaFloricultura.Model;

namespace BibliotecaFloricultura.Controller
{
    public class ControllerFlores
    {
        FloresContext flores = new FloresContext();

        public IQueryable<Flor> GetFlores()
        {
            return flores.Flores;
        }

        public bool AddFlor(Flor flor)
        {
            if (string.IsNullOrWhiteSpace(flor.Nome))
                return false;

            flores.Flores.Add(flor);
            flores.SaveChanges();
            return true;
        }

    }
}
