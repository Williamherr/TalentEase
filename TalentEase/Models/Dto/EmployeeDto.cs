using System.ComponentModel.DataAnnotations.Schema;
namespace TalentEase.Api.Models.Dto
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public JobDto Job { get; set; }
        public DepartmentDto Department { get; set; }
        public List<DependentDto> Dependents { get; set; }
    }

}

