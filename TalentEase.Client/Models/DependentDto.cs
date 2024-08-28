using System.ComponentModel.DataAnnotations.Schema;
namespace TalentEase.Client.Models
{
    public class DependentDto
    {
        public int DependentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }
    }

}

