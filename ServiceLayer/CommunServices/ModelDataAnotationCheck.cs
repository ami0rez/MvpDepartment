using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CommunServices
{
    public class ModelDataAnotationCheck : IModelDataAnotationCheck
    {
        public void ValidateModelDataAnotations<TDomainName>(TDomainName domainModel)
        {
            ICollection<ValidationResult> validationResultsList = new List<ValidationResult>();

            ValidationContext validationContext = new ValidationContext(domainModel, null, null);

            StringBuilder validationString = new StringBuilder();
            if (!Validator.TryValidateObject(domainModel, validationContext, validationResultsList, validateAllProperties: true))
            {
                foreach(ValidationResult validationResult in validationResultsList)
                {
                    validationString.Append(validationResult.ErrorMessage)
                                    .AppendLine();
                }
            }

            if(validationResultsList.Count > 0)
            {
                throw new ArgumentException(validationString.ToString());
            }
        }
    }
}
