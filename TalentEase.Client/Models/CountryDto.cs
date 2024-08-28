using System.ComponentModel.DataAnnotations.Schema;
using TalentEase.Client.Models;

namespace TalentEase.Client.Models
{
    public class CountryDto
    {
        public string CountryId { get; set; }
        public string? CountryName { get; set; }
        public RegionDto Region { get; set; }
    }

}
