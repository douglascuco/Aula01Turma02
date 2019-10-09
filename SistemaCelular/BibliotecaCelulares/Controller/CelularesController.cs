using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCelulares.Model;

namespace BibliotecaCelulares.Controller
{
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();

        /// <summary>
        /// retorna uma lista de todos os celulares cadastrados que estão ativos
        /// </summary>
        /// <returns>lista de celulares</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB.Celulares.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Atualiza informações de um celular
        /// </summary>
        /// <param name="item">Celular com novas Informações</param>
        /// <returns>falso caso o celular não exista ou true caso tenha sucesso em atualizar o celular</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == item.Id);
            if (celular == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();
            return true;
        }

        /// <summary>
        /// Insere Um celular na lista de celulares
        /// </summary>
        /// <param name="item">Celular que vai ser inserido na lista</param>
        /// <returns>false caso tenha erros de validação ou true caso ele insira com sucesso</returns>
        public bool InserirCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;
            if (string.IsNullOrWhiteSpace(item.Model))
                return false;
            if (item.Preco <= 0)
                return false;

            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();
            return true;
        }

        /// <summary>
        /// Altera o status ativo do celular para falso
        /// </summary>
        /// <param name="id">id do celular que deseja alterar</param>
        /// <returns>false se o celular não existe ou true caso o celular exista</returns>
        public bool RemoverCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == id);
            if (celular == null)
                return false;

            celular.Ativo = false;

            contextDB.SaveChanges();
            return true;
              
        }


    }
}
