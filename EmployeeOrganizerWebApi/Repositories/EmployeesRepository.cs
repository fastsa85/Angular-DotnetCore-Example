using EmployeeOrganizerWebApi.Data;
using EmployeeOrganizerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid employeeId)
        {
            var employee = await GetEmployeeByIdAsync(employeeId);

            if (employee == null)
                return false;

            _appDbContext.Employees.Remove(employee);
            var deleted = await _appDbContext.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<Employee> GetEmployeeByIdAsync(Guid employeeId)
        {
            return await _appDbContext.Employees.SingleOrDefaultAsync<Employee>(e => e.EmployeeId == employeeId);
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _appDbContext.Employees.ToListAsync<Employee>();
        }

        public async Task<bool> PostEmployeeAsync(Employee employee)
        {
            await _appDbContext.Employees.AddAsync(employee);
            var created = await _appDbContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employeeToUpdate)
        {
            var exists = await _appDbContext.Employees.ContainsAsync<Employee>(employeeToUpdate);

            if (exists)
            {
                _appDbContext.Update(employeeToUpdate);
                var updated = await _appDbContext.SaveChangesAsync();
                return updated > 0;
            }

            return false;
        }
    }
}
