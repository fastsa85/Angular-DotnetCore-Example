using EmployeeOrganizerWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Repositories
{
    public interface IEmployeesRepository
    {
        public Task<List<Employee>> GetEmployeesAsync();
        public Task<bool> PostEmployeeAsync(Employee employee);
        Task<Employee> GetEmployeeByIdAsync(Guid employeeId);
        Task<bool> UpdateEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(Guid employeeId);
    }
}
