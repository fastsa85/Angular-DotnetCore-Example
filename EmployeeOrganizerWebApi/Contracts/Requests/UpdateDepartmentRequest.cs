using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Contracts.Requests
{
    public class UpdateDepartmentRequest
    {
        [Required]
        public string DepartmentName { get; set; }
    }
}
