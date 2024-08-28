using TalentEase.Api.Models.Dto;

namespace TalentEase.Api.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees();
        Task<IEnumerable<EmployeeDto>> SearchEmployees(
            int? employeeId,
            string? firstName,
            string? lastName,
            string? email,
            string? departmentName,
            string? countryName,
            string? regionName);
    }
}
