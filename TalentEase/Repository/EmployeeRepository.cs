using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TalenEase.Api.Data;
using TalentEase.Api.Models.Domain;
using TalentEase.Api.Models.Dto;

namespace TalentEase.Api.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HRDataDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeRepository(HRDataDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            var employees = await GetEmployeesQuery();
            var employeeDtos = _mapper.Map<List<EmployeeDto>>(employees);

            return employeeDtos;
        }

        public async Task<IEnumerable<EmployeeDto>> SearchEmployees(
             int? employeeId,
             string? firstName,
             string? lastName,
             string? email,
             string? departmentName,
             string? countryName,
             string? regionName)
        {
            var query = await GetEmployeesQuery();

            if (employeeId.HasValue)
                query = query.Where(e => e.EmployeeId == employeeId.Value);
            if (!string.IsNullOrEmpty(firstName))
                query = query.Where(e => e.FirstName.Contains(firstName));
            if (!string.IsNullOrEmpty(lastName))
                query = query.Where(e => e.LastName.Contains(lastName));
            if (!string.IsNullOrEmpty(email))
                query = query.Where(e => e.Email.Contains(email));
            if (!string.IsNullOrEmpty(departmentName))
                query = query.Where(e => e.Department.DepartmentName.Contains(departmentName));
            if (!string.IsNullOrEmpty(countryName))
                query = query.Where(e => e.Department.Location.Country.CountryName.Contains(countryName));
            if (!string.IsNullOrEmpty(regionName))
                query = query.Where(e => e.Department.Location.Country.Region.RegionName.Contains(regionName));

            var employees = await query.ToListAsync();
            var employeeDtos = _mapper.Map<List<EmployeeDto>>(employees);

            return employeeDtos;
        }
        public Task<IQueryable<Employee>> GetEmployeesQuery()
        {
            var query = _context.Employees
                .Include(e => e.Dependents)
                .Include(e => e.Job)
                .Include(e => e.Department)
                    .ThenInclude(d => d.Location)
                        .ThenInclude(l => l.Country)
                            .ThenInclude(c => c.Region)
                .AsQueryable();

            return Task.FromResult(query);
        }


    }
}
