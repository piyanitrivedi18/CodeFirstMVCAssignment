using System.ComponentModel.DataAnnotations;

namespace CodeFirstMVCWebApp.Models
{
    public class DateOfBirthValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int birthYear =  Convert.ToDateTime(value).Year;
            if (birthYear != null)
            {
                if (birthYear >= 2002 && birthYear <= 2005)
                {
                    return ValidationResult.Success;
                }
            }

        return new ValidationResult(ErrorMessage ?? "Year of Birth should be in between 2002 and 2005");
        }

          

    }
}
