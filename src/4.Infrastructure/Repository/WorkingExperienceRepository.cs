using DbFirst.Entities;
using Domain.DbFirst.Entities;
using Domain.DbFirst.Entities.Repository;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Infrastructure.Repository
{
    internal class WorkingExperienceRepository : IWorkingExperienceRepository
    {
        private readonly DbFirstCursoEFContext _dbFirstCursoEFContext;

        public WorkingExperienceRepository(DbFirstCursoEFContext dbFirstCursoEFContext)
        {
            _dbFirstCursoEFContext = _dbFirstCursoEFContext;
        }
        public void AddWorkingExperience(WorkingExperience workingExperience)
        {
            _dbFirstCursoEFContext.WorkingExperiences.Add(workingExperience);
        }

        public async Task<IEnumerable<WorkingExperience>> GetAllAsync()
        {
            return await _dbFirstCursoEFContext.WorkingExperiences.ToListAsync();
        }
    }
}
