using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeOrganizerWebApi.Contracts;
using EmployeeOrganizerWebApi.Contracts.Requests;
using EmployeeOrganizerWebApi.Models;
using EmployeeOrganizerWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeOrganizerWebApi.Controllers
{    
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesController(IEmployeesRepository employeesRepository, IMapper mapper)
        {
            _mapper = mapper;
            _employeesRepository = employeesRepository;
        }

        [HttpGet]
        [Route(ApiRoutes.Employees.GetAll)]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeesRepository.GetEmployeesAsync();
            return Ok(_mapper.Map<List<Employee>>(employees));
        }

        [HttpPost]
        [Route(ApiRoutes.Employees.Post)]
        public async Task<IActionResult> PostEmployeeAsync([FromBody] CreateEmployeeRequest employeeRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employee = _mapper.Map<Employee>(employeeRequest);
            var created = await _employeesRepository.PostEmployeeAsync(employee);

            if (created)
            {
                var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                var locationUri = baseUrl + "/" + ApiRoutes.Employees.GetById.Replace("{employeeId}", employee.EmployeeId.ToString());

                return Created(locationUri, employee);
            }

            return NotFound();
        }

        [HttpPut]
        [Route(ApiRoutes.Employees.Put)]
        public async Task<IActionResult> PutEmployee([FromRoute]Guid employeeId, [FromBody]UpdateEmployeeRequest employeeRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employee = await _employeesRepository.GetEmployeeByIdAsync(employeeId);
            _mapper.Map(employeeRequest, employee);

            var updated = await _employeesRepository.UpdateEmployeeAsync(employee);

            if (updated)
            {
                return Ok(_mapper.Map<Department>(employee));
            }

            return NotFound();
        }

        [HttpDelete]
        [Route(ApiRoutes.Employees.Delete)]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid employeeId)
        {
            var deleted = await _employeesRepository.DeleteEmployeeAsync(employeeId);

            if (deleted)
                return NoContent();

            return NotFound();
        }
    }
}