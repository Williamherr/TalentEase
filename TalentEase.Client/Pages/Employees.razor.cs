using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using TalentEase.Client.Models;
using TalentEase.Client.Services;
using static System.Net.WebRequestMethods;

namespace TalentEase.Client.Pages
{
    public partial class Employees
    {
        Grid<EmployeeDto> grid = default!;
        private List<EmployeeDto> employees = new List<EmployeeDto>();
        private SearchEmployeeDto searchedEmployee = new SearchEmployeeDto();

        [Inject]
        private EmployeeService _employeeService { get; set; }

        Collapse collapse1 = default!;

        private async Task ToggleContentAsync() => await collapse1.ToggleAsync();


        protected override async Task OnInitializedAsync()
        {
            employees = await _employeeService.GetEmployees();
        }
        private async Task<GridDataProviderResult<EmployeeDto>> EmployeesDataProvider(GridDataProviderRequest<EmployeeDto> request)
        {
            var employee = await _employeeService.GetEmployees();

            return await Task.FromResult(new GridDataProviderResult<EmployeeDto> { Data = employees, TotalCount = employees.Count() });
        }

        private void Clear()
        {
            searchedEmployee = new SearchEmployeeDto();
        }


        private async void Search()
        {

            employees = await _employeeService.SearchEmployees(
                searchedEmployee.EmployeeId,
                searchedEmployee.FirstName,
                searchedEmployee.LastName,
                searchedEmployee.Email,
                searchedEmployee.DepartmentName,
                searchedEmployee.CountryName,
                searchedEmployee.RegionName
            );
            grid.Data = employees;
            await grid.RefreshDataAsync();
            grid.ResetPageNumber();
        }



    }
}
