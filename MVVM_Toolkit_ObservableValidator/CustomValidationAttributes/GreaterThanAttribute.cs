using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Observable_Validator
{
    internal class GreaterOrEqualThanAttribute : ValidationAttribute
    {
        public GreaterOrEqualThanAttribute(string propertyName)
        {
            this.propertyName = propertyName;
        }

        private readonly string propertyName;

        protected override ValidationResult IsValid(object? valueToValidate, ValidationContext validationContext)
        {
	        object instance = validationContext.ObjectInstance;
	        object? referenceValue = instance.GetType().GetProperty(this.propertyName)?.GetValue(instance);

	        if ((int)valueToValidate >= (int)referenceValue)
            {
                return ValidationResult.Success;
            }

            return new("The current value is smaller than the other one");
        }

    }
}
