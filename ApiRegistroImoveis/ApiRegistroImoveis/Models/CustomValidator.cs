using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiRegistroImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        MigrationContext db = new MigrationContext();

       
        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            if(validationContext.DisplayName == "Nome")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usuário já existe em nossa base de dados.");
            }

            if(validationContext.DisplayName == "DataDeNasc")
            {
                var anoUsuario = Convert.ToDateTime(value).Year;
                var anoHoje = DateTime.Now.Year;

                if (Convert.ToDateTime(value).Year >= (DateTime.Now.Year - 18) || Convert.ToDateTime(value).Year <= (DateTime.Now.Year - 150))
                    return new ValidationResult("Usuário não tem idade suficiente para ser cadastrado.");
                
            }

            if(validationContext.DisplayName == "Email")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Email == value.ToString()) != null)
                    return new ValidationResult("Email já cadastrado em nossa base de dados.");
            }

            return ValidationResult.Success;
        }
    }
}