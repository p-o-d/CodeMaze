using System;
using System.Collections.Generic;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public EmployeesController(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }

        public IActionResult GetEmployees(Guid companyId)
        {
            var company = _repositoryManager.Company.GetCompany(companyId, false);
            if (company == null)
            {
                _logger.LogError($"Company with id {companyId} not found!");
                return NotFound();
            }

            var employeesFromDb = _repositoryManager.Employee.GetEmployees(companyId, false);
            var employees = _mapper.Map<IEnumerable<EmployeeDto>>(employeesFromDb);
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(Guid companyId, Guid id)
        {
            var company = _repositoryManager.Company.GetCompany(companyId, false);
            if (company == null)
            {
                _logger.LogError($"Company with id {companyId} not found!");
                return NotFound();
            }

            var employeeFromDb = _repositoryManager.Employee.GetEmployee(companyId, id, false);
            if (employeeFromDb == null)
            {
                _logger.LogError($"Employee with id {id} not found!");
                return NotFound();
            }

            var employee = _mapper.Map<EmployeeDto>(employeeFromDb);
            return Ok(employee);
        }
    }
}