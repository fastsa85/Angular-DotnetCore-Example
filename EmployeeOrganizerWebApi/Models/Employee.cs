using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        public Guid DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [IgnoreDataMember]
        public Department Department { get; set; }

        public string EmployeeName { get; set; }        
        public DateTime DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
