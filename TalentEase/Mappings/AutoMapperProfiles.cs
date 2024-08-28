using AutoMapper;
using TalentEase.Api.Models.Domain;
using TalentEase.Api.Models.Dto;

namespace TalentEase.Api.Mappings
{

    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Dependent, DependentDto>();
            CreateMap<Job, JobDto>();
            CreateMap<Department, DepartmentDto>();
            CreateMap<Location, LocationDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Region, RegionDto>();

        }
    }
}
