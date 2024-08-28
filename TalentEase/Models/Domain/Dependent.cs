using System.ComponentModel.DataAnnotations.Schema;
namespace TalentEase.Api.Models.Domain
{
    public class Dependent
    {
        [Column("dependent_id")]
        public int DependentId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("relationship")]
        public string Relationship { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}

