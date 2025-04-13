﻿using Application;
using Microsoft.AspNetCore.Mvc;
using Application.Dto;
using Application.Mapper;

namespace Api.Controllers
{
    public class HumanResourcesController : ControllerBase
    {
        private readonly IHumanResourcesService _humanResourcesService;
        private readonly IMapper _mapper;

        public HumanResourcesController(IHumanResourcesService humanResourcesService, IMapper mapper)
        {
            _humanResourcesService = humanResourcesService;
            _mapper = mapper;
        }

        [ProducesResponseType(200)]
        [Produces("application/json")]
        [HttpPost("employee")]
        public IActionResult CreateEmployee(EmployeeDto employeeDto)
        {
            var employee = _mapper.MapDown(employeeDto);
            _humanResourcesService.CreateEmployee(employee);
            return Created();
        }

        [ProducesResponseType<IEnumerable<EmployeeDto>>(200)]
        [Produces("application/json")]
        [HttpGet("employees")]
        public async Task<IActionResult> GetEmployees()
        {
           var employees = await _humanResourcesService.GetAllEmployees();
           var dtos = _mapper.MapUp(employees);
           return Ok(dtos);
        }
    }
}
