using Kodlama.io.Devs.Api.Application.Services.Repositories;
using Kodlama.io.Devs.Persistence.Contexts;
using Kodlama.io.Devs.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kodlama.io.Devs.Persistence.Extensions
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                               IConfiguration configuration)
        {
            //services.AddDbContext<BaseDbContext>(options =>
            //                                         options.UseSqlServer(
            //                                             configuration.GetConnectionString("KodlamaIODevsCampConnectionString")));
            services.AddDbContext<BaseDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("KodlamaIODevsCampConnectionString")));
            services.AddScoped<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();

            return services;
        }
    }
}
