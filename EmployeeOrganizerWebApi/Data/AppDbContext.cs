using EmployeeOrganizerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Data
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = new Guid("00000001-20db-4800-8d19-c7f7162900ec"), DepartmentName = "Finance"},
                new Department { DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"), DepartmentName = "Sales"},
                new Department { DepartmentId = new Guid("00000003-20db-4800-8d19-c7f7162900ec"), DepartmentName = "Engineering"},
                new Department { DepartmentId = new Guid("00000004-20db-4800-8d19-c7f7162900ec"), DepartmentName = "Manufacturing"},
                new Department { DepartmentId = new Guid("00000005-20db-4800-8d19-c7f7162900ec"), DepartmentName = "Management"}
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = new Guid("00000001-1111-4800-8d19-c7f7162900ec"),
                    DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"),
                    EmployeeName = "Bilbo Baggins",
                    DateOfJoining = new DateTime(2020, 6, 1),
                    PhotoFileName = "Bilbo Baggins" + new Guid("00000005-20db-4800-8d19-c7f7162900ec") +".jpg"
                },
                new Employee
                {
                    EmployeeId = new Guid("00000002-1111-4800-8d19-c7f7162900ec"),
                    DepartmentId = new Guid("00000004-20db-4800-8d19-c7f7162900ec"),
                    EmployeeName = "Tom Sawyer",
                    DateOfJoining = new DateTime(2018, 12, 31),
                    PhotoFileName = "Tom Sawyer" + new Guid("00000002-1111-4800-8d19-c7f7162900ec") + ".jpg"
                },
                new Employee
                {
                    EmployeeId = new Guid("00000003-1111-4800-8d19-c7f7162900ec"),
                    EmployeeName = "Alice Wonderland",
                    DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"),
                    DateOfJoining = new DateTime(2019, 2, 14),
                    PhotoFileName = "Alice Wonderland" + new Guid("00000003-1111-4800-8d19-c7f7162900ec") + ".jpg"
                },
                new Employee
                {
                    EmployeeId = new Guid("00000004-1111-4800-8d19-c7f7162900ec"),
                    EmployeeName = "Jack Sparrow",
                    DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"),
                    DateOfJoining = new DateTime(2017, 7, 7),
                    PhotoFileName = "Jack Sparrow" + new Guid("00000004-1111-4800-8d19-c7f7162900ec") + ".jpg"
                },
                new Employee
                {
                    EmployeeId = new Guid("00000005-1111-4800-8d19-c7f7162900ec"),
                    EmployeeName = "John Snow",
                    DepartmentId = new Guid("00000005-20db-4800-8d19-c7f7162900ec"),
                    DateOfJoining = new DateTime(2017, 5, 7),
                    PhotoFileName = "John Snow" + new Guid("00000005-1111-4800-8d19-c7f7162900ec") + ".jpg"
                },
                new Employee
                {
                    EmployeeId = new Guid("00000006-1111-4800-8d19-c7f7162900ec"),
                    EmployeeName = "Stephen King",
                    DepartmentId = new Guid("00000003-20db-4800-8d19-c7f7162900ec"),
                    DateOfJoining = new DateTime(2018, 3, 6),
                    PhotoFileName = "Stephen King" + new Guid("00000006-1111-4800-8d19-c7f7162900ec") + ".jpg"
                },
                 new Employee
                 {
                     EmployeeId = new Guid("00000007-1111-4800-8d19-c7f7162900ec"),
                     EmployeeName = "Anna Karenina",
                     DepartmentId = new Guid("00000003-20db-4800-8d19-c7f7162900ec"),
                     DateOfJoining = new DateTime(2019, 4, 28),
                     PhotoFileName = "Stephen King" + new Guid("00000007-1111-4800-8d19-c7f7162900ec") + ".jpg"
                 }
            );
        }
    }
}
