using System.ComponentModel.DataAnnotations;

namespace CodeFirstMVCWebApp.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee Id is must")]
        //[EmpIdValidator]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee name is must")]
        [RegularExpression(@"[A-Za-z ]+", ErrorMessage = "Only alphabets are allowed")]
        [MinLength(15, ErrorMessage = "Min 15 characters are needed")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "DOB is must")]
        [DateOfBirthValidator]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "DOJ is must")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh-ss}", ApplyFormatInEditMode = true)]
        [DateOfJoiningValidator]
        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        [Range(12000, 60000, ErrorMessage = "Range should be in between 12000 and 60000")]
        public Int32? Salary { get; set; }

        [Required]
        [DepartmentValidator]
        public string Department { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9]+")]
        public string Password { get; set; }
    }
}
