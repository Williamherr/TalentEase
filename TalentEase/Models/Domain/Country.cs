using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Api.Models.Domain
{
    public class Country
    {
        [Column("country_id")]
        public string CountryId { get; set; }

        [Column("country_name")]
        public string? CountryName { get; set; }

        [Column("region_id")]
        public int RegionId { get; set; }

        public Region Region { get; set; }
    }
}
