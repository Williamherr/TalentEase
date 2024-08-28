using System.ComponentModel.DataAnnotations.Schema;
namespace TalentEase.Api.Models.Dto
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public LocationDto Location { get; set; }
    }
}

