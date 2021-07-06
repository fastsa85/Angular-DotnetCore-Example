using AutoMapper;
using EmployeeOrganizerWebApi.Contracts.Requests;
using EmployeeOrganizerWebApi.Models;

namespace EmployeeOrganizerWebApi.Mapping
{
    public class DomainToContractsMapping : Profile
    {
        public DomainToContractsMapping()
        {
            CreateMap<UpdateDepartmentRequest, Department>();
            CreateMap<CreateEmployeeRequest, Employee>();
            CreateMap<UpdateEmployeeRequest, Employee>();
        }
    }
}
