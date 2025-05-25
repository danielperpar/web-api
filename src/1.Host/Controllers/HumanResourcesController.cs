using Application;
using Microsoft.AspNetCore.Mvc;
using Application.Dto;
using Application.Mapper;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        [Consumes("application/json")]
        [HttpPost("employee")]
        public async Task<IActionResult> CreateEmployee([FromBody]EmployeeDto employeeDto)
        {
            var employee = _mapper.MapDown(employeeDto);
            await _humanResourcesService.CreateEmployee(employee);
            return Created();
        }

        [ProducesResponseType<List<EmployeeDto>>(200)]
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
