using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeOrganizerWebApi.Contracts;
using EmployeeOrganizerWebApi.Contracts.Requests;
using EmployeeOrganizerWebApi.Data;
using EmployeeOrganizerWebApi.Models;
using EmployeeOrganizerWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

namespace EmployeeOrganizerWebApi.Controllers
{    
    [ApiController]    
    public class DepartmentsController : ControllerBase
    {       
        private readonly IMapper _mapper;
        private readonly IDepartmentsRepository _departmentsRepository;

        public DepartmentsController(IDepartmentsRepository departmentsRepository, IMapper mapper)
        {
            _mapper = mapper;
            _departmentsRepository = departmentsRepository;
        }

        [HttpGet]
        [Route(ApiRoutes.Departments.GetAll)]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await _departmentsRepository.GetAllDepartementsAsync();
            return Ok(_mapper.Map<List<Department>>(departments));
        }

        [HttpPost]
        [Route(ApiRoutes.Departments.Post)]
        public async Task<IActionResult> PostDepartmentAsync([FromBody] Department departmentRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var department = _mapper.Map<Department>(departmentRequest);
            var created = await _departmentsRepository.PostDepartmentAsync(department);            

            if (created)
            {
                var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                var locationUri = baseUrl + "/" + ApiRoutes.Departments.GetById.Replace("{departmentId}", department.DepartmentId.ToString());

                return Created(locationUri, department);
            }

            return NotFound();            
        }

        [HttpPut]
        [Route(ApiRoutes.Departments.Put)]
        public async Task<IActionResult> PutDepartment([FromRoute]Guid departmentId, [FromBody]UpdateDepartmentRequest departmentRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var department = await _departmentsRepository.GetDepartmentByIdAsync(departmentId);
            _mapper.Map(departmentRequest, department);
            
            var updated = await _departmentsRepository.UpdateDepartmentAsync(department);

            if (updated)
            {
                return Ok(_mapper.Map<Department>(department));
            }

            return NotFound();
        }

        [HttpDelete]
        [Route(ApiRoutes.Departments.Delete)]
        public async Task<IActionResult> DeleteDepartment([FromRoute] Guid departmentId)
        {
            var deleted = await _departmentsRepository.DeleteDepartmetByIdAsync(departmentId);

            if (deleted)
                return NoContent();

            return NotFound();
        }
    }
}