using Swashbuckle.AspNetCore.Annotations;

namespace Application.Dto
{
    public class WorkingExperienceDto
    {
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public int EmployeeId { get; set; }

        public string Name { get; set; } = null!;

        public string Details { get; set; } = null!;

        public string Environment { get; set; } = null!;

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }
    }
}
