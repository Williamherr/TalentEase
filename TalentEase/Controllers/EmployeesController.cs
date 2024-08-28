using Microsoft.AspNetCore.Mvc;
using TalentEase.Api.Models.Dto;
using TalentEase.Api.Repository;

namespace TalentEase.Api.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(IEmployeeRepository employeeRepository, ILogger<EmployeesController> logger)
        {
            _employeeRepo = employeeRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployees()
        {
            try
            {
                var employees = await _employeeRepo.GetEmployees();
                return Ok(employees);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching for employees.");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> SearchEmployees(
          [FromQuery] int? employeeId,
          [FromQuery] string? firstName,
          [FromQuery] string? lastName,
          [FromQuery] string? email,
          [FromQuery] string? departmentName,
          [FromQuery] string? countryName,
          [FromQuery] string? regionName)
        {
            try
            {
                var employees = await _employeeRepo
                    .SearchEmployees(employeeId, firstName, lastName, email, 
                        departmentName, countryName, regionName);
                return Ok(employees);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while searching for employees.");
                return BadRequest(ex.Message);
            }
        }

    }
}
