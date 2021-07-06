using EmployeeOrganizerWebApi.Data;
using EmployeeOrganizerWebApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("EmployeeDBConnection")));

            services.AddScoped<IDepartmentsRepository, DepartmentsRepository>();
            services.AddScoped<IEmployeesRepository, EmployeesRepository>();
        }
    }
}
