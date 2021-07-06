using EmployeeOrganizerWebApi.Data;
using EmployeeOrganizerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Repositories
{
    public class DepartmentsRepository : IDepartmentsRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Department>> GetAllDepartementsAsync()
        {
            return await _appDbContext.Departments.ToListAsync<Department>();
        }

        public async Task<bool> PostDepartmentAsync(Department department)
        {
            await _appDbContext.Departments.AddAsync(department);
            var created = await _appDbContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<Department> GetDepartmentByIdAsync(Guid departmentId)
        {
            return await _appDbContext.Departments.SingleOrDefaultAsync<Department>(d => d.DepartmentId == departmentId);
        }

        public async Task<bool> UpdateDepartmentAsync(Department departmentToUpdate)
        {
            var exists = await _appDbContext.Departments.ContainsAsync<Department>(departmentToUpdate);

            if (exists)
            {
                _appDbContext.Update(departmentToUpdate);
                var updated = await _appDbContext.SaveChangesAsync();
                return updated > 0;

            
            }

            return false;
        }

        public async Task<bool> DeleteDepartmetByIdAsync(Guid departmentId)
        {
            var department = await GetDepartmentByIdAsync(departmentId);

            if (department == null)
                return false;

            _appDbContext.Departments.Remove(department);
            var deleted = await _appDbContext.SaveChangesAsync();
            return deleted > 0;
        }
    }
}
