using Core.Persistence.Repositories;
using Kodlama.io.Devs.Api.Domain.Entities;

namespace Kodlama.io.Devs.Api.Application.Services.Repositories
{
    public interface IProgrammingLanguageRepository : IAsyncRepository<ProgrammingLanguage>, IRepository<ProgrammingLanguage>
    {
    }
}
