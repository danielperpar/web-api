using Domain.DbFirst.Entities;

namespace Application.Dto
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = null!;

        public ICollection<WorkingExperienceDto> WorkingExperiences { get; set; }
    }
}
