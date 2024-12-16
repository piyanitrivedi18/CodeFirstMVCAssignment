using System.ComponentModel.DataAnnotations;

namespace CodeFirstMVCWebApp.Models
{
    public class DateOfJoiningValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime dt =  Convert.ToDateTime(value);
            if (dt != null)
            {
                if (dt <= Convert.ToDateTime(DateTime.Today))
                {
                    return ValidationResult.Success;
                }
            }

        return new ValidationResult(ErrorMessage ?? "DOJ shall be less than equal to current date.");
        }

          

    }
}
