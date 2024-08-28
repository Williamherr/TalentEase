using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Api.Models.Domain
{
    public class Region
    {
        [Column("region_id")]
        public int RegionId { get; set; }

        [Column("region_name")]
        public string? RegionName { get; set; }
    }
}
