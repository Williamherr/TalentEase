using System.ComponentModel.DataAnnotations.Schema;
namespace TalentEase.Api.Models.Domain
{
    public class Employee
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone_number")]
        public string? PhoneNumber { get; set; }

        [Column("hire_date")]
        public DateTime HireDate { get; set; }

        [Column("job_id")]
        public int JobId { get; set; }

        [Column("salary")]
        public decimal Salary { get; set; }

        [Column("manager_id")]
        public int? ManagerId { get; set; }

        [Column("department_id")]
        public int? DepartmentId { get; set; }

        public Job Job { get; set; }
        public Department Department { get; set; }
        public List<Dependent> Dependents { get; set; }
    }

}

