using System.ComponentModel.DataAnnotations;

namespace CodeFirstMVCWebApp.Models
{
    public class DepartmentValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string? dept = (string?)value;
            if (dept != null && (dept == "HR" || dept == "IT" || dept == "Accts"))
            {
                return ValidationResult.Success;
            }

        return new ValidationResult(ErrorMessage ?? "Dept should be HR, IT or Accts.");
        }
    }
}
