using System.ComponentModel.DataAnnotations.Schema;
namespace TalentEase.Api.Models.Domain
{
    public class Department
    {
        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("department_name")]
        public string DepartmentName { get; set; }

        [Column("location_id")]
        public int? LocationId { get; set; }

        public Location Location { get; set; }
    }
}

