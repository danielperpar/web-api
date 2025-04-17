using Domain.DbFirst.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace Application.Dto
{
    public class EmployeeDto
    {
        [SwaggerSchema(ReadOnly = true)]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = null!;

        public ICollection<WorkingExperienceDto> WorkingExperiences { get; set; }
    }
}
