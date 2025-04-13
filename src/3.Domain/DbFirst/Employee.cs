using System;
using System.Collections.Generic;

namespace Domain.DbFirst.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public virtual ICollection<WorkingExperience> WorkingExperiences { get; set; } = new List<WorkingExperience>();
}
