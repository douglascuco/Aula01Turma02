using ListasDePessoas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDePessoas.Controller
{
    public class PessoaController
    {
        private List<Pessoa> Pessoas { get; set; }
        public PessoaController()
        {
            Pessoas = new List<Pessoa>();

            Pessoas.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Spears",
                DataNasc = DateTime.Parse("07/11/2004"),
                Carteira = 846.96
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 2,
                Nome = "Swanson",
                DataNasc = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Gay",
                DataNasc = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 4,
                Nome = "Gregory",
                DataNasc = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 5,
                Nome = "Olson",
                DataNasc = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 6,
                Nome = "Garzz",
                DataNasc = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 7,
                Nome = "Sweet",
                DataNasc = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 8,
                Nome = "Cline",
                DataNasc = DateTime.Parse("26/03/2002"),
                Carteira = 484.51
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 9,
                Nome = "Oliver",
                DataNasc = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 9,
                Nome = "Vang",
                DataNasc = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 10,
                Nome = "Vang",
                DataNasc = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 11,
                Nome = "Maddox",
                DataNasc = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 12,
                Nome = "Garrett",
                DataNasc = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 13,
                Nome = "Mcintosh",
                DataNasc = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 14,
                Nome = "Yang",
                DataNasc = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 15,
                Nome = "Hendricks",
                DataNasc = DateTime.Parse("05/09/2003"),
                Carteira = 410.56
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 16,
                Nome = "Cain",
                DataNasc = DateTime.Parse("12/01/2002"),
                Carteira = 221.13
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 17,
                Nome = "Blackburn",
                DataNasc = DateTime.Parse("10/05/2000"),
                Carteira = 135.67
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 18,
                Nome = "Howe",
                DataNasc = DateTime.Parse("27/09/2005"),
                Carteira = 360.14
            });

            Pessoas.Add(new Pessoa()
            {
                Id = 19,
                Nome = "Pratt",
                DataNasc = DateTime.Parse("27/09/2001"),
                Carteira = 991.83
            });
          
            Pessoas.Add(new Pessoa()
            {
                Id = 20,
                Nome = "Sherman",
                DataNasc = DateTime.Parse("20/02/2003"),
                Carteira = 667.00
            });
          
        }

        public List<Pessoa> MostraListaPessoas()
        {
            return Pessoas;
        }
    }
}
