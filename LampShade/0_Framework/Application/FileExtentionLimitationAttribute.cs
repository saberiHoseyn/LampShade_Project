using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;


namespace _0_Framework.Application
{
    public class FileExtentionLimitationAttribute : ValidationAttribute, IClientModelValidator
    {
        private readonly string[] _validExtention;

        public FileExtentionLimitationAttribute(string[] validExtention)
        {
            _validExtention = validExtention;
        }

        public override bool IsValid(object value)
        {
            var file = value as IFormFile;
            if (file == null) return true;

            var fileExtention = Path.GetExtension(file.FileName);
            return _validExtention.Contains(fileExtention);
        }

        void IClientModelValidator.AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-FileExtentionLimitation", ErrorMessage);
        }
    }
}
