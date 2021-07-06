using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api/";

        public static class Departments
        {
            private const string Base = Root + nameof(Departments);

            public const string GetAll = Base;
            public const string GetById = Base + "/{departmentId}";
            public const string Post = Base;
            public const string Put = Base + "/{departmentId}";
            public const string Delete = Base + "/{departmentId}";
        }

        public static class Employees
        {
            private const string Base = Root + nameof(Employees);

            public const string GetAll = Base;
            public const string GetById = Base + "/{employeeId}";
            public const string Post = Base;
            public const string Put = Base + "/{employeeId}";
            public const string Delete = Base + "/{employeeId}";
        }
    }
}
