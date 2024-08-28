using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Client.Models
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public LocationDto Location { get; set; }
    }
}

