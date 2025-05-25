using DbFirst.Entities;
using Domain.DbFirst.Entities;
using Domain.DbFirst.Entities.Repository;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Infrastructure.Repository
{
    internal class WorkingExperienceRepository : IWorkingExperienceRepository
    {
        private readonly CursoEFContext _dbFirstCursoEFContext;

        public WorkingExperienceRepository(CursoEFContext dbFirstCursoEFContext)
        {
            _dbFirstCursoEFContext = dbFirstCursoEFContext;
        }
        public void AddWorkingExperience(WorkingExperience workingExperience)
        {
            _dbFirstCursoEFContext.WorkingExperiences.Add(workingExperience);
        }

        public async Task<IEnumerable<WorkingExperience>> GetAllAsync()
        {
            return await _dbFirstCursoEFContext.WorkingExperiences.AsNoTracking().ToListAsync();
        }
    }
}
