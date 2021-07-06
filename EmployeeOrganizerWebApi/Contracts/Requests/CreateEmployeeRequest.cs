﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Contracts.Requests
{
    public class CreateEmployeeRequest
    {
        public string EmployeeName { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
