using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Api.Models.Dto
{
    public class RegionDto
    {
        public int RegionId { get; set; }
        public string? RegionName { get; set; }
    }
}
