using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiLC.Models
{
    public class MaxSevenUsers:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext )
        {
            var mesa = (Mesa) validationContext.ObjectInstance;
            if (mesa.Usuarios.Count() > 7)
            {
                return new ValidationResult("La cantidad de personas en la mesa no puede ser mayor a 7.");
            }
            else
            {
                return ValidationResult.Success;
            }

        }
    }
}