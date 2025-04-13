using Domain.DbFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Entities;

public partial class DbFirstCursoEFContext : DbContext
{
    public DbFirstCursoEFContext()
    {
    }

    public DbFirstCursoEFContext(DbContextOptions<DbFirstCursoEFContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<WorkingExperience> WorkingExperiences { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeName).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkingExperience>(entity =>
        {
            entity.ToTable("WorkingExperience");

            entity.Property(e => e.Details).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Environment).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Employee).WithMany(p => p.WorkingExperiences)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkingExperience_Employee");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
