using System.ComponentModel.DataAnnotations.Schema;
namespace TalentEase.Api.Models.Dto
{
    public class DependentDto
    {
        public int DependentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }
    }

}

