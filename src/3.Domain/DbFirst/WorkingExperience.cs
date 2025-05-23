﻿namespace Domain.DbFirst.Entities;

public partial class WorkingExperience
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Details { get; set; } = null!;

    public string Environment { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
