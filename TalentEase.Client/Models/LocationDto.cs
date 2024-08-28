using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Client.Models
{
    public class LocationDto
    {
        public int LocationId { get; set; }
        public string? StreetAddress { get; set; }
        public string? PostalCode { get; set; }
        public string City { get; set; }
        public string? StateProvince { get; set; }
        public CountryDto Country { get; set; }
    }
}
