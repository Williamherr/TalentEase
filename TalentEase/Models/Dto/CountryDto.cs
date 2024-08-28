using System.ComponentModel.DataAnnotations.Schema;
using TalentEase.Api.Models.Domain;

namespace TalentEase.Api.Models.Dto
{
    public class CountryDto
    {
        public string CountryId { get; set; }
        public string? CountryName { get; set; }
        public RegionDto Region { get; set; }
    }

}
