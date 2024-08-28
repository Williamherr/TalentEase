namespace TalentEase.Client.Models
{
    public class SearchEmployeeDto
    {
        public int? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? DepartmentName { get; set; }
        public string? CountryName { get; set; }
        public string? RegionName { get; set; }
    }
}
