using System.Net.Http.Json;
using System.Web;
using TalentEase.Client.Models;

namespace TalentEase.Client.Services
{
    public class EmployeeService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<EmployeeService> _logger;
        public EmployeeService(HttpClient httpClient, ILogger<EmployeeService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        public async Task<List<EmployeeDto>> GetEmployees()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<EmployeeDto>>("https://localhost:8001/api/employees");
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting employees");
                return new List<EmployeeDto>();
            }
        }
        public async Task<List<EmployeeDto>> SearchEmployees(int? employeeId, string? firstName, string? lastName, string? email, string? departmentName, string? countryName, string? regionName)
        {
            try
            {
                var query = HttpUtility.ParseQueryString(string.Empty);
                if (employeeId.HasValue) query["employeeId"] = employeeId.Value.ToString();
                if (!string.IsNullOrEmpty(firstName)) query["firstName"] = firstName;
                if (!string.IsNullOrEmpty(lastName)) query["lastName"] = lastName;
                if (!string.IsNullOrEmpty(email)) query["email"] = email;
                if (!string.IsNullOrEmpty(departmentName)) query["departmentName"] = departmentName;
                if (!string.IsNullOrEmpty(countryName)) query["countryName"] = countryName;
                if (!string.IsNullOrEmpty(regionName)) query["regionName"] = regionName;

                var queryString = query.ToString();

                var response = await _httpClient.GetFromJsonAsync<List<EmployeeDto>>($"https://localhost:8001/api/employees/search?{queryString}");
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching employees");
                return new List<EmployeeDto>();
            }
        }
    }
}
