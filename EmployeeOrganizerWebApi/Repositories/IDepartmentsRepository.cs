using EmployeeOrganizerWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Repositories
{
    public interface IDepartmentsRepository
    {
        public Task<List<Department>> GetAllDepartementsAsync();
        public Task<bool> PostDepartmentAsync(Department department);
        public Task<Department> GetDepartmentByIdAsync(Guid departmentId);
        public Task<bool> UpdateDepartmentAsync(Department departmentToUpdate);
        public Task<bool> DeleteDepartmetByIdAsync(Guid departmentId);
    }
}
