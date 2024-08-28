using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Api.Models.Dto
{
    public class JobDto
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
    }
}
