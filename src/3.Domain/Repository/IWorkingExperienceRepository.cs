namespace Domain.DbFirst.Entities.Repository
{
    public interface IWorkingExperienceRepository
    {
        void AddWorkingExperience(WorkingExperience workingExperience);

        Task<IEnumerable<WorkingExperience>> GetAllAsync();
    }
}
