using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Api.Models.Domain
{
    public class Location
    {
        [Column("location_id")]
        public int LocationId { get; set; }

        [Column("street_address")]
        public string? StreetAddress { get; set; }

        [Column("postal_code")]
        public string? PostalCode { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state_province")]
        public string? StateProvince { get; set; }

        [Column("country_id")]
        public string CountryId { get; set; }

        public Country Country { get; set; }
    }
}
