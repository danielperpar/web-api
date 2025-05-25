using DbFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Application.IntegrationTests
{
    internal class TestUtils
    {
        public static CursoEFContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<CursoEFContext>()
           .UseInMemoryDatabase(databaseName: "DBFirstCursoEF")
           .Options;

            return new CursoEFContext(options);
        }
    }
}
